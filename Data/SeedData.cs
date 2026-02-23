using Mission07_Smith_Ethan.Models;

namespace Mission07_Smith_Ethan.Data
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            // If movies already exist, stop
            if (context.Movies.Any())
            {
                return;
            }

            // =========================
            // ADD CATEGORIES
            // =========================
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

            // =========================
            // ADD MOVIES
            // CategoryId matches order above
            // =========================
            var movies = new Movie[]
            {
                new Movie { CategoryId = 6, Title="Finding Nemo", Year=2003, Director="Andrew Stanton", Rating="G", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 6, Title="The Incredibles", Year=2004, Director="Brad Bird", Rating="PG", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 6, Title="Toy Story", Year=1995, Director="John Lasseter", Rating="G", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 6, Title="Toy Story 2", Year=1999, Director="John Lasseter", Rating="G", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 6, Title="Toy Story 3", Year=2010, Director="Lee Unkrich", Rating="G", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 6, Title="Monsters Inc.", Year=2001, Director="Pete Docter", Rating="G", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },

                new Movie { CategoryId = 7, Title="Batman Begins", Year=2005, Director="Christopher Nolan", Rating="PG-13", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 7, Title="The Dark Knight", Year=2008, Director="Christopher Nolan", Rating="PG-13", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 7, Title="The Dark Knight Rises", Year=2012, Director="Christopher Nolan", Rating="PG-13", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },

                new Movie { CategoryId = 7, Title="Back to the Future", Year=1985, Director="Robert Zemeckis", Rating="PG", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 7, Title="Back to the Future Part II", Year=1989, Director="Robert Zemeckis", Rating="PG", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 7, Title="Back to the Future Part III", Year=1990, Director="Robert Zemeckis", Rating="PG", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },

                new Movie { CategoryId = 2, Title="Harry Potter and the Sorcerer's Stone", Year=2001, Director="Chris Columbus", Rating="PG", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 2, Title="Harry Potter and the Chamber of Secrets", Year=2002, Director="Chris Columbus", Rating="PG", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 2, Title="Harry Potter and the Prisoner of Azkaban", Year=2004, Director="Alfonso Cuaron", Rating="PG", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 2, Title="Harry Potter and the Goblet of Fire", Year=2005, Director="Mike Newell", Rating="PG-13", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 2, Title="Harry Potter and the Order of the Phoenix", Year=2007, Director="David Yates", Rating="PG-13", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 2, Title="Harry Potter and the Half-Blood Prince", Year=2009, Director="David Yates", Rating="PG", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },

                new Movie { CategoryId = 5, Title="Napoleon Dynamite", Year=2004, Director="Jared Hess", Rating="PG", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 5, Title="Nacho Libre", Year=2006, Director="Jared Hess", Rating="PG", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 5, Title="The Princess Bride", Year=1987, Director="Rob Reiner", Rating="PG", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 5, Title="Groundhog Day", Year=1993, Director="Harold Ramis", Rating="PG", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },

                new Movie { CategoryId = 3, Title="Arrested Development Season 1", Year=2003, Director="Various", Rating="TV-14", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 3, Title="Arrested Development Season 2", Year=2004, Director="Various", Rating="TV-14", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 3, Title="Community Season 1", Year=2009, Director="Various", Rating="TV-14", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 3, Title="Community Season 2", Year=2010, Director="Various", Rating="TV-14", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 3, Title="The Office Season 1", Year=2005, Director="Various", Rating="TV-14", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 3, Title="The Office Season 2", Year=2006, Director="Various", Rating="TV-14", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },

                new Movie { CategoryId = 4, Title="The Sixth Sense", Year=1999, Director="M. Night Shyamalan", Rating="PG-13", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },
                new Movie { CategoryId = 4, Title="A Quiet Place", Year=2018, Director="John Krasinski", Rating="PG-13", Edited=false, LentTo="", CopiedToPlex=true, Notes="" },

                new Movie { CategoryId = 1, Title="Random Documentary", Year=2015, Director="Unknown", Rating="NR", Edited=false, LentTo="", CopiedToPlex=false, Notes="Miscellaneous item" },
                new Movie { CategoryId = 8, Title="Classic VHS Recording", Year=1992, Director="Unknown", Rating="NR", Edited=false, LentTo="", CopiedToPlex=false, Notes="VHS archive" }
            };

            context.Movies.AddRange(movies);
            context.SaveChanges();
        }
    }
}