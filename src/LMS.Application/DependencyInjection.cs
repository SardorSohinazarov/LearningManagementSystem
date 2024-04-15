using LMS.Application.Services.CourseServices;
using LMS.Application.Services.HomeworkServices;
using LMS.Application.Services.LessonServices;
using LMS.Application.Services.TeacherServices;
using LMS.Application.Services.UserServices;
using Microsoft.Extensions.DependencyInjection;

namespace LMS.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseSevice>();
            services.AddScoped<ISpecialityService, SpecialityService>();
            services.AddScoped<IHomeworkService, HomeworkService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<ILessonService, LessonService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
