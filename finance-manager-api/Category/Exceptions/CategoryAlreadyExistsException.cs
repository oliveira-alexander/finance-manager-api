namespace finance_manager_api.Category.Exceptions
{
    public class CategoryAlreadyExistsException : Exception
    {
        public CategoryAlreadyExistsException(string message) : base(message) { }
    }
}
