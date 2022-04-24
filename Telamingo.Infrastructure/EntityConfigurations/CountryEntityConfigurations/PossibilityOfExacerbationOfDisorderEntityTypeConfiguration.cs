using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telamingo.Domain.AggregateModels.CountryAggregate;

namespace Telamingo.Infrastructure.EntityConfigurations.CountryEntityConfigurations;

public class PossibilityOfExacerbationOfDisorderEntityTypeConfiguration : IEntityTypeConfiguration<PossibilityOfExacerbationOfTheDisorder>
{
    public void Configure(EntityTypeBuilder<PossibilityOfExacerbationOfTheDisorder> userConfiguration)
    {
        userConfiguration.ToTable("PossibilityOfExacerbationOfTheDisorder", TelamingoDbContext.DEFAULT_SCHEMA);

        userConfiguration.HasKey(ct => ct.Id);

        userConfiguration
            .Property(ct => ct.DisorderId)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("DisorderId")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.MentalHealthInformationId)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("MentalHealthInformationId")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.Possibility)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Possibility")
            .HasColumnType("double")
            .IsRequired();
    }
}
