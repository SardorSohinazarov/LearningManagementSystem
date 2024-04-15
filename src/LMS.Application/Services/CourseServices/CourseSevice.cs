using LMS.Application.Abstractions.Repositories;
using LMS.Application.DataTransferObjects.Courses;
using LMS.Application.ViewModels;
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

        public List<CourseViewModel> GetAllCoursesAsync()
        {
            return _courseRepository.SelectAll().Select(x => new CourseViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Filial = x.Filial.Name,
                Speciality = x.Speciality.Name,
                EndAt = x.EndAt.ToString(),
                StartAt = x.StartAt.ToString(),
                LessonStartAt = x.LessonStartAt.ToString(),
                LessonEndAt = x.LessonEndAt.ToString()
            }).ToList();
        }

        public async ValueTask<CourseViewModel> GetCourseByIdAsync(long id)
        {
            var storedCourse = await _courseRepository.SelectByIdAsync(id);

            if (storedCourse is null) { /*Exception throwing*/ }

            return new CourseViewModel()
            {
                Id = storedCourse.Id,
                Name = storedCourse.Name,
                Filial = storedCourse.Filial.Name,
                Speciality = storedCourse.Speciality.Name,
                EndAt = storedCourse.EndAt.ToString(),
                StartAt = storedCourse.StartAt.ToString(),
                LessonStartAt = storedCourse.LessonStartAt.ToString(),
                LessonEndAt = storedCourse.LessonEndAt.ToString()
            };
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
