using Microsoft.Extensions.DependencyInjection;
using RetselGames.Service.Services.Abstractions;
using RetselGames.Service.Services.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Service.Extensions
{
	public static class ServiceLayerExtensions
	{
		public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
		{
			services.AddScoped<IGameService, GameService>();
			services.AddScoped<ICategoryService, CategoryService>();
			var assembly = Assembly.GetExecutingAssembly();

			services.AddAutoMapper(assembly);
			return services;
		}
	}
}
