using finance_manager_api.Category.DTOs;

namespace finance_manager_api.Category.Services
{
    public interface ICategoryService
    {
        Task<CategoryResponseDTO> Create(CreateCategoryDTO dto);

        Task Delete(long id);

        Task<List<CategoryResponseDTO>> Search(FilterCategoryDTO filter);

        Task<CategoryResponseDTO> Update(UpdateCategoryDTO dto);
    }
}
