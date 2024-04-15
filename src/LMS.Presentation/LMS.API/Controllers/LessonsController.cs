using LMS.Application.DataTransferObjects.Lessons;
using LMS.Application.Services.LessonServices;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        private readonly ILessonService _lessonService;

        public LessonsController(ILessonService lessonService)
            => _lessonService = lessonService;

        [HttpPost]
        public async Task<IActionResult> PostAsync(LessonCreationDTO lessonCreationDTO)
            => Ok(await _lessonService.CreateLessonAsync(lessonCreationDTO));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(long id)
            => Ok(await _lessonService.GetLessonByIdAsync(id));

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
            => Ok(_lessonService.GetAllLessonsAsync().ToList());

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(long id, LessonModificationDTO LessonModificationDTO)
            => Ok(await _lessonService.UpdateLessonAsync(id, LessonModificationDTO));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
            => Ok(await _lessonService.DeleteLessonAsync(id));
    }
}
