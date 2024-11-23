using GLTest.Core.Domains.Categories;
using GLTest.Core.Domains.Products;
using Microsoft.Extensions.DependencyInjection;

namespace GLTest.Core.Domains
{
    public static class IoCExtensions
    {
        public static void AddDomains(this IServiceCollection services)
        { 
            services.AddTransient<ICategoryFactory, CategoryFactory>();
            services.AddTransient<IProductFactory, ProductFactory>();
        }
    }
}
