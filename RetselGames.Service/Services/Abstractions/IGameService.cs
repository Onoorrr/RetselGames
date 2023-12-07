using RetselGames.Entity.DTOS.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Service.Services.Abstractions
{
	public interface IGameService
	{		
		Task<List<GameDto>> GetAllGamesWithCategoryNonDeletedAsync();
	}
}
