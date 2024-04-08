using LMS.Application.DataTransferObjects.Courses;
using LMS.Domain.Entities;

namespace LMS.Application.Services.CourseServices
{
    public interface ICourseService
    {
        IQueryable<Course> GetAllCoursesAsync();
        ValueTask<Course> GetCourseByIdAsync(long id);
        ValueTask<Course> CreateCourseAsync(CourseCreationDTO courseCreationDTO);
        ValueTask<Course> UpdateCourseAsync(long id, CourseModificationDTO courseModificationDTO);
        ValueTask<Course> DeleteCourseAsync(long id);
    }
}
