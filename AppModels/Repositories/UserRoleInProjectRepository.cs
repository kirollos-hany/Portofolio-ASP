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
    public class UserRoleInProjectRepository : BaseRepository<UserRoleInProject>
    {
        public UserRoleInProjectRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<UserRoleInProject> Create(UserRoleInProject entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _dbContext.UserProjectRoles.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<UserRoleInProject> Delete(UserRoleInProject entity)
        {
            _dbContext.UserProjectRoles.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ICollection<UserRoleInProject>> DeleteCollection(ICollection<UserRoleInProject> entities)
        {
            _dbContext.UserProjectRoles.RemoveRange(entities);
            await SaveChanges();
            return entities;
        }

        public async override Task<UserRoleInProject> Edit(UserRoleInProject entity)
        {
            entity.UpdatedAt = DateTime.Now;
            var urip = await _dbContext.UserProjectRoles.FindAsync(entity.Id);
            urip = entity;
            await SaveChanges();
            return urip;
        }

        public async override Task<UserRoleInProject> FindByCondition(Expression<Func<UserRoleInProject, bool>> expression)
        {
            return await _dbContext.UserProjectRoles.Where(expression).FirstOrDefaultAsync();
        }

        public async override Task<ICollection<UserRoleInProject>> FindCollectionByCondition(Expression<Func<UserRoleInProject, bool>> expression)
        {
            return await  _dbContext.UserProjectRoles.Where(expression).ToListAsync();
        }

        public async override Task<ICollection<UserRoleInProject>> GetAll()
        {
            return await _dbContext.UserProjectRoles.ToListAsync();
        }

        public async override Task<UserRoleInProject> GetById(int id)
        {
            return await _dbContext.UserProjectRoles.FindAsync(id);
        }
    }
}