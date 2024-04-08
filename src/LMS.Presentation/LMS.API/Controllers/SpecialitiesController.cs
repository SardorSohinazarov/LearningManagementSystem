using LMS.Application.DataTransferObjects.Specialities;
using LMS.Application.Services.SpecialityServices;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialitiesController : ControllerBase
    {
        private readonly ISpecialityService _specialityService;

        public SpecialitiesController(ISpecialityService specialityService)
            => _specialityService = specialityService;

        [HttpPost]
        public async Task<IActionResult> PostAsync(SpecialityCreationDTO specialityCreationDTO)
            => Ok(await _specialityService.CreateSpecialityAsync(specialityCreationDTO));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(long id)
            => Ok(await _specialityService.GetSpecialityByIdAsync(id));

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
            => Ok(_specialityService.GetAllSpecialitiesAsync().ToList());

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(long id, SpecialityModificationDTO specialityModificationDTO)
            => Ok(await _specialityService.UpdateSpecialityAsync(id, specialityModificationDTO));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
            => Ok(await _specialityService.DeleteSpecialityAsync(id));
    }
}
