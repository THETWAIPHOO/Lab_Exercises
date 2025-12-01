using Lab_Exercises.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Lab_Exercises.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<Lab_ExercisesUser>
    {
        public void Configure(EntityTypeBuilder<Lab_ExercisesUser> builder)
        {
            //var hasher = new PasswordHasher<Lab_ExercisesUser>();
            builder.HasData(
                new Lab_ExercisesUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = "AQAAAAIAAYagAAAAEI1fSLcTV9JUgYO2lJFFRKvdlnX9I5cA17WW3Thr4152Uo9/S64nFDAT58ud6PRbQA==",
                    EmailConfirmed = true,
                    SecurityStamp = "SEJFVFYNRSJZB5TGSDNE4GHFT7GS6TRE",
                    ConcurrencyStamp = "c8554266-b401-4519-9aeb-0622ad0ee11b"


                }
                );
        }
    }
}
