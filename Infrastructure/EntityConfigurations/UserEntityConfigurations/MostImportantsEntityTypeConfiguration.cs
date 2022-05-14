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
    internal class MostImportantsEntityTypeConfiguration : IEntityTypeConfiguration<MostImportants>
    {
        public void Configure(EntityTypeBuilder<MostImportants> userConfiguration)
        {
            userConfiguration.ToTable("MostImportants", TelamingoDbContext.DEFAULT_SCHEMA);

            userConfiguration.HasKey(ct => ct.Id);

            userConfiguration
                .Property(ct => ct.Id)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.FirstProblem)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("FirstProblem")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.SecendProblem)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("SecendProblem")
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
                .WithMany(a => a.MostImportantss)
                .HasForeignKey(a => a.UserAnswerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}