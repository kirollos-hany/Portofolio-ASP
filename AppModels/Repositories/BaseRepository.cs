using Portofolio.Database;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Portofolio.AppModels.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly PortofolioDbContext dbContext;
        public BaseRepository(PortofolioDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public abstract Task<T> Create(T entity);

        public abstract Task<T> Delete(T entity);

        public abstract Task<T> Edit(T entity);

        public abstract Task<T> FindByCondition(Expression<Func<T, bool>> expression);

        public abstract Task<List<T>> FindCollectionByCondition(Expression<Func<T, bool>> expression);

        public abstract Task<List<T>> GetAll();

        public abstract Task<T> GetById(int id);

        protected async Task<int> SaveChanges()
        {
            return await Task.Run(() => dbContext.SaveChanges());
        }
    }
}