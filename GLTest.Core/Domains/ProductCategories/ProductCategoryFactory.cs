using GLTest.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLTest.Core.Domains.ProductCategories
{
    public class ProductCategoryFactory : ProductCategory, IProductCategoryFactory
    {
        public ResultModel<ProductCategory> CreateInstance(Guid productId, Guid categoryId)
        {
            if (productId == Guid.Empty)
                return new ResultModel<ProductCategory>(false, "Invalid Product ID: A valid GUID is required.");
            if (categoryId == Guid.Empty)
                return new ResultModel<ProductCategory>(false, "Invalid Category ID: A valid GUID is required.");

            try
            {
                var result = Create(productId, categoryId);
                return new ResultModel<ProductCategory>(result);
            }
            catch (Exception ex)
            {
                return new ResultModel<ProductCategory>(false, $"An error occurred: {ex.Message}");
            }
        }
    }
}
