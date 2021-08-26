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

            await dbContext.UserLinks.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<UserLink> Delete(UserLink entity)
        {
            await Task.Run(() => dbContext.UserLinks.Remove(entity));
            await SaveChanges();
            return entity;
        }

        public async override Task<UserLink> Edit(UserLink entity)
        {
            var ul = await dbContext.UserLinks.FindAsync(entity.Id);
            ul.Link = entity.Link;
            await SaveChanges();
            return entity;
        }

        public async override Task<UserLink> FindByCondition(Expression<Func<UserLink, bool>> expression)
        {
            return await dbContext.UserLinks.Include(ul => ul.Type).Include(ul => ul.User).Where(expression).FirstOrDefaultAsync();
        }

        public async override Task<ICollection<UserLink>> FindCollectionByCondition(Expression<Func<UserLink, bool>> expression)
        {
            return await dbContext.UserLinks.Include(ul => ul.Type).Include(ul => ul.User).Where(expression).ToListAsync();
        }

        public async override Task<ICollection<UserLink>> GetAll()
        {
            return await dbContext.UserLinks.Include(ul => ul.Type).Include(ul => ul.User).ToListAsync();
        }

        public async override Task<UserLink> GetById(int id)
        {
            return await dbContext.UserLinks.Include(ul => ul.Type).Include(ul => ul.User).FirstOrDefaultAsync(ul => ul.Id == id);
        }
    }
}