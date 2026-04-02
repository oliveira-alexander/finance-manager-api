namespace finance_manager_api.Category.Exceptions
{
    public class CategoryNotFoundException : Exception
    {
        public CategoryNotFoundException(string message): base(message) { }
    }
}
