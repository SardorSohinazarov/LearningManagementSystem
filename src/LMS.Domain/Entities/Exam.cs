using LMS.Domain.Comman;

namespace LMS.Domain.Entities
{
    public class Exam : Auditable
    {
        public int NumberOfModul { get; set; }
        public long CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
