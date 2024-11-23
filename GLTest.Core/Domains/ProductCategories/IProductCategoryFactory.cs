using GLTest.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLTest.Core.Domains.ProductCategories
{
    public interface IProductCategoryFactory
    {
        public ResultModel<ProductCategory> CreateInstance(Guid productId, Guid categoryId);
    }
}
