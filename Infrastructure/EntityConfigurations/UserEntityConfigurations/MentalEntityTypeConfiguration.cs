using Domain.AggregateModels.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityConfigurations.UserEntityConfigurations
{
    internal class MentalEntityTypeConfiguration : IEntityTypeConfiguration<Mental>
    {
        public void Configure(EntityTypeBuilder<Mental> userConfiguration)
        {
            userConfiguration.ToTable("Mental", TelamingoDbContext.DEFAULT_SCHEMA);

            userConfiguration.HasKey(ct => ct.Id);

            userConfiguration
                .Property(ct => ct.Id)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.FamilyVisit)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("FamilyVisit")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.MentalIll)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("MentalIll")
                .HasColumnType("bit")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.First)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("First")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Secend)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Secend")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Third)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Third")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired();

            userConfiguration
                .Property(ct => ct.UserAnswerId)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("UserAnswerId")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .HasOne(a => a.UserAnswer)
                .WithMany(a => a.Mentals)
                .HasForeignKey(a => a.UserAnswerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
