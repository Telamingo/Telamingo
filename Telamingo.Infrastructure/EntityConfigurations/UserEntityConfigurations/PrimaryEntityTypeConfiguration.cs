using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Infrastructure.EntityConfigurations.UserEntityConfigurations
{
    internal class PrimaryEntityTypeConfiguration : IEntityTypeConfiguration<User>
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