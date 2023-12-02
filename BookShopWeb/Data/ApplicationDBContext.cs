using BookShopWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShopWeb.Data
{
	public class ApplicationDBContext : IdentityDbContext
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<Book> Books { get; set; }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> option):base(option)
		{ 

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "Romansss", Description = "A lot of roman stories", DisplayOrder = 2 },
				new Category { Id = 2, Name = "Action", Description = "Show you how is an action", DisplayOrder = 1 },
				new Category { Id = 3, Name = "Horror", Description = "So scary", DisplayOrder = 3},
				new Category { Id = 4, Name = "Science", Description = "For anyone who loves science", DisplayOrder = 4 },
				new Category { Id = 5, Name = "History", Description = "You can know alot about the world", DisplayOrder = 5 }
				);
			modelBuilder.Entity<Book>().HasData(
				new Book
				{
					Id = 1,
					Title="Programming",
					Description="Basic start",
					Author="Microsoft",
					Price=10,
					CategoryId=1
				},
                new Book
                {
                    Id = 2,
                    Title = "Advanced Programming",
                    Description = "Enhancing",
                    Author = "BTEC",
                    Price = 14,
                    CategoryId = 2
                },
                new Book
                {
                    Id = 3,
                    Title = "Data Structures",
                    Description = "Not easy",
                    Author = "Greenwich",
                    Price = 15,
                    CategoryId = 3
                },
                new Book
                {
                    Id = 4,
                    Title = "App Dev",
                    Description = "Full Application",
                    Author = "Microsoft",
                    Price = 20,
                    CategoryId = 4
                }

                ) ;
		}
	}
}
