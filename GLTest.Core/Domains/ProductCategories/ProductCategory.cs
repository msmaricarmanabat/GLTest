using GLTest.Core.Domains.Categories;
using GLTest.Core.Domains.Products;

namespace GLTest.Core.Domains.ProductCategories
{
    public class ProductCategory
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid CategoryId { get; set; }

        public Product Product { get; set; }
        public Category Category { get; set; }

        protected ProductCategory() { }

        internal static ProductCategory Create(Guid productId, Guid categoryId)
        {
            if (productId == Guid.Empty)
                throw new ArgumentException("Product ID cannot be empty.", nameof(productId));

            if (categoryId == Guid.Empty)
                throw new ArgumentException("Category ID cannot be empty.", nameof(categoryId));

            return new ProductCategory
            {
                ProductId = productId,
                CategoryId = categoryId
            };
        }
    }
}
