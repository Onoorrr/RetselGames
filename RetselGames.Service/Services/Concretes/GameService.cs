﻿using AutoMapper;
using RetselGames.Data.UnitofWorks;
using RetselGames.Entity.DTOS.Games;
using RetselGames.Entity.Entities;
using RetselGames.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Service.Services.Concretes
{
	public class GameService : IGameService
	{
		private readonly IUnitofWork unitofWork;
		private readonly IMapper mapper;

		public GameService(IUnitofWork unitofWork, IMapper mapper)
		{
			this.unitofWork = unitofWork;
			this.mapper = mapper;
		}

		public async Task CreateGameAsync(GameAddDto gameAddDto)
		{
			var userId = Guid.Parse("9E753D47-8F3E-4CDE-B395-0260B2FE7960");
			var imageId = Guid.Parse("85DB2D8C-646C-4B7B-AED2-9CC7C079987E");

			var game = new Game(gameAddDto.Title, gameAddDto.Content, gameAddDto.CategoryId, userId, imageId);

			await unitofWork.GetRepository<Game>().AddAsync(game);
			await unitofWork.SaveAsync();
		}

		public async Task<List<GameDto>> GetAllGamesWithCategoryNonDeletedAsync()
		{
			var games = await unitofWork.GetRepository<Game>().GetAllAsync(x => !x.IsDeleted, x => x.Category);
			var map = mapper.Map<List<GameDto>>(games);
			return map;
		}
		public async Task<GameDto> GetaGameWithCategoryNonDeletedAsync(Guid gameId)
		{
			var game = await unitofWork.GetRepository<Game>().GetAsync(x => !x.IsDeleted && x.Id == gameId, x => x.Category);
			var map = mapper.Map<GameDto>(game);
			return map;
		}
		public async Task UpdateGameAsync(GameUpdateDto gameUpdateDto)
		{
			var game = await unitofWork.GetRepository<Game>().GetAsync(x => !x.IsDeleted && x.Id == gameUpdateDto.Id, x => x.Category);

			game.Title = gameUpdateDto.Title;
			game.Content = gameUpdateDto.Content;
			game.CategoryId = gameUpdateDto.CategoryId;

			await unitofWork.GetRepository<Game>().UpdateAsync(game);
			await unitofWork.SaveAsync();
		}

		public async Task SafeDeleteArticleAsync(Guid gameId)
		{
			var game = await unitofWork.GetRepository<Game>().GetByGuidAsync(gameId);

			game.IsDeleted = true;
			game.DeletedDate = DateTime.Now;

			await unitofWork.GetRepository<Game>().UpdateAsync(gameI);
			await unitofWork.SaveAsync();
		}
	}

}
