using clean_architecture_demo_v1.Application;
using clean_architecture_demo_v1.Infrastructure;
using clean_architecture_demo_v1.Core;

namespace clean_architecture_demo_v1_api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiDI(this IServiceCollection services, IConfiguration configuration)
        {
           services.AddApplicationDI()
                   .AddInfrastructureDI()
                   .AddCoreDI(configuration);

            return services;
        }
    }
}
