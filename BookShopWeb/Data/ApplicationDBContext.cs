using Microsoft.EntityFrameworkCore;

namespace BookShopWeb.Data
{
	public class ApplicationDBContext : DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> option):base(option)
		{ 

		}
	}
}
