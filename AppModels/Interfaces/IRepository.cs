using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
namespace Portofolio.AppModels.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<ICollection<T>> GetAll();

        Task<T> GetById(int id);

        Task<T> Create(T entity);

        Task<T> Edit(T entity);

        Task<T> Delete(T entity);

        Task<ICollection<T>> DeleteCollection(ICollection<T> entities);

        Task<ICollection<T>> FindCollectionByCondition(Expression<Func<T, bool>> expression);

        Task<T> FindByCondition(Expression<Func<T, bool>> expression);
    }
}