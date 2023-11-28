using BookShopWeb.Data;
using BookShopWeb.Models;
using BookShopWeb.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookShopWeb.Controllers
{
	public class CategoryController : Controller
	{
		//private readonly ApplicationDBContext _dbContext
		private readonly ICategoryRepository categoryRepository;
		public CategoryController(ICategoryRepository category)
		{
			categoryRepository = category;
		}
		public IActionResult Index()
		{
			List<Category> categories = categoryRepository.GetAll().ToList();
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
			if (category.Name == category.Description)
			{
				ModelState.AddModelError("Name", "Name can not be equal to Description");
			}

			if (ModelState.IsValid)
			{
                categoryRepository.Add(category);
				categoryRepository.Save();
                TempData["success"] = "Category created succesfully";
                return RedirectToAction("Index");
            }
			
			return View();

		}
		public IActionResult Edit(int? idb)
		{
			if (idb==null || idb == 0)
			{
				return NotFound();
			}	
			Category? category = categoryRepository.Get(c => c.Id == idb);
			
			if(category == null)
			{
				return NotFound();
			}
			return View(category);
		}
		[HttpPost]
		public IActionResult Edit(Category category) 
		{
			if (ModelState.IsValid)
			{
				categoryRepository.Update(category);
				categoryRepository.Save();
				TempData["success"] = "Category updated succesfully";
				return RedirectToAction("Index");
			}

			return View();
		}
		public IActionResult Delete(int? idb)
		{
			if (idb == null || idb == 0)
            {
                return NotFound();
            }
			Category? category = categoryRepository.Get(c => c.Id == idb); 
			if (category == null)
			{
				return NotFound();
			}
			return View(category);
		}
		[HttpPost]
		public IActionResult Delete(Category category)
		{
				categoryRepository.Remove(category);
				categoryRepository.Save();
				TempData["success"] = "Category deleted succesfully";
				return RedirectToAction("Index");
		}
	}
}
