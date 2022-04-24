using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Telamingo.Infrastructure.EntityConfigurations.CountryEntityConfigurations;

public class EnvironmantalInformationEntityTypeConfiguration : IEntityTypeConfiguration<EnvironmantalInformation>
{
    public void Configure(EntityTypeBuilder<EnvironmantalInformation> userConfiguration)
    {
        userConfiguration.ToTable("EnvironmantalInformation", TelamingoDbContext.DEFAULT_SCHEMA);

        userConfiguration.HasKey(ct => ct.Id);

        userConfiguration
            .Property(ct => ct.Id)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Id")
            .HasColumnType("int")
            .IsRequired();

        //userConfiguration
        //    .Property(ct => ct.Name)
        //    .UsePropertyAccessMode(PropertyAccessMode.Field)
        //    .HasColumnName("Name")
        //    .HasColumnType("nvarchar")
        //    .HasMaxLength(250)
        //    .IsRequired();
    }
}
