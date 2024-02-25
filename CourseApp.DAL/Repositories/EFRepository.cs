using CourseApp.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseApp.DAL.Repositories
{
	public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		private readonly AppDbContext _appDbContext;
		private readonly DbSet<TEntity> _dbSet;

		public EFRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext ?? throw new ArgumentNullException(nameof(appDbContext));
			_dbSet = appDbContext.Set<TEntity>();
		}

		public void Add(TEntity entity)
		{
			_dbSet.Add(entity);
			_appDbContext.SaveChanges();
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _dbSet.ToList();
		}

		public TEntity GetById(int id)
		{
			return _dbSet.Find(id);
		}

		public void Remove(TEntity entity)
		{
			_dbSet.Remove(entity);
			_appDbContext.SaveChanges();
		}

		public void Update(TEntity entity)
		{
			_dbSet.Attach(entity);
			_appDbContext.Entry(entity).State = EntityState.Modified;
			_appDbContext.SaveChanges();
		}
	}
}
