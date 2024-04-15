using LMS.Domain.Comman;

namespace LMS.Domain.Entities
{
    public class HomeworkFile : Auditable
    {
        public long HomeworkId { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
    }
}
