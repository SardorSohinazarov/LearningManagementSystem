using LMS.Application.DataTransferObjects.Specialities;
using LMS.Domain.Entities;

namespace LMS.Application.Services.LessonServices
{
    public interface ISpecialityService
    {
        ValueTask<Speciality> CreateSpecialityAsync(SpecialityCreationDTO specialityCreationDTO);
        IQueryable<Speciality> GetAllSpecialitiesAsync();
        ValueTask<Speciality> GetSpecialityByIdAsync(long id);
        ValueTask<Speciality> UpdateSpecialityAsync(long id, SpecialityModificationDTO specialityModificationDTO);
        ValueTask<Speciality> DeleteSpecialityAsync(long id);
    }
}
