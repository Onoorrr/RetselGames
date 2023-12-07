using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RetselGames.Web.Areas.Admin.Contollers
{
	[Area("Admin")]
	[Authorize]
	public class HomeController : Controller
	{
		public  IActionResult Index()
		{
			return View();
		}
	}
}
	