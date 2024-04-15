using LMS.Application.DataTransferObjects.Teachers;
using LMS.Domain.Entities;

namespace LMS.Application.Services.TeacherServices
{
    public interface ITeacherService
    {
        ValueTask<Teacher> CreateTeacherAsync(TeacherCreationDTO teacherCreationDTO);
        IQueryable<Teacher> GetAllSpecialitiesAsync();
        ValueTask<Teacher> GetTeacherByIdAsync(long id);
        ValueTask<Teacher> UpdateTeacherAsync(long id, TeacherModificationDTO teacherModificationDTO);
        ValueTask<Teacher> DeleteTeacherAsync(long id);
    }
}
