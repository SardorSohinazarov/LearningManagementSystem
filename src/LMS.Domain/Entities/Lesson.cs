using LMS.Domain.Comman;

namespace LMS.Domain.Entities
{
    public class Lesson : Auditable
    {
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public long CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
