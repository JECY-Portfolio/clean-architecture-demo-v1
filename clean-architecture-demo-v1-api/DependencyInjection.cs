using clean_architecture_demo_v1.Application;
using clean_architecture_demo_v1.Infrastructure;

namespace clean_architecture_demo_v1_api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiDI(this IServiceCollection services)
        {
           services.AddApplicationDI()
                   .AddInfrastructureDI();

            return services;
        }
    }
}
