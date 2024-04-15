using LMS.Domain.Comman;
using LMS.Domain.Enums;

namespace LMS.Domain.Entities
{
    public class User : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? ProfilePhotoPath { get; set; }
        public EGender Gender { get; set; } = EGender.Male;
        public string Login { get; set; }
        public string Salt { get; set; }
        public string PasswordHash { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpireDate { get; set; }
        public long RoleId { get; set; }
        public bool IsBlocked { get; set; } = false;

        public virtual Teacher? Teacher { get; set; }
        public virtual Role Role { get; set; }
    }
}
