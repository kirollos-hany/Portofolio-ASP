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
    public class UIPRepository : BaseRepository<UsersInProject>
    {
        public UIPRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<UsersInProject> Create(UsersInProject entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _dbContext.UsersInProjects.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<UsersInProject> Delete(UsersInProject entity)
        {
            _dbContext.UsersInProjects.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ICollection<UsersInProject>> DeleteCollection(ICollection<UsersInProject> entities)
        {
            _dbContext.UsersInProjects.RemoveRange(entities);
            await SaveChanges();
            return entities;
        }

        public async override Task<UsersInProject> Edit(UsersInProject entity)
        {
            var uip = await _dbContext.UsersInProjects.FindAsync(entity.Id);
            uip.UpdatedAt = DateTime.Now;
            uip.UserId = entity.UserId;
            uip.RoleId = entity.RoleId;
            await SaveChanges();
            return uip;
        }

        public async override Task<UsersInProject> FindByCondition(Expression<Func<UsersInProject, bool>> expression)
        {
            return await _dbContext.UsersInProjects.Include(uip => uip.Role).Include(uip => uip.Project)
            .Include(uip => uip.User)
            .Where(expression).FirstOrDefaultAsync();
        }

        public async override Task<ICollection<UsersInProject>> FindCollectionByCondition(Expression<Func<UsersInProject, bool>> expression)
        {
            return await Task.Run(()=>_dbContext.UsersInProjects.Include(uip => uip.Role).Include(uip => uip.Project)
            .Include(uip => uip.User)
            .Where(expression).ToHashSet());
        }

        public async override Task<ICollection<UsersInProject>> GetAll()
        {
            return await Task.Run(()=>_dbContext.UsersInProjects.Include(uip => uip.Role).Include(uip => uip.Project).Include(uip => uip.User).ToHashSet());
        }

        public async override Task<UsersInProject> GetById(int id)
        {
            return await _dbContext.UsersInProjects.Include(uip => uip.Role).Include(uip => uip.Project).Include(uip => uip.User).FirstOrDefaultAsync();
        }
    }
}