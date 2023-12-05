using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RetselGames.Data.Repositories.Concretes;
using RetselGames.Data.Repostories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Data.Extensions
{
	public static class DataLayerExtensions
	{

		public static IServiceCollection LoadDataLayerExtensions(this IServiceCollection services, IConfiguration config)
		{
			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
				return services;
		}

	}
}
