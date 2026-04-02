using finance_manager_api.Category.DTOs;
using finance_manager_api.Category.Entities;
using finance_manager_api.Data;

namespace finance_manager_api.Category.Repositories
{
    public interface ICategoryRepository
    {
        Task<CategoryEntity> Create(CategoryEntity entity);

        Task<bool> CategoryExists(CategoryEntity entity);

        Task<bool> Delete(CategoryEntity entity);

        Task<CategoryEntity?> FindById(long id);

        Task<List<CategoryEntity>> Search(FilterCategoryDTO filter);

        Task<CategoryEntity> Update(CategoryEntity entity);
    }
}
