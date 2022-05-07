using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telamingo.Domain.AggregateModels.CountryAggregate;

namespace Infrastructure.EntityConfigurations.CountryEntityConfigurations;

public class MentalHealthInformationEntityTypeConfiguration : IEntityTypeConfiguration<MentalHealthInformation>
{
    public void Configure(EntityTypeBuilder<MentalHealthInformation> userConfiguration)
    {
        userConfiguration.ToTable("MentalHealthInformation", TelamingoDbContext.DEFAULT_SCHEMA);

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

        userConfiguration
            .Property(ct => ct.AbilityToVisitFamily)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("AbilityToVisitFamily")
            .HasColumnType("double")
            .IsRequired();

        userConfiguration
            .HasOne(a => a.Country)
            .WithMany(a => a.mentalHealthInformation)
            .HasForeignKey(a => a.CountryId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}