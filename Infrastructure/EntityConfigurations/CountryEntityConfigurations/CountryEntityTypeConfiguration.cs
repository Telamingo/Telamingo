using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.AggregateModels.CountryAggregate;

namespace Infrastructure.EntityConfigurations.CountryEntityConfigurations
{
    public class CountryEntityTypeConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> userConfiguration)
        {
            userConfiguration.ToTable("Country", TelamingoDbContext.DEFAULT_SCHEMA);

            userConfiguration.HasKey(ct => ct.Id);

            userConfiguration
                .Property(ct => ct.Id)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Name)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}