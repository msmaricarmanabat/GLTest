using GLTest.Core.Commands.Products;
using Microsoft.Extensions.DependencyInjection;

namespace GLTest.Core.Commands
{
    public static class IoCExtensions
    {
        public static void AddCommands(this IServiceCollection services)
        {
            services.AddTransient<ISetProductCategoryCommand, SetProductCategoryCommand>();
        }
    }
}
