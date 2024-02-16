using Cms.Data.DataContext;
using Cms.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Controllers
{
	public class CategoryController : Controller
	{
		private readonly AppDbContext _context;

		public CategoryController(AppDbContext appDbContext)
		{
			_context = appDbContext;
		}
		public IActionResult Index(int id, int page)
		{
			List<Category> categori = _context.Categories.ToList();
			return View(categori);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Category model)
		{
			return View();
		}
		public IActionResult Update(int id)
		{
			return View();
		}
		[HttpPost]
		public IActionResult Update(Category model)
		{
			return View();
		}
		public IActionResult Delete(int id)
		{
			return View();
		}
		[HttpPost]
		public IActionResult DeletePOST(int id)
		{
			return View();
		}
	}
}
