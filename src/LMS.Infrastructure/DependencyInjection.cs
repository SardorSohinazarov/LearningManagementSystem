using LMS.Application.Abstractions.Repositories;
using LMS.Infrastructure.Repositories.CourseRepositories;
using LMS.Infrastructure.Repositories.SpecialityRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LMS.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options
                    .UseLazyLoadingProxies()
                    .UseSqlServer(configuration.GetConnectionString("Default")));

            //course
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ISpecialityRepository, SpecialityRepository>();

            return services;
        }
    }
}
