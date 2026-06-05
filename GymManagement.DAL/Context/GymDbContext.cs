using Microsoft.EntityFrameworkCore;
using MVC1.FluentConfigration;
using MVC1.Models;

namespace MVC1.Context
{
    public class GymDbContext :DbContext
    { 
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options)
        {
            
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
