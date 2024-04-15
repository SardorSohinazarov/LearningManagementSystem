using LMS.Application.Abstractions.Repositories;
using LMS.Infrastructure.Repositories.CourseRepositories;
using LMS.Infrastructure.Repositories.HomeworkRepositories;
using LMS.Infrastructure.Repositories.LessonRepositories;
using LMS.Infrastructure.Repositories.SpecialityRepositories;
using LMS.Infrastructure.Repositories.TeacherRepositories;
using LMS.Infrastructure.Repositories.UserRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LMS.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options
                    .UseLazyLoadingProxies()
                    .UseSqlServer(configuration.GetConnectionString("Default")));

            //course
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IHomeworkRepository, HomeworkRepository>();
            services.AddScoped<ILessonRepository, LessonRepository>();
            services.AddScoped<ISpecialityRepository, SpecialityRepository>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();

            return services;
        }
    }
}
