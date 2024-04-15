using LMS.Application.DataTransferObjects.Courses;
using LMS.Application.ViewModels;
using LMS.Domain.Entities;

namespace LMS.Application.Services.CourseServices
{
    public interface ICourseService
    {
        List<CourseViewModel> GetAllCoursesAsync();
        ValueTask<CourseViewModel> GetCourseByIdAsync(long id);
        ValueTask<Course> CreateCourseAsync(CourseCreationDTO courseCreationDTO);
        ValueTask<Course> UpdateCourseAsync(long id, CourseModificationDTO courseModificationDTO);
        ValueTask<Course> DeleteCourseAsync(long id);
    }
}
