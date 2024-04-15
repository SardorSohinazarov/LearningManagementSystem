using LMS.Application.Abstractions.Repositories;
using LMS.Application.DataTransferObjects.Users;
using LMS.Application.ViewModels;
using LMS.Domain.Entities;
using Mapster;

namespace LMS.Application.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
            => _userRepository = userRepository;

        public async ValueTask<UserViewModel> CreateUserAsync(UserCreationDTO userCreationDTO)
        {
            var user = userCreationDTO.Adapt<User>();

            var salt = Guid.NewGuid().ToString();
            var password = Guid.NewGuid().ToString();

            user.PasswordHash = password;
            user.Salt = salt;
            user.RefreshTokenExpireDate = DateTime.UtcNow;
            user.RefreshToken = password;

            var result = await _userRepository.InsertAsync(user);

            if (result is null)
                throw new Exception("Failed");

            return result.Adapt<UserViewModel>();
        }

        public async ValueTask<UserViewModel> DeleteUserAsync(long id)
        {
            var storedUser = await _userRepository.SelectByIdAsync(id);

            if (storedUser is null)
                throw new Exception("User not found");

            var result = await _userRepository.DeleteAsync(storedUser);

            return result.Adapt<UserViewModel>();
        }

        public List<UserViewModel> GetAllUsersAsync()
        {
            return _userRepository
                .SelectAll()
                .Select(x => x.Adapt<UserViewModel>())
                .ToList();
        }

        public async ValueTask<UserViewModel> GetUserByIdAsync(long id)
        {
            var storedUser = await _userRepository.SelectByIdAsync(id);

            if (storedUser is null)
                throw new Exception("User not found");

            return storedUser.Adapt<UserViewModel>();
        }

        public async ValueTask<UserViewModel> UpdateUserAsync(long id, UserModificationDTO userModificationDTO)
        {
            var storedUser = await _userRepository.SelectByIdAsync(id);

            if (storedUser is null)
                throw new Exception("User not found");

            storedUser = userModificationDTO.Adapt(storedUser);

            var result = await _userRepository.UpdateAsync(storedUser);

            return result.Adapt<UserViewModel>();
        }
    }
}
