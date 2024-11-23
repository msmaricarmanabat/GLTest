using GLTest.Core.Contexts;
using GLTest.Core.Domains.Products;

namespace GLTest.Core.Repositories.Products
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
