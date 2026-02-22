using Mission07_Smith_Ethan.Models;

namespace Mission07_Smith_Ethan.Data
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.Categories.Any())
            {
                return; // DB already seeded
            }

            var categories = new Category[]
            {
                new Category { CategoryName = "Miscellaneous" },
                new Category { CategoryName = "Drama" },
                new Category { CategoryName = "Television" },
                new Category { CategoryName = "Horror/Suspense" },
                new Category { CategoryName = "Comedy" },
                new Category { CategoryName = "Family" },
                new Category { CategoryName = "Action/Adventure" },
                new Category { CategoryName = "VHS" }
            };

            context.Categories.AddRange(categories);
            context.SaveChanges();
        }
    }
}