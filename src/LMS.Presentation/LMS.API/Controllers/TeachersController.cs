using LMS.Application.DataTransferObjects.Teachers;
using LMS.Application.Services.TeacherServices;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeachersController(ITeacherService TeacherService)
            => _teacherService = TeacherService;

        [HttpPost]
        public async Task<IActionResult> PostAsync(TeacherCreationDTO teacherCreationDTO)
            => Ok(await _teacherService.CreateTeacherAsync(teacherCreationDTO));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(long id)
            => Ok(await _teacherService.GetTeacherByIdAsync(id));

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
            => Ok(_teacherService.GetAllSpecialitiesAsync());

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(long id, TeacherModificationDTO teacherModificationDTO)
            => Ok(await _teacherService.UpdateTeacherAsync(id, teacherModificationDTO));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
            => Ok(await _teacherService.DeleteTeacherAsync(id));
    }
}
