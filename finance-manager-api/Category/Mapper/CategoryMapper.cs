using finance_manager_api.Category.DTOs;
using finance_manager_api.Category.Entities;

namespace finance_manager_api.Category.Mapper
{
    public static class CategoryMapper
    {
        // DTO -> Entity

        public static CategoryEntity CreateDTOToEntity(CreateCategoryDTO dto) {
            return new CategoryEntity
            {
                Description = dto.Description,
                CategoryType = dto.CategoryType
            };
        }

        public static CategoryEntity UpdateDTOToEntity(UpdateCategoryDTO dto) {
            return new CategoryEntity 
            {
                Id = dto.Id,
                Description = dto.Description,
                CategoryType = dto.CategoryType
            };
        }

        // Entity -> DTO

        public static CategoryResponseDTO EntityToResponseDTO(CategoryEntity entity) {
            return new CategoryResponseDTO
            {
                Id = entity.Id,
                Description = entity.Description,
                CategoryType = entity.CategoryType
            };
        }
        
    }
}
