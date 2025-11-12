using clean_architecture_demo_v1.Application.Interfaces;
using clean_architecture_demo_v1.Infrastructure.Data;
using clean_architecture_demo_v1.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace clean_architecture_demo_v1.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Employees;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
            });

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            return services;
        }
    }
}
