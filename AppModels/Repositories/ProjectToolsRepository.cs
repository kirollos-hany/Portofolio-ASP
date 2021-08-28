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
    public class ProjectToolsRepository : BaseRepository<ProjectTool>
    {
        public ProjectToolsRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<ProjectTool> Create(ProjectTool entity)
        {
            entity.CreatedAt = DateTime.Now;
             entity.UpdatedAt = DateTime.Now;
            await dbContext.ProjectTools.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ProjectTool> Delete(ProjectTool entity)
        {
            dbContext.ProjectTools.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ProjectTool> Edit(ProjectTool entity)
        {
            var tool = await dbContext.ProjectTools.FindAsync(entity.Id);
            tool.ToolUsed = entity.ToolUsed;
            tool.UpdatedAt = DateTime.Now;
            await SaveChanges();
            return entity;
        }

        public async override Task<ProjectTool> FindByCondition(Expression<Func<ProjectTool, bool>> expression)
        {
            return await dbContext.ProjectTools.FirstOrDefaultAsync(expression);
        }

        public async override Task<ICollection<ProjectTool>> FindCollectionByCondition(Expression<Func<ProjectTool, bool>> expression)
        {
            return await dbContext.ProjectTools.Where(expression).ToListAsync();
        }

        public async override Task<ICollection<ProjectTool>> GetAll()
        {
            return await dbContext.ProjectTools.ToListAsync();
        }

        public async override Task<ProjectTool> GetById(int id)
        {
            return await dbContext.ProjectTools.FindAsync(id);
        }
    }
}