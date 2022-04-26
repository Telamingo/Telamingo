using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telamingo.Domain.AggregateModels.CountryAggregate;

namespace Telamingo.Infrastructure.EntityConfigurations.CountryEntityConfigurations;

public class CulturalWeatherInformationEntityTypeConfiguration : IEntityTypeConfiguration<CulturalweatherInformation>
{
    public void Configure(EntityTypeBuilder<CulturalweatherInformation> userConfiguration)
    {
        userConfiguration.ToTable("CulturalweatherInformation", TelamingoDbContext.DEFAULT_SCHEMA);

        userConfiguration.HasKey(ct => ct.Id);

        userConfiguration
            .Property(ct => ct.Id)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Id")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.CulturalInformationId)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("CulturalInformationId")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.WeatherId)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("WeatherId")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.Rate)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Rate")
            .HasColumnType("double")
            .IsRequired();
    }
}
