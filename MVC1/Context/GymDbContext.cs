using Microsoft.EntityFrameworkCore;
using MVC1.FluentConfigration;
using MVC1.Models;

namespace MVC1.Context
{
    public class GymDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Plan>(new PlanConfigration());
        }



        #region Table

        public DbSet<Plan> Plans { get; set; }
        #endregion
    }
}
