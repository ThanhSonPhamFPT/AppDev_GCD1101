using BookShopWeb.Data;
using BookShopWeb.Models;
using BookShopWeb.Repository;
using BookShopWeb.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BookShopWeb.Controllers
{
    public class BookController : Controller
    {
        //private readonly ApplicationDBContext _dbContext;
        private readonly IUnitOfWork _unitOfWork;
        public BookController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Book> books = _unitOfWork.BookRepository.GetAll().ToList();
            return View(books);
        }
		public IActionResult CreateUpdate(int? id)
		{
			Book book = new Book();
			if (id == null ||id==0)
			{
				//Create new Book
                return View(book);
            }
			else
			{
				//Update a Book
				book = _unitOfWork.BookRepository.Get(book=>book.Id == id);
				return View(book);
			}
			
		}
		[HttpPost]

		public IActionResult CreateUpdate(Book book)
		{
			
			if (ModelState.IsValid)
			{
                if (book.Id == 0)
                {
                    _unitOfWork.BookRepository.Add(book);
                    TempData["success"] = "Book created succesfully";
                }
                else
                {
                    _unitOfWork.BookRepository.Update(book);
                    TempData["success"] = "Book updated succesfully";
                }
                _unitOfWork.Save();
                return RedirectToAction("Index");
			}

			return View();

		}
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Book? book = _unitOfWork.BookRepository.Get(book => book.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost]
        public IActionResult Delete(Book book)
        {
            _unitOfWork.BookRepository.Remove(book);
            _unitOfWork.Save();
            TempData["success"] = "Book deleted succesfully";
            return RedirectToAction("Index");
        }

    }
}
