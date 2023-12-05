using RetselGames.Data.Context;
using RetselGames.Data.Repositories.Concretes;
using RetselGames.Data.Repostories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Data.UnitofWorks
{
	public class UnitofWork : IUnitofWork
	{
		private readonly AppDbContext dbContext;

		public UnitofWork(AppDbContext dbContext)
        {
			this.dbContext = dbContext;
		}
        public async ValueTask DisposeAsync()
		{
			await dbContext.SaveChangesAsync();
		}

		public int Save()
		{
			return dbContext.SaveChanges();
		}

		public async Task<int> SaveAsync()
		{
			return await dbContext.SaveChangesAsync();
		}

		IRepository<T> IUnitofWork.GetRepository<T>()
		{
			return new Repository<T>(dbContext);
		}
	}
}
