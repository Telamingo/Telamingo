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
    internal class PrimaryEntityTypeConfiguration : IEntityTypeConfiguration<Primary>
    {
        public void Configure(EntityTypeBuilder<Primary> userConfiguration)
        {
            userConfiguration.ToTable("User", TelamingoDbContext.DEFAULT_SCHEMA);

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
                .IsRequired(false);

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
                .IsRequired(false);

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
                .IsRequired(false);

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
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.Marriage)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Marriage")
                .HasColumnType("bit")
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.NumberOfCompanions)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("NumberOfCompanions")
                .HasColumnType("int")
                .IsRequired(false);
        }
    }
}