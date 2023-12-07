using AutoMapper;
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

		public async Task<List<GameDto>> GetAllGamesWithCategoryNonDeletedAsync()
		{
			var games = await unitofWork.GetRepository<Game>().GetAllAsync(x => !x.IsDeleted, x => x.Category);
			var map = mapper.Map<List<GameDto>>(games);
			return map;	
		}
	}	
}
