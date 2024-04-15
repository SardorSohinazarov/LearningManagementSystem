using LMS.Domain.Comman;

namespace LMS.Domain.Entities
{
    public class HomeworkStudentFile : Auditable
    {
        public long HomeworkStudentId { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }

        public virtual HomeworkStudent HomeworkStudent { get; set; }
    }
}
