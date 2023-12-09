using AutoMapper;
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
		private readonly IMapper mapper;

		public GameController(IGameService gameService, ICategoryService categoryService, IMapper mapper)
        {
			this.gameService = gameService;
			this.categoryService = categoryService;
			this.mapper = mapper;
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
		[HttpGet]
		public async Task<IActionResult> Update(Guid gameId)
		{
			var game = await gameService.GetaGameWithCategoryNonDeletedAsync(gameId);
			var categories = await categoryService.GetAllCategoriesNonDeleted();
			var gameUpdateDto = mapper.Map<GameUpdateDto>(game);		
			gameUpdateDto.Categories = categories;	
			return View(gameUpdateDto);
		}
		[HttpPost]
		public async Task<IActionResult> Update(GameUpdateDto gameUpdateDto)
		{
			await gameService.UpdateGameAsync(gameUpdateDto);
			var categories = await categoryService.GetAllCategoriesNonDeleted();
			gameUpdateDto.Categories = categories;
			return View(gameUpdateDto);
		}

		public async Task<IActionResult> Delete(Guid gameId)
		{
			await gameService.SafeDeleteArticleAsync(gameId);
			
		return	RedirectToAction("Index", "Game", new { Area = "Admin" });
		}
	}
}
