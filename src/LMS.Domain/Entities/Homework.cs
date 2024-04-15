using LMS.Domain.Comman;

namespace LMS.Domain.Entities
{
    public class Homework : Auditable
    {
        public long CourseId { get; set; }
        public long TeacherId { get; set; }
        public long LessonId { get; set; }

        public DateTime Deadline { get; set; }

        public virtual Lesson Lesson { get; set; }
        public virtual List<HomeworkFile> HomeworkFiles { get; set; }
    }
}
