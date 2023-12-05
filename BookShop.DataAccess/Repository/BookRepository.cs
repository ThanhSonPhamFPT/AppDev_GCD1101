using BookShopWeb.Data;
using BookShopWeb.Models;
using BookShopWeb.Repository.IRepository;

namespace BookShopWeb.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {   
        private readonly ApplicationDBContext _dbContext;
        public BookRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update(Book book)
        {
            _dbContext.Update(book);
        }
    }
}
