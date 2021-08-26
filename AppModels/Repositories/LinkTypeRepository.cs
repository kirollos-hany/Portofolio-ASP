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
            await dbContext.LinkTypes.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<LinkType> Delete(LinkType entity)
        {
            await Task.Run(() => dbContext.LinkTypes.Remove(entity));
            await SaveChanges();
            return entity;
        }

        public async override Task<LinkType> Edit(LinkType entity)
        {
            var lt = await dbContext.LinkTypes.FindAsync(entity.Id);
            lt = entity;
            await SaveChanges();
            return lt;
        }

        public async override Task<LinkType> FindByCondition(Expression<Func<LinkType, bool>> expression)
        {
            return await dbContext.LinkTypes.Where(expression).FirstOrDefaultAsync();
        }

        public async override Task<ICollection<LinkType>> FindCollectionByCondition(Expression<Func<LinkType, bool>> expression)
        {
            return await dbContext.LinkTypes.Where(expression).ToListAsync();
        }

        public async override Task<ICollection<LinkType>> GetAll()
        {
            return await dbContext.LinkTypes.ToListAsync();
        }

        public async override Task<LinkType> GetById(int id)
        {
            return await dbContext.LinkTypes.FindAsync(id);
        }
    }
}