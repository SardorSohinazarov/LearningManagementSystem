using LMS.Application.Abstractions.Repositories;
using LMS.Application.DataTransferObjects.Courses;
using LMS.Domain.Entities;
using Mapster;

namespace LMS.Application.Services.CourseServices
{
    public class CourseSevice : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseSevice(ICourseRepository courseRepository)
            => _courseRepository = courseRepository;

        public async ValueTask<Course> CreateCourseAsync(CourseCreationDTO courseCreationDTO)
        {
            var course = courseCreationDTO.Adapt<Course>();
            var result = await _courseRepository.InsertAsync(course);

            return result;
        }

        public IQueryable<Course> GetAllCoursesAsync()
            => _courseRepository.SelectAll();

        public async ValueTask<Course> GetCourseByIdAsync(long id)
        {
            var storedCourse = await _courseRepository.SelectByIdAsync(id);

            if (storedCourse is null) { /*Exception throwing*/ }

            return storedCourse;
        }

        public async ValueTask<Course> UpdateCourseAsync(long id, CourseModificationDTO courseModificationDTO)
        {
            var storedCourse = await _courseRepository.SelectByIdAsync(id);

            if (storedCourse is null) { /*Exception throwing*/ }

            storedCourse = courseModificationDTO.Adapt(storedCourse);
            var result = await _courseRepository.UpdateAsync(storedCourse);

            return result;
        }


        public async ValueTask<Course> DeleteCourseAsync(long id)
        {
            var storedCourse = await _courseRepository.SelectByIdAsync(id);

            if (storedCourse is null) { /*Exception throwing*/ }

            var result = await _courseRepository.DeleteAsync(storedCourse);

            return result;
        }
    }
}
