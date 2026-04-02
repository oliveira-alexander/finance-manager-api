using finance_manager_api.Category.DTOs;
using finance_manager_api.Category.Entities;
using finance_manager_api.Data;
using Microsoft.EntityFrameworkCore;

namespace finance_manager_api.Category.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private AppDBContext _context;

        public CategoryRepository(AppDBContext context) {
            this._context = context;
        }

        public async Task<bool> CategoryExists(CategoryEntity entity)
        {
            return await _context.Categories.AnyAsync(c => c.Description == entity.Description &&
                                                 c.CategoryType == entity.CategoryType);
        }

        public async Task<CategoryEntity> Create(CategoryEntity entity)
        {
            await _context.Categories.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> Delete(CategoryEntity entity)
        {
            _context.Categories.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<CategoryEntity?> FindById(long id)
        {
            return await _context.Categories.SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<CategoryEntity>> Search(FilterCategoryDTO filter)
        {
            var query = _context.Categories.AsQueryable();

            if (filter.Id.HasValue || filter.Id > 0)
                query = query.Where(c => c.Id == filter.Id);

            if (!string.IsNullOrEmpty(filter.Description))
                query = query.Where(c => c.Description.Contains(filter.Description));

            if (filter.CategoryType.HasValue)
                query = query.Where(c => c.CategoryType == filter.CategoryType);

            return await query.ToListAsync();
        }

        public async Task<CategoryEntity> Update(CategoryEntity entity)
        {
            var updatingEntity = await _context.Categories.SingleOrDefaultAsync(c => c.Id == entity.Id);

            updatingEntity.Description = entity.Description;
            updatingEntity.CategoryType = entity.CategoryType;

            await _context.SaveChangesAsync();

            return updatingEntity;
        }
    }
}
