using LMS.Application.Abstractions.Repositories;
using LMS.Application.DataTransferObjects.Teachers;
using LMS.Domain.Entities;
using LMS.Infrastructure.Repositories.TeacherRepositories;
using Mapster;

namespace LMS.Application.Services.TeacherServices
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IUserRepository _userRepository;

        public TeacherService(ITeacherRepository teacherRepository, IUserRepository userRepository)
        {
            _teacherRepository = teacherRepository;
            _userRepository = userRepository;
        }

        public async ValueTask<Teacher> CreateTeacherAsync(TeacherCreationDTO teacherCreationDTO)
        {
            var teacher = teacherCreationDTO.Adapt<Teacher>();
            teacher.User = await _userRepository.SelectByIdAsync(teacher.UserId);
            var result = await _teacherRepository.InsertAsync(teacher);

            return result;
        }

        public async ValueTask<Teacher> DeleteTeacherAsync(long id)
        {
            var storedTeacher = await _teacherRepository.SelectByIdAsync(id);
            if (storedTeacher is null) { /*Validation*/}

            var result = await _teacherRepository.DeleteAsync(storedTeacher);
            return result;
        }

        public IQueryable<Teacher> GetAllSpecialitiesAsync()
            => _teacherRepository.SelectAll();

        public async ValueTask<Teacher> GetTeacherByIdAsync(long id)
        {
            var storedTeacher = await _teacherRepository.SelectByIdAsync(id);
            if (storedTeacher is null) { /*Validation*/}

            return storedTeacher;
        }

        public async ValueTask<Teacher> UpdateTeacherAsync(long id, TeacherModificationDTO teacherModificationDTO)
        {
            var storedTeacher = await _teacherRepository.SelectByIdAsync(id);
            if (storedTeacher is null) { /*Validation*/}

            storedTeacher = teacherModificationDTO.Adapt(storedTeacher);
            var result = await _teacherRepository.UpdateAsync(storedTeacher);
            return result;
        }
    }
}
