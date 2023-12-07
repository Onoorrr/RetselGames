using Microsoft.AspNetCore.Mvc;
using RetselGames.Service.Services.Abstractions;
using System.Threading.Tasks; 

namespace RetselGames.Web.Areas.Admin.Controllers	
{
	[Area("Admin")]
	public class GameController : Controller
    {
		private readonly IGameService gameService;

		public GameController(IGameService gameService)
        {
			this.gameService = gameService;
		}
        public async Task<IActionResult> Index()
        {
			var games = await gameService.GetAllGamesWithCategoryNonDeletedAsync();

			return View(games);
        }
    }
}
