using BookShopWeb.Models;

namespace BookShopWeb.Repository.IRepository
{
    public interface IBookRepository:IRepository<Book>
    {
        void Update(Book book);
    }
}
