using BookShopWeb.Data;
using BookShopWeb.Repository.IRepository;

namespace BookShopWeb.Repository
{
    public class UnitOfWorks : IUnitOfWork
    {
        private readonly ApplicationDBContext _dbContext;
        public ICategoryRepository CategoryRepository {  get;private set; }

        public IBookRepository BookRepository { get; private set; }
        public UnitOfWorks(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
            CategoryRepository = new CategoryRepository(dBContext);
            BookRepository = new BookRepository(dBContext);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
