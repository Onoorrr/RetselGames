using AutoMapper;
using RetselGames.Data.UnitofWorks;
using RetselGames.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Service.Services.Concretes
{
	public class CategoryService : ICategoryServices
	{
		private readonly IUnitofWork unitofwork;
		private readonly IMapper mapper;

		public CategoryService(IUnitofWork unitofwork, IMapper mapper)
		{
			this.unitofwork = unitofwork;
			this.mapper = mapper;
		}	
	}
}
