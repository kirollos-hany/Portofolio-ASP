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
    public class ImageTypeRepository : BaseRepository<ImageType>
    {
        public ImageTypeRepository(PortofolioDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<ImageType> Create(ImageType entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await dbContext.ImageTypes.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ImageType> Delete(ImageType entity)
        {
            dbContext.ImageTypes.Remove(entity);
            await SaveChanges();
            return entity;
        }

        public async override Task<ICollection<ImageType>> DeleteCollection(ICollection<ImageType> entities)
        {
            dbContext.ImageTypes.RemoveRange(entities);
            await SaveChanges();
            return entities;
        }

        public async override Task<ImageType> Edit(ImageType entity)
        {
            entity.UpdatedAt = DateTime.Now;
            var imageType = await GetById(entity.Id);
            imageType = entity;
            await SaveChanges();
            return imageType;
        }

        public async override Task<ImageType> FindByCondition(Expression<Func<ImageType, bool>> expression)
        {
            return await dbContext.ImageTypes.FirstOrDefaultAsync(expression);
        }

        public async override Task<ICollection<ImageType>> FindCollectionByCondition(Expression<Func<ImageType, bool>> expression)
        {
            return await dbContext.ImageTypes.Where(expression).ToListAsync();
        }

        public async override Task<ICollection<ImageType>> GetAll()
        {
            return await dbContext.ImageTypes.ToListAsync();
        }

        public async override Task<ImageType> GetById(int id)
        {
            return await dbContext.ImageTypes.FindAsync(id);
        }
    }
}