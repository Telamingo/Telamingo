using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.AggregateModels.UserAggregate;
using Infrastructure;


namespace Telamingo.Infrastructure.EntityConfigurations.UserEntityConfigurations
{
    internal class PhysicalEntityTypeConfiguration : IEntityTypeConfiguration<Physical>
    {
        public void Configure(EntityTypeBuilder<Physical> userConfiguration)
        {
            userConfiguration.ToTable("Physical", TelamingoDbContext.DEFAULT_SCHEMA);

            userConfiguration.HasKey(ct => ct.Id);

            userConfiguration
                .Property(ct => ct.Id)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.MedicineNeed)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("MedicineNeed")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.SpecialIll)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("SpecialIll")
                .HasColumnType("bit")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.First)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("First")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.Secend)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Secend")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.Third)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Third")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.MedicineCost)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("MedicineCost")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.SpecialFood)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("SpecialFood")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.TraditionalFood)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("TraditionalFood")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.FastFood)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("FastFood")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Vegeterian)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Vegeterian")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.UserAnswerId)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("UserAnswerId")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .HasOne(a => a.UserAnswer)
                .WithMany(a => a.Physicals)
                .HasForeignKey(a => a.UserAnswerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}