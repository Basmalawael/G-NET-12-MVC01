using GymManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.FluentConfigration
{
    //T >>> Class Imp == GymUser <<<>>> Member , Trainer 
    public class GymUserConfigration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(X => X.Name)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(X => X.Email)
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x=>x.Phone)  .IsUnique();

            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint("Emailcheck", "Email Like '_%@_%._%'");
                tb.HasCheckConstraint("PhoneCheck", "Phone Like '010' or Phone Like '011'  or Phone Like '012' or Phone Like '015' ");
            });

            //Owned Address 
            builder.OwnsOne(X => X.Address , address =>
            {
                address.Property(a => a.Street).HasColumnName("Street").HasColumnType("varchar").HasMaxLength(50);
                address.Property(a=>a.City).HasColumnName("City") .HasColumnType("varchar") .HasMaxLength(50); 
            });
        }
    }
}
