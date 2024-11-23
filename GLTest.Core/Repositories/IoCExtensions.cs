using GLTest.Core.Repositories.Categories;
using GLTest.Core.Repositories.ProductCategories;
using GLTest.Core.Repositories.Products;
using Microsoft.Extensions.DependencyInjection;

namespace GLTest.Core.Repositories
{
    public static class IoCExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        { 
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
        }
    }
}
