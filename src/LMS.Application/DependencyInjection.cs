using LMS.Application.Services.CourseServices;
using LMS.Application.Services.SpecialityServices;
using Microsoft.Extensions.DependencyInjection;

namespace LMS.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseSevice>();
            services.AddScoped<ISpecialityService, SpecialityService>();

            return services;
        }
    }
}
