using LMS.Application.DataTransferObjects.Courses;
using LMS.Application.Services.CourseServices;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
            => _courseService = courseService;

        [HttpPost]
        public async Task<IActionResult> PostAsync(CourseCreationDTO courseCreationDTO)
            => Ok(await _courseService.CreateCourseAsync(courseCreationDTO));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(long id)
            => Ok(await _courseService.GetCourseByIdAsync(id));

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
            => Ok((_courseService.GetAllCoursesAsync()).ToList());

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(long id, CourseModificationDTO courseModificationDTO)
            => Ok(await _courseService.UpdateCourseAsync(id, courseModificationDTO));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
            => Ok(await _courseService.DeleteCourseAsync(id));
    }
}
