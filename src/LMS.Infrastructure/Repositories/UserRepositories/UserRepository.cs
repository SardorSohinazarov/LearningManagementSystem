using LMS.Application.Abstractions.Repositories;
using LMS.Domain.Entities;
using LMS.Infrastructure.Repositories.Base;

namespace LMS.Infrastructure.Repositories.UserRepositories
{
    public class UserRepository : BaseRepsitory<User>, IUserRepository
    {
        public UserRepository(AppDbContext context)
            : base(context) { }
    }
}
