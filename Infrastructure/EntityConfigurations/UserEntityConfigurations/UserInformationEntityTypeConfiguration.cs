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
    public class UserInformationEntityTypeConfiguration : IEntityTypeConfiguration<UserInformation>
    {
        public void Configure(EntityTypeBuilder<UserInformation> userConfiguration)
        {
            userConfiguration.ToTable("UserInformation", TelamingoDbContext.DEFAULT_SCHEMA);

            userConfiguration.HasKey(ct => ct.Id);

            userConfiguration
                .Property(ct => ct.Id)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.UserAnswerId)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("UserAnswerId")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Email)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Email")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.Name)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(200)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.PhoneNumber)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("PhoneNumber")
                .HasColumnType("nvarchar")
                .HasMaxLength(200)
                .IsRequired(false);

            userConfiguration
                .HasOne(a => a.UserAnswer)
                .WithMany(a => a.UserInformations)
                .HasForeignKey(a => a.UserAnswerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}