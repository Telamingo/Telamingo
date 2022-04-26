using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telamingo.Domain.AggregateModels.CountryAggregate;

namespace Telamingo.Infrastructure.EntityConfigurations.CountryEntityConfigurations;

public class CulturalClimateInformationEntityTypeConfiguration : IEntityTypeConfiguration<CulturalClimateInformation>
{
    public void Configure(EntityTypeBuilder<CulturalClimateInformation> userConfiguration)
    {
        userConfiguration.ToTable("CulturalClimateInformation", TelamingoDbContext.DEFAULT_SCHEMA);

        userConfiguration.HasKey(ct => ct.Id);

        userConfiguration
            .Property(ct => ct.Id)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Id")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.ClimateId)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("ClimateId")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.CulturalInformationId)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("CulturalInformationId")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.Rate)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Rate")
            .HasColumnType("double")
            .IsRequired();

        userConfiguration
            .HasOne(a => a.Climate)
            .WithMany(a => a.culturalClimateInformation)
            .HasForeignKey(a => a.ClimateId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        userConfiguration
            .HasOne(a => a.CulturalInformation)
            .WithMany(a => a.culturalClimateInformation)
            .HasForeignKey(a => a.CulturalInformationId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

    }
}
