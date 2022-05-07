using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.AggregateModels.UserAggregate;

namespace Infrastructure.EntityConfigurations.UserEntityConfigurations
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> userConfiguration)
        {
            userConfiguration.ToTable("User", TelamingoDbContext.DEFAULT_SCHEMA);

            userConfiguration.HasKey(ct => ct.Id);

            userConfiguration
                .Property(ct => ct.Id)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.Email)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Email")
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired(false);

            userConfiguration
                .Property(ct => ct.Password)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Password")
                .HasColumnType("nvarchar")
                .HasMaxLength(20)
                .IsRequired(false);
        }
    }
}