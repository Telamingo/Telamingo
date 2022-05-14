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
    internal class EnvironmentalEntityTypeConfiguration : IEntityTypeConfiguration<Environmental>
    {
        public void Configure(EntityTypeBuilder<Environmental> userConfiguration)
        {
            userConfiguration.ToTable("Environmental", TelamingoDbContext.DEFAULT_SCHEMA);

            userConfiguration.HasKey(ct => ct.Id);

            userConfiguration
                .Property(ct => ct.Id)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.SpecialWeather)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("SpecialWeather")
                .HasColumnType("bit")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Cloudy)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Cloudy")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Snowy)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Snowy")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Sunny)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Sunny ")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Moderate)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Moderate")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.UnusualDaytime)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("UnusualDaytime")
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
                .WithMany(a => a.Environmentals)
                .HasForeignKey(a => a.UserAnswerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}