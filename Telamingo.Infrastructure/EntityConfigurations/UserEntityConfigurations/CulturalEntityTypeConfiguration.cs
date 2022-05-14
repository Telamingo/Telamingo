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
    internal class CulturalEntityTypeConfiguration : IEntityTypeConfiguration<Cultural>
    {
        public void Configure(EntityTypeBuilder<Cultural> userConfiguration)
        {
            userConfiguration.ToTable("Cultural", TelamingoDbContext.DEFAULT_SCHEMA);

            userConfiguration.HasKey(ct => ct.Id);

            userConfiguration
                .Property(ct => ct.Id)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.ReligiousMatters)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("ReligiousMatters")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.NationalMatters)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("NationalMatters")
                .HasColumnType("bit")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.IfYesHowMuch)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("IfYesHowMuch")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.ImmigrantCommunity)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("ImmigrantCommunity")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Similarity)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Similarity")
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
                .WithMany(a => a.Culturals)
                .HasForeignKey(a => a.UserAnswerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}