using Microsoft.AspNetCore.Mvc;

namespace RetselGames.Web.Areas.Admin.Contollers
{
	[Area("Admin")]
	public class HomeController : Controller
	{
		public  IActionResult Index()
		{
			return View();
		}
	}
}
	