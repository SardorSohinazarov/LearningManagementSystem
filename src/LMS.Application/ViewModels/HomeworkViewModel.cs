namespace LMS.Application.ViewModels
{
    public class HomeworkViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int CountOfStudent { get; set; }
        public int Waiters { get; set; }
        public int Approved { get; set; }
        public string StartAt { get; set; }
        public string EndAt { get; set; }
        public string LessonDate { get; set; }
    }
}
