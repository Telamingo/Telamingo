using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.AggregateModels.CountryAggregate;

namespace Infrastructure.EntityConfigurations.CountryEntityConfigurations
{
    public class EducationalInformationEntityTypeConfiguration : IEntityTypeConfiguration<EducationalInformation>
    {
        public void Configure(EntityTypeBuilder<EducationalInformation> userConfiguration)
        {
            userConfiguration.ToTable("EducationalInformation", TelamingoDbContext.DEFAULT_SCHEMA);

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
                .HasOne(a => a.Country)
                .WithMany(a => a.educationalInformation)
                .HasForeignKey(a => a.CountryId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}