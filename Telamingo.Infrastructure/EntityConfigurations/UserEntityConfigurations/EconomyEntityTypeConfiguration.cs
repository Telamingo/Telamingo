using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telamingo.Domain.AggregateModels.UserAggregate;

namespace Telamingo.Infrastructure.EntityConfigurations.UserEntityConfigurations
{
    internal class EconomyEntityTypeConfiguration : IEntityTypeConfiguration<Economy>
    {
        public void Configure(EntityTypeBuilder<Economy> userConfiguration)
        {
            userConfiguration.ToTable("Economy", TelamingoDbContext.DEFAULT_SCHEMA);

            userConfiguration.HasKey(ct => ct.Id);

            userConfiguration
                .Property(ct => ct.Id)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.CurrentJob)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("CurrentJob")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.CurrentSaving)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("CurrentSaving")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.PreferredSaving)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("PreferredSaving")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.PreferredJob)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("PreferredJob")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.UserAnswerId)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("UserAnswerId")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .HasOne(a => a.UserAnswer)
                .WithMany(a => a.Economys)
                .HasForeignKey(a => a.UserAnswerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}