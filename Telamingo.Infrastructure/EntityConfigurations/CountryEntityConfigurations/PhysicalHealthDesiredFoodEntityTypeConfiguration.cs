using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telamingo.Domain.AggregateModels.CountryAggregate;

namespace Telamingo.Infrastructure.EntityConfigurations.CountryEntityConfigurations;

public class PhysicalHealthDesiredFoodEntityTypeConfiguration : IEntityTypeConfiguration<PhysicalHealthDesiredFood>
{
    public void Configure(EntityTypeBuilder<PhysicalHealthDesiredFood> userConfiguration)
    {
        userConfiguration.ToTable("PhysicalHealthDesiredFood", TelamingoDbContext.DEFAULT_SCHEMA);

        userConfiguration.HasKey(ct => ct.Id);

        userConfiguration
            .Property(ct => ct.Id)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Id")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.FoodId)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("FoodId")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.PhysicalHealthInformationId)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("PhysicalHealthInformationId")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.Rate)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Rate")
            .HasColumnType("double")
            .IsRequired();

        userConfiguration
            .HasOne(a => a.Food)
            .WithMany(a => a.physicalHealthDesiredFoods)
            .HasForeignKey(a => a.FoodId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        userConfiguration
            .HasOne(a => a.PhysicalHealthInformation)
            .WithMany(a => a.physicalHealthDesiredFoods)
            .HasForeignKey(a => a.PhysicalHealthInformationId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
