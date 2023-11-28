using BookShopWeb.Models;

namespace BookShopWeb.Repository.IRepository
{
    public interface ICategoryRepository:IRepository<Category>
    {
        void Update(Category category);
    }
}
