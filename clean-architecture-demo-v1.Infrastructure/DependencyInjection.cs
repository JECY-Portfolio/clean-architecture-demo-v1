using clean_architecture_demo_v1.Core.Interfaces;
using clean_architecture_demo_v1.Core.Options;
using clean_architecture_demo_v1.Infrastructure.Data;
using clean_architecture_demo_v1.Infrastructure.Repositories;
using clean_architecture_demo_v1.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace clean_architecture_demo_v1.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>((provider, options) =>
            {
                options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>().Value.DefaultConnection);
            });

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IExternalVendorRepository, ExternalVendorRepository>();

           services.AddHttpClient<ICoindeskHttpClientService, CoindeskHttpClientService>(option =>
           {
               option.BaseAddress = new Uri("https://api.coindesk.com/v1/");
           });

            services.AddHttpClient<IJokeHttpClientService, JokeHttpClientService>(option =>
            {
                option.BaseAddress = new Uri("https://official-joke-api.appspot.com/");
            });


            return services;
        }
    }
}
