using LMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Infrastructure.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(new[]
            {
                new Course(){ Id = 1, Name = ".Net bootcamp", FilialId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, SpecialityId = 1, StartAt = DateOnly.FromDateTime(DateTime.Now), EndAt = DateOnly.FromDateTime(DateTime.Now), LessonStartAt = TimeOnly.FromDateTime(DateTime.Now), LessonEndAt = TimeOnly.FromDateTime(DateTime.Now)},
                new Course(){ Id = 2, Name = ".Net bootcamp 1", FilialId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, SpecialityId = 1, StartAt = DateOnly.FromDateTime(DateTime.Now), EndAt = DateOnly.FromDateTime(DateTime.Now), LessonStartAt = TimeOnly.FromDateTime(DateTime.Now), LessonEndAt = TimeOnly.FromDateTime(DateTime.Now)},
                new Course(){ Id = 3, Name = ".Net bootcamp 2", FilialId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, SpecialityId = 1, StartAt = DateOnly.FromDateTime(DateTime.Now), EndAt = DateOnly.FromDateTime(DateTime.Now), LessonStartAt = TimeOnly.FromDateTime(DateTime.Now), LessonEndAt = TimeOnly.FromDateTime(DateTime.Now)},
            });
        }
    }
}
