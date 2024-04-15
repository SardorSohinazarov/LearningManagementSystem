using LMS.Application.Abstractions.Repositories;
using LMS.Domain.Entities;
using LMS.Infrastructure.Repositories.Base;

namespace LMS.Infrastructure.Repositories.HomeworkRepositories
{
    public class HomeworkRepository : BaseRepsitory<Homework>, IHomeworkRepository
    {
        private readonly AppDbContext _appDbContext;
        public HomeworkRepository(AppDbContext context)
            : base(context)
        {
            _appDbContext = context;
        }

        public IQueryable<Homework> SelectAllAll(long id)
        {
            return _appDbContext.Homeworks
                .Where(x => x.CourseId == id);
        }
    }
}
