using AutoMapper;
using RetselGames.Data.UnitofWorks;
using RetselGames.Entity.DTOS.Categories;
using RetselGames.Entity.Entities;
using RetselGames.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Service.Services.Concretes
{
	public class CategoryService : ICategoryService
	{
		private readonly IUnitofWork unitofwork;
		private readonly IMapper mapper;

		public CategoryService(IUnitofWork unitofwork, IMapper mapper)
		{
			this.unitofwork = unitofwork;
			this.mapper = mapper;
		}
		public async Task<List<CategoryDto>> GetAllCategoriesNonDeleted()
		{
			var categories = await unitofwork.GetRepository<Category>().GetAllAsync(x => !x.IsDeleted);
			var map = mapper.Map<List<CategoryDto>>(categories);
			return map;
		}
	}		
}
