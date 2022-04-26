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

        userConfiguration
            .HasOne(a => a.EducationalInformation)
            .WithMany(a => a.educationalInformationTuitions)
            .HasForeignKey(a => a.EducationalInformationId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        userConfiguration
            .HasOne(a => a.FildOfStudy)
            .WithMany(a => a.educationalInformationTuitions)
            .HasForeignKey(a => a.FildOfStudyId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

    }
}
