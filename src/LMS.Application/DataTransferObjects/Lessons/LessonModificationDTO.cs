namespace LMS.Application.DataTransferObjects.Lessons
{
    public class LessonModificationDTO
    {
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public long CourseId { get; set; }
    }
}
