using LMS.Application.Abstractions.Repositories;
using LMS.Application.DataTransferObjects.Lessons;
using LMS.Domain.Entities;
using Mapster;

namespace LMS.Application.Services.LessonServices
{
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;

        public LessonService(ILessonRepository lessonRepository)
            => _lessonRepository = lessonRepository;

        public async ValueTask<Lesson> CreateLessonAsync(LessonCreationDTO lessonCreationDTO)
        {
            var lesson = lessonCreationDTO.Adapt<Lesson>();
            var result = await _lessonRepository.InsertAsync(lesson);

            return result;
        }

        public async ValueTask<Lesson> DeleteLessonAsync(long id)
        {
            var storedLesson = await _lessonRepository.SelectByIdAsync(id);
            if (storedLesson is null) { /*Validation*/}

            var result = await _lessonRepository.DeleteAsync(storedLesson);

            return result;
        }

        public IQueryable<Lesson> GetAllLessonsAsync()
            => _lessonRepository.SelectAll();

        public async ValueTask<Lesson> GetLessonByIdAsync(long id)
        {
            var storedLesson = await _lessonRepository.SelectByIdAsync(id);
            if (storedLesson is null) { /*Validation*/}

            return storedLesson;
        }

        public async ValueTask<Lesson> UpdateLessonAsync(long id, LessonModificationDTO lessonModificationDTO)
        {
            var storedLesson = await _lessonRepository.SelectByIdAsync(id);
            if (storedLesson is null) { /*Validation*/}

            storedLesson = lessonModificationDTO.Adapt(storedLesson);
            var result = await _lessonRepository.UpdateAsync(storedLesson);

            return result;
        }
    }
}
