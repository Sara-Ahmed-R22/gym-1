using gym_1.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace gym_1.Context
{
    public class GymDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymDb;Trusted_Connection=True; trustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<trainer> Trainers { get; set; } 
        public DbSet<member> Members { get; set; } 
        public DbSet<Plan> Plans { get; set; } 
        public DbSet<MemberShip> MemberShips { get; set; } 
        public DbSet<Session> Sessions { get; set; }
    }
}
