using LMS.Application.DataTransferObjects.Homeworks;
using LMS.Application.ViewModels;
using LMS.Domain.Entities;

namespace LMS.Application.Services.HomeworkServices
{
    public interface IHomeworkService
    {
        ValueTask<Homework> CreateHomeworkAsync(HomeworkCreationDTO homeworkCreationDTO);
        List<HomeworkViewModel> GetAllHomeworksAsync();
        List<HomeworkViewModel> GetAllHomeworksAsync(long id);
        ValueTask<HomeworkViewModel> GetHomeworkByIdAsync(long id);
        ValueTask<Homework> UpdateHomeworkAsync(long id, HomeworkModificationDTO homeworkModificationDTO);
        ValueTask<Homework> DeleteHomeworkAsync(long id);
    }
}
