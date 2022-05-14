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
    internal class PrimaryEntityTypeConfiguration : IEntityTypeConfiguration<Primary>
    {
        public void Configure(EntityTypeBuilder<Primary> userConfiguration)
        {
            userConfiguration.ToTable("Primary", TelamingoDbContext.DEFAULT_SCHEMA);

            userConfiguration.HasKey(ct => ct.Id);

            userConfiguration
                .Property(ct => ct.Id)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.User_Destination)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("User_Destination")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.Preferred_Visa_Type)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Preferred_Visa_Type")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.Age)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Age")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Sex)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Sex")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.First_Lang)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("First_Lang")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.Level)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Level")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Second_Lang)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Second_Lang")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.Second_LangLevel)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Second_LangLevel")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Third_Lang)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Third_Lang")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.Third_LangLevel)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Third_LangLevel")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Marriage)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Marriage")
                .HasColumnType("bit")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.NumberOfCompanions)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("NumberOfCompanions")
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
                .WithMany(a => a.Primarys)
                .HasForeignKey(a => a.UserAnswerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}