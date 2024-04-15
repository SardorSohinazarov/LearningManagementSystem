using LMS.Application.Abstractions.Repositories;
using LMS.Domain.Entities;
using LMS.Infrastructure.Repositories.Base;

namespace LMS.Infrastructure.Repositories.StudentRepositories
{
    public class StudentRepository : BaseRepsitory<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context)
            : base(context) { }
    }
}
