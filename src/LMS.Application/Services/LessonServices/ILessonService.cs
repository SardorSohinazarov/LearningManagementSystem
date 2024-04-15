using LMS.Application.DataTransferObjects.Lessons;
using LMS.Domain.Entities;

namespace LMS.Application.Services.LessonServices
{
    public interface ILessonService
    {
        ValueTask<Lesson> CreateLessonAsync(LessonCreationDTO lessonCreationDTO);
        IQueryable<Lesson> GetAllLessonsAsync();
        ValueTask<Lesson> GetLessonByIdAsync(long id);
        ValueTask<Lesson> UpdateLessonAsync(long id, LessonModificationDTO lessonModificationDTO);
        ValueTask<Lesson> DeleteLessonAsync(long id);
    }
}
