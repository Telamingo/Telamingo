using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telamingo.Domain.AggregateModels.CountryAggregate;

namespace Telamingo.Infrastructure.EntityConfigurations.CountryEntityConfigurations;

public class EnvironmantalInformationEntityTypeConfiguration : IEntityTypeConfiguration<EnvironmentalInformation>
{
    public void Configure(EntityTypeBuilder<EnvironmentalInformation> userConfiguration)
    {
        userConfiguration.ToTable("EnvironmantalInformation", TelamingoDbContext.DEFAULT_SCHEMA);

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
            .Property(ct => ct.ReligiousIssues)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("ReligiousIssues")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.Immigration)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Immigration")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.SocialRelationshipMatching)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("SocialRelationshipMatching")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .HasOne(a => a.Country)
            .WithMany(a => a.environmentalInformation)
            .HasForeignKey(a => a.CountryId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
