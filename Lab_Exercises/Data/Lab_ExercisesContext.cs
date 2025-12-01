using Lab_Exercises.Configurations.Entities;
using Lab_Exercises.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab_Exercises.Data
{
    public class Lab_ExercisesContext(DbContextOptions<Lab_ExercisesContext> options) : IdentityDbContext<Lab_ExercisesUser>(options)
    {
    
    public DbSet<Lab_Exercises.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<Lab_Exercises.Domain.CarModel> CarModel { get; set; } = default!;
        public DbSet<Lab_Exercises.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<Lab_Exercises.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<Lab_Exercises.Domain.Make> Make { get; set; } = default!;
        public DbSet<Lab_Exercises.Domain.Vehicle> Vehicle { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ColourSeed());
            modelBuilder.ApplyConfiguration(new CarModelSeed());
            modelBuilder.ApplyConfiguration(new MakeSeed());

        }
    }
}
