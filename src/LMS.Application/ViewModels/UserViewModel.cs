using LMS.Domain.Enums;

namespace LMS.Application.ViewModels
{
    public class UserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? ProfilePhotoPath { get; set; }
        public EGender Gender { get; set; }
        public long RoleId { get; set; }
        public bool IsBlocked { get; set; }
    }
}
