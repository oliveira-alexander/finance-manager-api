using finance_manager_api.Category.Enums;

namespace finance_manager_api.Category.DTOs
{
    public class CreateCategoryDTO
    {
        public string Description { get; set; } = "";
        public CategoryType CategoryType { get; set; }
    }
}
