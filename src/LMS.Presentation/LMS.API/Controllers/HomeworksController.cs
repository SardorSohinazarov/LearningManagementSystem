using LMS.Application.DataTransferObjects.Homeworks;
using LMS.Application.Services.HomeworkServices;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeworksController : ControllerBase
    {
        private readonly IHomeworkService _homeworkService;

        public HomeworksController(IHomeworkService homeworkService)
            => _homeworkService = homeworkService;

        [HttpPost]
        public async Task<IActionResult> PostAsync(HomeworkCreationDTO homeworkCreationDTO)
            => Ok(await _homeworkService.CreateHomeworkAsync(homeworkCreationDTO));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(long id)
            => Ok(await _homeworkService.GetHomeworkByIdAsync(id));

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
            => Ok(_homeworkService.GetAllHomeworksAsync());

        [HttpGet("courses/{id}")]
        public async Task<IActionResult> GetAllAsync(long id)
           => Ok(_homeworkService.GetAllHomeworksAsync(id));

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(long id, HomeworkModificationDTO homeworkModificationDTO)
            => Ok(await _homeworkService.UpdateHomeworkAsync(id, homeworkModificationDTO));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
            => Ok(await _homeworkService.DeleteHomeworkAsync(id));
    }
}
