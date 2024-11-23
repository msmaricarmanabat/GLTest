using GLTest.Core.Common;
using GLTest.Core.Domains.Categories;

namespace GLTest.Core.Domains.Products
{
    public interface IProductFactory
    {
        public ResultModel<Product> CreateInstance(string name);
    }
}
