using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telamingo.Domain.AggregateModels.CountryAggregate;

namespace Infrastructure.EntityConfigurations.CountryEntityConfigurations;

public class WelfareInformationEntityTypeConfiguration : IEntityTypeConfiguration<WelfareInformation>
{
    public void Configure(EntityTypeBuilder<WelfareInformation> userConfiguration)
    {
        userConfiguration.ToTable("WelfareInformation", TelamingoDbContext.DEFAULT_SCHEMA);

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
            .Property(ct => ct.JobId)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("JobId")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.AnnualSavingsRates)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("AnnualSavingsRates")
            .HasColumnType("double")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.RequiredSpecialization)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("RequiredSpecialization")
            .HasColumnType("double")
            .IsRequired();

        userConfiguration
            .HasOne(a => a.Country)
            .WithMany(a => a.welfareInformation)
            .HasForeignKey(a => a.CountryId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        userConfiguration
            .HasOne(a => a.Job)
            .WithMany(a => a.welfareInformation)
            .HasForeignKey(a => a.JobId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
