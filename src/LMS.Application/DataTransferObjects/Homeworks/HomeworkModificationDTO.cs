namespace LMS.Application.DataTransferObjects.Homeworks
{
    public class HomeworkModificationDTO
    {
        public long TeacherId { get; set; }
        public long LessonId { get; set; }

        public DateTime Deadline { get; set; }
    }
}
