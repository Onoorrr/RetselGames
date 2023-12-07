using AutoMapper;
using RetselGames.Entity.DTOS.Games;
using RetselGames.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Service.AutoMapper.Games
{
	public class GameProfile : Profile
	{
		public GameProfile()
		{
			CreateMap<GameDto, Game>().ReverseMap();
		}
	}
}
