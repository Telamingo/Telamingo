using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telamingo.Domain.AggregateModels.AdminAggregate;

namespace Telamingo.Infrastructure.EntityConfigurations.AdminEntityConfigurations;

public class AdminRoleEntityTypeConfiguration : IEntityTypeConfiguration<AdminRole>
{
    public void Configure(EntityTypeBuilder<AdminRole> userConfiguration)
    {
        userConfiguration.ToTable("AdminRole", TelamingoDbContext.DEFAULT_SCHEMA);

        userConfiguration.HasKey(ct => ct.Id);

        userConfiguration
            .Property(ct => ct.Id)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Id")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.Role)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Role")
            .HasColumnType("nvarchar")
            .HasMaxLength(250)
            .IsRequired();
    }
}
