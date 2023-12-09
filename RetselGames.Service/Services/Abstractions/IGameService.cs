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
		Task<GameDto> GetaGameWithCategoryNonDeletedAsync(Guid gameid);
		Task UpdateGameAsync(GameUpdateDto gameUpdateDto);
		Task CreateGameAsync(GameAddDto gameAddDto);
		Task SafeDeleteArticleAsync(Guid gameId);


	}
}
