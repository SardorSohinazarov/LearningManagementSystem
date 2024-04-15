using LMS.Domain.Entities;

namespace LMS.Application.Abstractions.Repositories
{
    public interface IHomeworkRepository : IBaseRepository<Homework>
    {
        IQueryable<Homework> SelectAllAll(long id);
    }
}
