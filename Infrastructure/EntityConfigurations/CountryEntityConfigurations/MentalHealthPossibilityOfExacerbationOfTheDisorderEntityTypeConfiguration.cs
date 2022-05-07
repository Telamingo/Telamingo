using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.AggregateModels.CountryAggregate;

namespace Infrastructure.EntityConfigurations.CountryEntityConfigurations
{
    public class MentalHealthPossibilityOfExacerbationOfTheDisorderEntityTypeConfiguration : IEntityTypeConfiguration<MentalHealthPossibilityOfExacerbationOfTheDisorder>
    {
        public void Configure(EntityTypeBuilder<MentalHealthPossibilityOfExacerbationOfTheDisorder> userConfiguration)
        {
            userConfiguration.ToTable("MentalHealthPossibilityOfExacerbationOfTheDisorder", TelamingoDbContext.DEFAULT_SCHEMA);

            userConfiguration.HasKey(ct => ct.Id);

            userConfiguration
                .Property(ct => ct.Id)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.MentalHealthInformationId)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("MentalHealthInformationId")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.DisorderId)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("DisorderId")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Possibility)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Possibility")
                .HasColumnType("double")
                .IsRequired();

            userConfiguration
                .HasOne(a => a.MentalHealthInformation)
                .WithMany(a => a.mentalHealthPossibilityOfExacerbationOfTheDisorders)
                .HasForeignKey(a => a.MentalHealthInformationId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            userConfiguration
                .HasOne(a => a.Disorder)
                .WithMany(a => a.mentalHealthPossibilityOfExacerbationOfTheDisorders)
                .HasForeignKey(a => a.DisorderId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}