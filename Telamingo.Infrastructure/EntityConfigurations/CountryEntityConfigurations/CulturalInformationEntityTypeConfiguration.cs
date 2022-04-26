using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telamingo.Domain.AggregateModels.CountryAggregate;

namespace Telamingo.Infrastructure.EntityConfigurations.CountryEntityConfigurations;

public class CulturalInformationEntityTypeConfiguration : IEntityTypeConfiguration<CulturalInformation>
{
    public void Configure(EntityTypeBuilder<CulturalInformation> userConfiguration)
    {
        userConfiguration.ToTable("CulturalInformation", TelamingoDbContext.DEFAULT_SCHEMA);

        userConfiguration.HasKey(ct => ct.Id);

        userConfiguration
            .Property(ct => ct.Id)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Id")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.CountryId)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("CountryId")
            .HasColumnType("int")
            .IsRequired();

        //userConfiguration
        //    .Property(ct => ct.WeatherName)
        //    .UsePropertyAccessMode(PropertyAccessMode.Field)
        //    .HasColumnName("WeatherName")
        //    .HasColumnType("double")
        //    .IsRequired();

        //userConfiguration
        //    .Property(ct => ct.WeatherRate)
        //    .UsePropertyAccessMode(PropertyAccessMode.Field)
        //    .HasColumnName("WeatherRate")
        //    .HasColumnType("double")
        //    .IsRequired();
    }
}
