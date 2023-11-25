using BookShopWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShopWeb.Data
{
	public class ApplicationDBContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> option):base(option)
		{ 

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "Romansss", Description = "A lot of roman stories", DisplayOrder = 2 },
				new Category { Id = 2, Name = "Action", Description = "Show you how is an action", DisplayOrder = 1 },
				new Category { Id = 3, Name = "Horror", Description = "So scary", DisplayOrder = 3},
				new Category { Id = 4, Name = "Science", Description = "For anyone who loves science", DisplayOrder = 4 },
				new Category { Id = 5, Name = "History", Description = "You can know alot about the world", DisplayOrder = 5 }
				);
		}
	}
}
