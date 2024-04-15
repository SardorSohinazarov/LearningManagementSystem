using LMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Infrastructure.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(new Role[]
            {
                new Role()
                {
                    Id = 1,
                    Name = "Asistent",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Role()
                {
                    Id = 2,
                    Name = "Teacher",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                 new Role()
                {
                    Id = 3,
                    Name = "Admin",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
            });
        }
    }
}
