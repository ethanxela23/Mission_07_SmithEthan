using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Mission07_Smith_Ethan.Data;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// ✅ Correct filename that actually exists
var dbPath = Path.Combine(builder.Environment.ContentRootPath, "Data", "joelMovies.sqlite");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite($"Data Source={dbPath}"));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();