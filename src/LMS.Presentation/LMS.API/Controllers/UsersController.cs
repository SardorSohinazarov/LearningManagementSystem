using LMS.Application.DataTransferObjects.Users;
using LMS.Application.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService specialityService)
            => _userService = specialityService;

        [HttpPost]
        public async Task<IActionResult> PostAsync(UserCreationDTO userCreationDTO)
            => Ok(await _userService.CreateUserAsync(userCreationDTO));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(long id)
            => Ok(await _userService.GetUserByIdAsync(id));

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
            => Ok(_userService.GetAllUsersAsync());

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(long id, UserModificationDTO userModificationDTO)
            => Ok(await _userService.UpdateUserAsync(id, userModificationDTO));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
            => Ok(await _userService.DeleteUserAsync(id));
    }
}
