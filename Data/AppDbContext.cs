using Microsoft.EntityFrameworkCore;
using Mission07_Smith_Ethan.Models;
using System.Collections.Generic;

namespace Mission07_Smith_Ethan.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}