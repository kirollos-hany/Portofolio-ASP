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
    public class ProjectFeedbacksRepository : BaseRepository<ProjectFeedback>
    {
        public ProjectFeedbacksRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<ProjectFeedback> Create(ProjectFeedback entity)
        {
            entity.CreatedAt = DateTime.Now;
            await dbContext.ProjectFeedbacks.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ProjectFeedback> Delete(ProjectFeedback entity)
        {
            dbContext.ProjectFeedbacks.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ICollection<ProjectFeedback>> DeleteCollection(ICollection<ProjectFeedback> entities)
        {
            dbContext.ProjectFeedbacks.RemoveRange(entities);
            await SaveChanges();
            return entities;
        }

        public override Task<ProjectFeedback> Edit(ProjectFeedback entity)
        {
            throw new NotImplementedException();
        }

        public async override Task<ProjectFeedback> FindByCondition(Expression<Func<ProjectFeedback, bool>> expression)
        {
            return await dbContext.ProjectFeedbacks.Where(expression).FirstOrDefaultAsync();
        }

        public async override Task<ICollection<ProjectFeedback>> FindCollectionByCondition(Expression<Func<ProjectFeedback, bool>> expression)
        {
            return await dbContext.ProjectFeedbacks.Where(expression).ToListAsync();
        }

        public async override Task<ICollection<ProjectFeedback>> GetAll()
        {
            return await dbContext.ProjectFeedbacks.ToListAsync();
        }

        public async override Task<ProjectFeedback> GetById(int id)
        {
            return await dbContext.ProjectFeedbacks.FindAsync(id);
        }
    }
}