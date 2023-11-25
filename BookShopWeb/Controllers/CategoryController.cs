using BookShopWeb.Data;
using BookShopWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShopWeb.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ApplicationDBContext _dbContext;
		public CategoryController(ApplicationDBContext applicationDBContext)
		{
			_dbContext = applicationDBContext;
		}
		public IActionResult Index()
		{
			List<Category> categories = _dbContext.Categories.ToList();
			return View(categories);
		}

		public IActionResult Details()
		{
			return View();
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]

		public IActionResult Create(Category category)
		{
			_dbContext.Categories.Add(category);
			_dbContext.SaveChanges();
			TempData["success"] = "Category created succesfully";
			return RedirectToAction("Index");

		}
	}
}
