using LMS.Domain.Comman;

namespace LMS.Domain.Entities
{
    public class Attendance : Auditable
    {
        public long StudentId { get; set; }
        public long CourseId { get; set; }
    }
}
