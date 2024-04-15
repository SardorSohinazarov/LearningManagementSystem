using LMS.Domain.Entities;
using LMS.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
            => Database.Migrate();

        //Users
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Role> Roles { get; set; }

        //Courses
        public DbSet<Course> Courses { get; set; }
        public DbSet<Speciality> Specializations { get; set; }

        //Lessons
        public DbSet<Lesson> Lessons { get; set; }

        //Files
        public DbSet<Filial> Filials { get; set; }

        //Homeworks
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<HomeworkFile> HomeworkFiles { get; set; }
        public DbSet<HomeworkStudent> HomeworkStudents { get; set; }
        public DbSet<HomeworkStudentFile> HomeworkStudentFiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new FilialConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
