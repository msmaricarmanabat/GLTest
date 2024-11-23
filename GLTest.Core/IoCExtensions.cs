using GLTest.Core.Commands;
using GLTest.Core.Common;
using GLTest.Core.Domains;
using GLTest.Core.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GLTest.Core
{
    public static class IoCExtensions
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddCommands();
            services.AddDomains();
            services.AddRepositories();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
