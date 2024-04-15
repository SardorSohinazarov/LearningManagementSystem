using LMS.Domain.Entities;

namespace LMS.Application.ViewModels
{
    public class LessonViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public long CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
