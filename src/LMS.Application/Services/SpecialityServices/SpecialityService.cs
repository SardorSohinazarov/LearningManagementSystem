using LMS.Application.Abstractions.Repositories;
using LMS.Application.DataTransferObjects.Specialities;
using LMS.Domain.Entities;
using Mapster;

namespace LMS.Application.Services.LessonServices
{
    public class SpecialityService : ISpecialityService
    {
        private readonly ISpecialityRepository _specialityRepository;

        public SpecialityService(ISpecialityRepository specialityRepository)
            => _specialityRepository = specialityRepository;

        public async ValueTask<Speciality> CreateSpecialityAsync(SpecialityCreationDTO specialityCreationDTO)
        {
            var speciality = specialityCreationDTO.Adapt<Speciality>();
            var result = await _specialityRepository.InsertAsync(speciality);

            return result;
        }

        public IQueryable<Speciality> GetAllSpecialitiesAsync()
            => _specialityRepository.SelectAll();

        public async ValueTask<Speciality> GetSpecialityByIdAsync(long id)
        {
            var storedSpeciality = await _specialityRepository.SelectByIdAsync(id);

            if (storedSpeciality is null) { /*throw new not found exception */}

            return storedSpeciality;
        }

        public async ValueTask<Speciality> UpdateSpecialityAsync(long id, SpecialityModificationDTO specialityModificationDTO)
        {
            var storedSpeciality = await _specialityRepository.SelectByIdAsync(id);

            if (storedSpeciality is null) { /*throw new not found exception */}

            storedSpeciality = specialityModificationDTO.Adapt(storedSpeciality);
            var result = await _specialityRepository.UpdateAsync(storedSpeciality);

            return result;
        }

        public async ValueTask<Speciality> DeleteSpecialityAsync(long id)
        {
            var storedSpeciality = await _specialityRepository.SelectByIdAsync(id);

            if (storedSpeciality is null) { /*throw new not found exception */}

            var result = await _specialityRepository.DeleteAsync(storedSpeciality);

            return result;
        }
    }
}
