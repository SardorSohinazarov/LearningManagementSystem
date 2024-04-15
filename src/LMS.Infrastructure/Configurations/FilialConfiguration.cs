using LMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Infrastructure.Configurations
{
    public class FilialConfiguration : IEntityTypeConfiguration<Filial>
    {
        public void Configure(EntityTypeBuilder<Filial> builder)
        {
            builder.HasData(new Filial[]
            {
                new Filial(){ Id = 1, Name = "Chilonzor", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.Now },
                new Filial(){ Id = 2, Name = "Chimboy", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.Now },
                new Filial(){ Id = 3, Name = "Farg'ona", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.Now },
                new Filial(){ Id = 4, Name = "Xorazmiy", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.Now },
            });
        }
    }
}
