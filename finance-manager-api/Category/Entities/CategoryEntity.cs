using finance_manager_api.Category.Enums;

namespace finance_manager_api.Category.Entities
{
    public class CategoryEntity
    {
        public long Id { get; set; }
        public string Description { get; set; } = "";
        public CategoryType CategoryType { get; set; }
    }
}
