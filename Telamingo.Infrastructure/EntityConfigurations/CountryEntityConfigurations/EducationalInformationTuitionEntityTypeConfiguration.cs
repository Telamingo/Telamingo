using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telamingo.Domain.AggregateModels.CountryAggregate;

namespace Telamingo.Infrastructure.EntityConfigurations.CountryEntityConfigurations;

public class EducationalInformationTuitionEntityTypeConfiguration : IEntityTypeConfiguration<EducationalInformationTuition>
{
    public void Configure(EntityTypeBuilder<EducationalInformationTuition> userConfiguration)
    {
        userConfiguration.ToTable("EducationalInformationTuition", TelamingoDbContext.DEFAULT_SCHEMA);

        userConfiguration.HasKey(ct => ct.Id);

        userConfiguration
            .Property(ct => ct.Id)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Id")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.EducationalInformationId)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("EducationalInformationId")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.FildOfStudyId)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("FildOfStudyId")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.Price)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Price")
            .HasColumnType("double")
            .IsRequired();
    }
}
