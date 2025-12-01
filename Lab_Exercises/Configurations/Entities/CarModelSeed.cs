using Lab_Exercises.Domain;
using Microsoft.EntityFrameworkCore;

namespace Lab_Exercises.Configurations.Entities
{
    public class CarModelSeed : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CarModel> builder)
        {
            builder.HasData(
                new CarModel
                {
                    Id = 1,
                    Name = "i4",
                    CreatedDate = new DateTime(2025, 11, 30, 17, 25, 0, DateTimeKind.Utc),
                    UpdatedDate = new DateTime(2025, 11, 30, 17, 25, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new CarModel
                {
                    Id = 2,
                    Name = "X5",
                    CreatedDate = new DateTime(2025, 11, 30, 17, 25, 0, DateTimeKind.Utc),
                    UpdatedDate = new DateTime(2025, 11, 30, 17, 25, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new CarModel
                {
                    Id = 3,
                    Name = "Prius",
                    CreatedDate = new DateTime(2025, 11, 30, 17, 25, 0, DateTimeKind.Utc),
                    UpdatedDate = new DateTime(2025, 11, 30, 17, 25, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new CarModel
                {
                    Id = 4,
                    Name = "C-HR",
                    CreatedDate = new DateTime(2025, 11, 30, 17, 25, 0, DateTimeKind.Utc),
                    UpdatedDate = new DateTime(2025, 11, 30, 17, 25, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
