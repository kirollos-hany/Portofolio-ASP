using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Portofolio.Database;
using Portofolio.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Portofolio.AppModels.Repositories
{
    public class UserLinksRepository : BaseRepository<UserLink>
    {
        public UserLinksRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<UserLink> Create(UserLink entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _dbContext.UserLinks.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<UserLink> Delete(UserLink entity)
        {
            _dbContext.UserLinks.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ICollection<UserLink>> DeleteCollection(ICollection<UserLink> entities)
        {
            _dbContext.UserLinks.RemoveRange(entities);
            await SaveChanges();
            return entities;
        }

        public async override Task<UserLink> Edit(UserLink entity)
        {
            var ul = await _dbContext.UserLinks.FindAsync(entity.Id);
            ul.Link = entity.Link;
            ul.UpdatedAt = DateTime.Now;
            await SaveChanges();
            return entity;
        }

        public async override Task<UserLink> FindByCondition(Expression<Func<UserLink, bool>> expression)
        {
            return await _dbContext.UserLinks.Include(ul => ul.Type).Include(ul => ul.User).Where(expression).FirstOrDefaultAsync();
        }

        public async override Task<ICollection<UserLink>> FindCollectionByCondition(Expression<Func<UserLink, bool>> expression)
        {
            return await _dbContext.UserLinks.Include(ul => ul.Type).Include(ul => ul.User).Where(expression).ToListAsync();
        }

        public async override Task<ICollection<UserLink>> GetAll()
        {
            return await _dbContext.UserLinks.Include(ul => ul.Type).Include(ul => ul.User).ToListAsync();
        }

        public async override Task<UserLink> GetById(int id)
        {
            return await _dbContext.UserLinks.Include(ul => ul.Type).Include(ul => ul.User).FirstOrDefaultAsync(ul => ul.Id == id);
        }
    }
}