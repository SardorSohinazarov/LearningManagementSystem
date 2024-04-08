using LMS.Domain.Comman;

namespace LMS.Domain.Entities
{
    public class Speciality : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Course> Courses { get; set; }
    }
}
