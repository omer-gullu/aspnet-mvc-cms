using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Controllers
{
	public class PostController : Controller
	{
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
			return View();
		}


	}
}
