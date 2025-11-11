using Microsoft.Extensions.DependencyInjection;

namespace clean_architecture_demo_v1.Core
{
    public static class DependencyInjection
    {
            public static IServiceCollection AddCoreDI(this IServiceCollection services)
            {
                return services;
            }
    }
}
