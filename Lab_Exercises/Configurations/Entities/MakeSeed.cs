using Lab_Exercises.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab_Exercises.Configurations.Entities
{
    public class MakeSeed : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    Id = 1,
                    Name = "BMW",
                    CreatedDate = new DateTime(2025, 11, 30, 17, 19, 50, DateTimeKind.Utc),
                    UpdatedDate = new DateTime(2025, 11, 30, 17, 19, 50, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Make
                {
                    Id = 2,
                    Name = "Toyota",
                    CreatedDate = new DateTime(2025, 11, 30, 17, 19, 50, DateTimeKind.Utc),
                    UpdatedDate = new DateTime(2025, 11, 30, 17, 19, 50, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
