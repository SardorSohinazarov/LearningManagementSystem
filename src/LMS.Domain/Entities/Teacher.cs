using LMS.Domain.Comman;

namespace LMS.Domain.Entities
{
    public class Teacher : Base
    {
        public long UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
