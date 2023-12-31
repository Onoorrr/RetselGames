﻿using Microsoft.EntityFrameworkCore;
using RetselGames.Core.Entities;
using RetselGames.Data.Context;
using RetselGames.Data.Repostories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Data.Repositories.Concretes
{
	public class Repository<T> : IRepository<T> where T : class, IEntitiyBase, new()
	{
		private readonly AppDbContext dbContext;
		public Repository(AppDbContext dbContext)
		{
			this.dbContext = dbContext;
		}
		private DbSet<T> Table { get => dbContext.Set<T>(); }

		public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null , params Expression<Func<T, object>>[] incluedeProperties)
		{
			IQueryable<T> query = Table;
			if(predicate != null)
				query = query.Where(predicate);

			if (incluedeProperties.Any())
				foreach (var item in incluedeProperties)
					query = query.Include(item);

			return await query.ToListAsync();	
		}

		public async Task AddAsync(T entity)
		{
			await Table.AddAsync(entity);
		}

		public async Task<T> GetAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] incluedeProperties)
		{
			IQueryable<T> query = Table;
			query = query.Where(predicate);
			
			if(incluedeProperties.Any())
				foreach (var item in incluedeProperties)
					query = query.Include(item);
			return await query.SingleAsync();
		}

		public async Task<T> GetByGuidAsync(Guid id)
		{
			return await Table.FindAsync(id);
		}

		public async Task<T> UpdateAsync(T entity)
		{
			await Task.Run(() => Table.Update(entity));
				return entity;
		}

		public async Task DeleteAsync(T entity)
		{
			await Task.Run(() => Table.Remove(entity));
		}

		public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
		{
			return await Table.AnyAsync(predicate);
		}

		public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
		{
			return await Table.CountAsync(predicate);
		}
	}
}
