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
    public class CompanionsEntityTypeConfiguration : IEntityTypeConfiguration<Companions>
    {
        public void Configure(EntityTypeBuilder<Companions> userConfiguration)
        {
            userConfiguration.ToTable("Companions", TelamingoDbContext.DEFAULT_SCHEMA);

            userConfiguration.HasKey(ct => ct.Id);

            userConfiguration
                .Property(ct => ct.Id)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Age)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Age")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.First_Lang)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("First_Lang")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.Second_Lang)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Second_Lang")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.Third_Lang)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Third_Lang")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.Gender)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Gender")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.Relationship)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Relationship")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);
        }
    }
}
