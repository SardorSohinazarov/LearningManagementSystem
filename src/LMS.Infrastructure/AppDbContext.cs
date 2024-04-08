using LMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
            => Database.Migrate();

        //User
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        //Course
        public DbSet<Course> Courses { get; set; }
        public DbSet<Speciality> Specializations { get; set; }

        //Lesson
        public DbSet<Lesson> Lessons { get; set; }
    }
}
