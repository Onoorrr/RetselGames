using AutoMapper;
using RetselGames.Entity.DTOS.Categories;
using RetselGames.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Service.AutoMapper.Categories
{
	public class CategoryProfile : Profile
	{
		public CategoryProfile()
		{
			CreateMap<CategoryDto,Category>().ReverseMap();
		}
	}
}
