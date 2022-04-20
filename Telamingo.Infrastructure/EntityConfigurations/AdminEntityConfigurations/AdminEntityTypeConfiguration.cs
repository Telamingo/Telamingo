using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telamingo.Domain.AggregateModels.AdminAggregate;

namespace Telamingo.Infrastructure.EntityConfigurations.AdminEntityConfigurations;

public class AdminEntityTypeConfiguration : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> userConfiguration)
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
            .Property(ct => ct.RoleId)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("RoleId")
            .HasColumnType("int")
            .IsRequired();

        userConfiguration
            .Property(ct => ct.Name)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Name")
            .HasColumnType("nvarchar")
            .HasMaxLength(250)
            .IsRequired(false);

        userConfiguration
            .Property(ct => ct.UserName)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("UserName")
            .HasColumnType("nvarchar")
            .HasMaxLength(250)
            .IsRequired();

        userConfiguration
            .Property(ct => ct.Password)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Password")
            .HasColumnType("nvarchar")
            .HasMaxLength(20)
            .IsRequired();
    }
}
