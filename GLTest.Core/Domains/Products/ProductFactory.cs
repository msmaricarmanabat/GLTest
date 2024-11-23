using GLTest.Core.Common;

namespace GLTest.Core.Domains.Products
{
    public class ProductFactory : Product, IProductFactory
    {
        public ResultModel<Product> CreateInstance(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return new ResultModel<Product>(false, "Name is required");

            var result = Create(name);
            return new ResultModel<Product>(result);
        }
    }
}
