using Microsoft.EntityFrameworkCore;
using MVC1.Models;

namespace MVC1.FluentConfigration
{
    public class PlanConfigration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Plan> builder)
        {
            builder.Property(P => P.Name)
                .HasColumnType("Varchar")
                .HasMaxLength(30);

            builder.Property(P => P.Description)
                   .HasMaxLength(200);

            builder.Property(P => P.Price)
                   .HasPrecision(10, 2);

            builder.Property(P => P.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");

            builder.ToTable(TB =>
            {
                TB.HasCheckConstraint("PlanCheck ", "DurationDays Between 1 and 365");
            });


        }
    }
}
