using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telamingo.Domain.AggregateModels.CountryAggregate;

namespace Infrastructure.EntityConfigurations.CountryEntityConfigurations;

public class EducationalProbabilityOfAcceptanceEntityTypeConfiguration : IEntityTypeConfiguration<EducationalProbabilityOfAcceptance>
{
    public void Configure(EntityTypeBuilder<EducationalProbabilityOfAcceptance> userConfiguration)
    {
        userConfiguration.ToTable("EducationalProbabilityOfAcceptance", TelamingoDbContext.DEFAULT_SCHEMA);

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
            .Property(ct => ct.Rate)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Rate")
            .HasColumnType("double")
            .IsRequired();

        userConfiguration
            .HasOne(a => a.EducationalInformation)
            .WithMany(a => a.educationalProbabilityOfAcceptances)
            .HasForeignKey(a => a.EducationalInformationId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        userConfiguration
            .HasOne(a => a.FildOfStudy)
            .WithMany(a => a.educationalProbabilityOfAcceptances)
            .HasForeignKey(a => a.FildOfStudyId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
