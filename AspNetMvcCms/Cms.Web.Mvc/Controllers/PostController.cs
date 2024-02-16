using Cms.Data.DataContext;
using Cms.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cms.Web.Mvc.Controllers
{
	public class PostController : Controller
	{
		private readonly AppDbContext _context;

        public PostController(AppDbContext appDbContext)
        {
			_context = appDbContext;   
        }
        public IActionResult Search(string query, int page)
		{
			return View();
		}

		public IActionResult Detail(int id)
		{
			return View();
		}

		public IActionResult Index()
		{
			List<Post> post = _context.Posts.ToList();
			return View(post);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Post model)
		{
			return View();
		}
		public IActionResult Update(int id)
		{
			return View();
		}
		[HttpPost]
		public IActionResult Update(Post model)
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
