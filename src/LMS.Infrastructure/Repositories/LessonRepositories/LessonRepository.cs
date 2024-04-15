using LMS.Application.Abstractions.Repositories;
using LMS.Domain.Entities;
using LMS.Infrastructure.Repositories.Base;

namespace LMS.Infrastructure.Repositories.LessonRepositories
{
    public class LessonRepository : BaseRepsitory<Lesson>, ILessonRepository
    {
        public LessonRepository(AppDbContext context)
            : base(context) { }
    }
}
