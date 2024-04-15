namespace LMS.Application.DataTransferObjects.Courses
{
    public class CourseModificationDTO
    {
        public string Name { get; set; }
        public long SpecialityId { get; set; }
        public TimeOnly LessonStartAt { get; set; } // Course boshlanadigan vaqt
        public TimeOnly LessonEndAt { get; set; }
        public DateOnly StartAt { get; set; } // Course boshlanadiga sana
        public DateOnly EndAt { get; set; }
        public long FilialId { get; set; }
    }
}
