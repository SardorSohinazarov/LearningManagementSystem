using LMS.Domain.Comman;

namespace LMS.Domain.Entities
{
    public class Course : Auditable
    {
        public string Name { get; set; }
        public long SpecialityId { get; set; }
        public TimeOnly LessonStartAt { get; set; }
        public TimeOnly LessonEndAt { get; set; }
        public DateOnly StartAt { get; set; }
        public DateOnly EndAt { get; set; }

        public virtual Speciality Speciality { get; set; }
        public virtual List<Lesson> Lessons { get; set; }
    }
}
