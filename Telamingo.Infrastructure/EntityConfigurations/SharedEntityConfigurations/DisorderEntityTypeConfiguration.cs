using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telamingo.Domain.AggregateModels.SharedAggregate;

namespace Telamingo.Infrastructure.EntityConfigurations.SharedEntityConfigurations;

public class DisorderEntityTypeConfiguration : IEntityTypeConfiguration<Disorder>
{
    public void Configure(EntityTypeBuilder<Disorder> userConfiguration)
    {
        userConfiguration.ToTable("Admin", TelamingoDbContext.DEFAULT_SCHEMA);

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
            .IsRequired(false);
    }
}
