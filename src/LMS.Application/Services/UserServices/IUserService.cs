using LMS.Application.DataTransferObjects.Users;
using LMS.Application.ViewModels;

namespace LMS.Application.Services.UserServices
{
    public interface IUserService
    {
        ValueTask<UserViewModel> CreateUserAsync(UserCreationDTO userCreationDTO);
        List<UserViewModel> GetAllUsersAsync();
        ValueTask<UserViewModel> GetUserByIdAsync(long id);
        ValueTask<UserViewModel> UpdateUserAsync(long id, UserModificationDTO userModificationDTO);
        ValueTask<UserViewModel> DeleteUserAsync(long id);
    }
}
