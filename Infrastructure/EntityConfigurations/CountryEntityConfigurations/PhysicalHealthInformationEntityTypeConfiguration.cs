using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.AggregateModels.CountryAggregate;

namespace Infrastructure.EntityConfigurations.CountryEntityConfigurations
{
    public class PhysicalHealthInformationEntityTypeConfiguration : IEntityTypeConfiguration<PhysicalHealthInformation>
    {
        public void Configure(EntityTypeBuilder<PhysicalHealthInformation> userConfiguration)
        {
            userConfiguration.ToTable("PhysicalHealthInformation", TelamingoDbContext.DEFAULT_SCHEMA);

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
                .Property(ct => ct.StatusOfTheTreatmentSystemForSpecificDiseases)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("StatusOfTheTreatmentSystemForSpecificDiseases")
                .HasColumnType("double")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.DoctorAccess)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("DoctorAccess")
                .HasColumnType("double")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.AveragePerCapitaHealthExpenditure)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("AveragePerCapitaHealthExpenditure")
                .HasColumnType("double")
                .IsRequired();

            userConfiguration
                .HasOne(a => a.Country)
                .WithMany(a => a.PhysicalHealthInformation)
                .HasForeignKey(a => a.CountryId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}