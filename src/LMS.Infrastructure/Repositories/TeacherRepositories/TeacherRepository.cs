using LMS.Domain.Entities;
using LMS.Infrastructure.Repositories.Base;

namespace LMS.Infrastructure.Repositories.TeacherRepositories
{
    public class TeacherRepository : BaseRepsitory<Teacher>, ITeacherRepository
    {
        public TeacherRepository(AppDbContext context)
            : base(context) { }
    }
}
