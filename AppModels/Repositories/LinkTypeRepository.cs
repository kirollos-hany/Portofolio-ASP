using System.Threading.Tasks;
using System.Collections.Generic;
using Portofolio.Models;
using Portofolio.Database;
using System.Linq.Expressions;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace Portofolio.AppModels.Repositories
{
    public class LinkTypesRepository : BaseRepository<LinkType>
    {
        public LinkTypesRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<LinkType> Create(LinkType entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _dbContext.LinkTypes.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<LinkType> Delete(LinkType entity)
        {
            _dbContext.LinkTypes.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ICollection<LinkType>> DeleteCollection(ICollection<LinkType> entities)
        {
            _dbContext.LinkTypes.RemoveRange(entities);
            await SaveChanges();
            return entities;
        }

        public async override Task<LinkType> Edit(LinkType entity)
        {
            var lt = await _dbContext.LinkTypes.FindAsync(entity.Id);
            lt = entity;
            lt.UpdatedAt = DateTime.Now;
            await SaveChanges();
            return lt;
        }

        public async override Task<LinkType> FindByCondition(Expression<Func<LinkType, bool>> expression)
        {
            return await _dbContext.LinkTypes.Where(expression).FirstOrDefaultAsync();
        }

        public async override Task<ICollection<LinkType>> FindCollectionByCondition(Expression<Func<LinkType, bool>> expression)
        {
            return await Task.Run(()=>_dbContext.LinkTypes.Where(expression).ToHashSet());
        }

        public async override Task<ICollection<LinkType>> GetAll()
        {
            return await Task.Run(()=>_dbContext.LinkTypes.ToHashSet());
        }

        public async override Task<LinkType> GetById(int id)
        {
            return await _dbContext.LinkTypes.FindAsync(id);
        }
    }
}