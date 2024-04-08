using LMS.Application.Abstractions.Repositories;
using LMS.Domain.Entities;
using LMS.Infrastructure.Repositories.Base;

namespace LMS.Infrastructure.Repositories.CourseRepositories
{
    public class CourseRepository : BaseRepsitory<Course>, ICourseRepository
    {
        public CourseRepository(AppDbContext context)
            : base(context) { }
    }
}
