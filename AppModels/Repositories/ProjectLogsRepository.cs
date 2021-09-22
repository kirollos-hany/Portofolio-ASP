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
    public class ProjectLogsRepository : BaseRepository<ProjectLog>
    {
        public ProjectLogsRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<ProjectLog> Create(ProjectLog entity)
        {
            entity.CreatedAt = DateTime.Now;
            await _dbContext.ProjectLogs.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public override Task<ProjectLog> Delete(ProjectLog entity)
        {
            throw new NotImplementedException();
        }

        public override Task<ICollection<ProjectLog>> DeleteCollection(ICollection<ProjectLog> entities)
        {
            throw new NotImplementedException();
        }

        public override Task<ProjectLog> Edit(ProjectLog entity)
        {
            throw new NotImplementedException();
        }

        public async override Task<ProjectLog> FindByCondition(Expression<Func<ProjectLog, bool>> expression)
        {
           return await _dbContext.ProjectLogs.FirstOrDefaultAsync(expression);
        }

        public async override Task<ICollection<ProjectLog>> FindCollectionByCondition(Expression<Func<ProjectLog, bool>> expression)
        {
            return await _dbContext.ProjectLogs.Where(expression).ToListAsync();
        }

        public async override Task<ICollection<ProjectLog>> GetAll()
        {
            return await _dbContext.ProjectLogs.ToListAsync();
        }

        public async override Task<ProjectLog> GetById(int id)
        {
            return await _dbContext.ProjectLogs.FindAsync(id);
        }
    }
}