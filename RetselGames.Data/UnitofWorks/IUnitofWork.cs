using RetselGames.Core.Entities;
using RetselGames.Data.Repostories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Data.UnitofWorks
{
	public interface IUnitofWork : IAsyncDisposable
	{
		IRepository<T> GetRepository<T>() where T : class, IEntitiyBase, new();

		Task<int> SaveAsync();
		int Save();
	}
}
