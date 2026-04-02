using finance_manager_api.Category.Enums;

namespace finance_manager_api.Category.DTOs
{
    public class FilterCategoryDTO
    {
        public long? Id { get; set; }
        public string? Description { get; set; }
        public CategoryType? CategoryType { get; set; }
    }
}
