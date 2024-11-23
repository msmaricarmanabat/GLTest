using GLTest.Core.Common;

namespace GLTest.Core.Domains.Categories
{
    public class CategoryFactory : Category, ICategoryFactory
    {
        public ResultModel<Category> CreateInstance(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return new ResultModel<Category>(false, "Name is required");

            var result = Create(name);
            return new ResultModel<Category>(result);
        }
    }
}
