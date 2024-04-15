using LMS.Application.Abstractions.Repositories;
using LMS.Application.DataTransferObjects.Homeworks;
using LMS.Application.ViewModels;
using LMS.Domain.Entities;
using Mapster;

namespace LMS.Application.Services.HomeworkServices
{
    public class HomeworkService : IHomeworkService
    {
        private readonly IHomeworkRepository _homeworkRepository;

        public HomeworkService(IHomeworkRepository homeworkRepository)
            => _homeworkRepository = homeworkRepository;

        public async ValueTask<Homework> CreateHomeworkAsync(HomeworkCreationDTO homeworkCreationDTO)
        {
            var homework = homeworkCreationDTO.Adapt<Homework>();
            var result = await _homeworkRepository.InsertAsync(homework);

            return result;
        }

        public async ValueTask<Homework> DeleteHomeworkAsync(long id)
        {
            var storedHomework = await _homeworkRepository.SelectByIdAsync(id);

            if (storedHomework == null) { /**/ }

            var result = await _homeworkRepository.DeleteAsync(storedHomework);

            return result;
        }

        public List<HomeworkViewModel> GetAllHomeworksAsync()
        {
            var storedHomeworks = _homeworkRepository.SelectAll();

            return storedHomeworks.Select(x => new HomeworkViewModel()
            {
                Id = x.Id,
                Name = x.Lesson.Name,
                CountOfStudent = 22,
                Approved = 1,
                Waiters = 1,
                LessonDate = x.Lesson.CreatedAt.ToString(),
                StartAt = x.CreatedAt.ToString(),
                EndAt = x.Deadline.ToString(),
            }).ToList();
        }

        public List<HomeworkViewModel> GetAllHomeworksAsync(long id)
        {
            var storedHomeworks = _homeworkRepository.SelectAll();

            return storedHomeworks.Select(x => new HomeworkViewModel()
            {
                Id = x.Id,
                Name = x.Lesson.Name,
                CountOfStudent = 22,
                Approved = 1,
                Waiters = 1,
                LessonDate = x.Lesson.CreatedAt.ToString(),
                StartAt = x.CreatedAt.ToString(),
                EndAt = x.Deadline.ToString(),
            }).ToList();
        }

        public async ValueTask<HomeworkViewModel> GetHomeworkByIdAsync(long id)
        {
            var storedHomework = await _homeworkRepository.SelectByIdAsync(id);

            if (storedHomework == null) { /**/ }

            return new HomeworkViewModel()
            {
                Id = storedHomework.Id,
                Name = storedHomework.Lesson.Name,
                CountOfStudent = 22,
                Approved = 1,
                Waiters = 1,
                LessonDate = storedHomework.Lesson.CreatedAt.ToString(),
                StartAt = storedHomework.CreatedAt.ToString(),
                EndAt = storedHomework.Deadline.ToString(),
            };
        }

        public async ValueTask<Homework> UpdateHomeworkAsync(long id, HomeworkModificationDTO homeworkModificationDTO)
        {
            var storedHomework = await _homeworkRepository.SelectByIdAsync(id);
            if (storedHomework == null) { /**/ }

            storedHomework = homeworkModificationDTO.Adapt(storedHomework);

            var result = await _homeworkRepository.UpdateAsync(storedHomework);

            return result;
        }
    }
}
