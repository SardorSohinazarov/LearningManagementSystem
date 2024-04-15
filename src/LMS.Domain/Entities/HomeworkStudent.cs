namespace LMS.Domain.Entities
{
    public class HomeworkStudent
    {
        public long Id { get; set; }
        public long HomeworkId { get; set; }
        public long StudentId { get; set; }

        public virtual Homework Homework { get; set; }
        public virtual Student Student { get; set; }
        public virtual List<HomeworkStudentFile> HomeworkStudentFiles { get; set; }
    }
}
