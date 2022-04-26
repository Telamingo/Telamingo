using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telamingo.Domain.AggregateModels.CountryAggregate;

namespace Telamingo.Infrastructure.EntityConfigurations.CountryEntityConfigurations;

public class EnvironmentalLanguageInformationEntityTypeConfiguration : IEntityTypeConfiguration<EnvironmentalLanguageInformation>
{
    public void Configure(EntityTypeBuilder<EnvironmentalLanguageInformation> userConfiguration)
    {
        userConfiguration.ToTable("EnvironmentalLanguageInformation", TelamingoDbContext.DEFAULT_SCHEMA);

        userConfiguration.HasKey(ct => ct.Id);

        userConfiguration
            .Property(ct => ct.Id)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Id")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.EnvironmentalInformationId)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("EnvironmentalInformationId")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.LanguageId)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("LanguageId")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.Rate)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Rate")
            .HasColumnType("double")
            .IsRequired();

        userConfiguration
            .HasOne(a => a.EnvironmentalInformation)
            .WithMany(a => a.environmentalLanguageInformation)
            .HasForeignKey(a => a.EnvironmentalInformationId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        userConfiguration
            .HasOne(a => a.Language)
            .WithMany(a => a.environmentalLanguageInformation)
            .HasForeignKey(a => a.LanguageId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

    }
}
