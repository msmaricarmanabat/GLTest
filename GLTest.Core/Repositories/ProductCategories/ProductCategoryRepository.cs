using GLTest.Core.Contexts;
using GLTest.Core.Domains.ProductCategories;

namespace GLTest.Core.Repositories.ProductCategories
{
    public class ProductCategoryRepository : BaseRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(AppDbContext context) : base(context) 
        {
        }
    }
}
