using Microsoft.AspNetCore.Mvc;
using RetselGames.Entity.DTOS.Games;
using RetselGames.Service.Services.Abstractions;

namespace RetselGames.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
	public class GameController : Controller
    {
		private readonly IGameService gameService;
		private readonly ICategoryService categoryService;

		public GameController(IGameService gameService, ICategoryService categoryService)
        {
			this.gameService = gameService;
			this.categoryService = categoryService;
		}
        public async Task<IActionResult> Index()
        {
			var games = await gameService.GetAllGamesWithCategoryNonDeletedAsync();

			return View(games);
        }
		[HttpGet]
		public async Task<IActionResult> Add()
		{
			var categories = await categoryService.GetAllCategoriesNonDeleted();
			return View(new GameAddDto { Categories = categories });
		}
		[HttpPost]
		public async Task<IActionResult> Add(GameAddDto gameAddDto)
		{
			await gameService.CreateGameAsync(gameAddDto);
			RedirectToAction("Index", "Game", new { Area = "Admin" });

			var categories = await categoryService.GetAllCategoriesNonDeleted();
			return View(new GameAddDto { Categories = categories });
		}
	}
}
