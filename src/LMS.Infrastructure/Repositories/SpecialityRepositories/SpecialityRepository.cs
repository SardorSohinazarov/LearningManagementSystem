using LMS.Application.Abstractions.Repositories;
using LMS.Domain.Entities;
using LMS.Infrastructure.Repositories.Base;

namespace LMS.Infrastructure.Repositories.SpecialityRepositories
{
    public class SpecialityRepository : BaseRepsitory<Speciality>, ISpecialityRepository
    {
        public SpecialityRepository(AppDbContext context)
            : base(context) { }
    }
}
