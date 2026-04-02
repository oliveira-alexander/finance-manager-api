using finance_manager_api.Category.DTOs;
using finance_manager_api.Category.Entities;
using finance_manager_api.Category.Exceptions;
using finance_manager_api.Category.Mapper;
using finance_manager_api.Category.Repositories;

namespace finance_manager_api.Category.Services
{
    public class CategoryService : ICategoryService
    {
        public ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository) {
            this._repository = repository;
        }

        public async Task<CategoryResponseDTO> Create(CreateCategoryDTO dto)
        {
            CategoryEntity category = CategoryMapper.CreateDTOToEntity(dto);

            if (await _repository.CategoryExists(category))
                throw new CategoryAlreadyExistsException("A categoria já existe!");

            return CategoryMapper.EntityToResponseDTO(await _repository.Create(category));
        }

        public async Task Delete(long id)
        {
            CategoryEntity? category = await _repository.FindById(id);

            if (category == null)
                throw new CategoryNotFoundException("A categoria não existe!");

            await _repository.Delete(category);
        }

        public async Task<List<CategoryResponseDTO>> Search(FilterCategoryDTO filter)
        {
            var query = await _repository.Search(filter);

            return query.Select(c => CategoryMapper.EntityToResponseDTO(c)).ToList();
        }

        public async Task<CategoryResponseDTO> Update(UpdateCategoryDTO dto)
        {
            var entity = CategoryMapper.UpdateDTOToEntity(dto);

            if (await _repository.CategoryExists(entity))
                throw new CategoryNotFoundException("A categoria não existe!");

            return CategoryMapper.EntityToResponseDTO(await _repository.Update(entity));
        }
    }
}
