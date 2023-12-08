using RetselGames.Entity.DTOS.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Service.Services.Abstractions
{
	public interface ICategoryService
	{
		public Task<List<CategoryDto>> GetAllCategoriesNonDeleted();
	}
}
