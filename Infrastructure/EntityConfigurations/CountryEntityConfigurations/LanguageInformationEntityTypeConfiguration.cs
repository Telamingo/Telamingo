using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.AggregateModels.CountryAggregate;

namespace Infrastructure.EntityConfigurations.CountryEntityConfigurations
{
    public class LanguageInformationEntityTypeConfiguration : IEntityTypeConfiguration<LanguageInformation>
    {
        public void Configure(EntityTypeBuilder<LanguageInformation> userConfiguration)
        {
            userConfiguration.ToTable("LanguageInformation", TelamingoDbContext.DEFAULT_SCHEMA);

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
                .Property(ct => ct.LanguageName)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("LanguageName")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired();

            userConfiguration
                .Property(ct => ct.LanguageEpidemicRates)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("LanguageEpidemicRates")
                .HasColumnType("double")
                .IsRequired();

            userConfiguration
                .HasOne(a => a.Country)
                .WithMany(a => a.languageInformation)
                .HasForeignKey(a => a.CountryId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}