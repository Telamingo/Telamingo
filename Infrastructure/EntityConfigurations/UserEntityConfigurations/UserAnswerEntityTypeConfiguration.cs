using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.AggregateModels.UserAggregate;
using Infrastructure;


namespace Telamingo.Infrastructure.EntityConfigurations.UserEntityConfigurations
{
    public class UserAnswerEntityTypeConfiguration : IEntityTypeConfiguration<UserAnswer>
    {
        public void Configure(EntityTypeBuilder<UserAnswer> userConfiguration)
        {
            userConfiguration.ToTable("UserAnwer", TelamingoDbContext.DEFAULT_SCHEMA);

            userConfiguration.HasKey(ct => ct.Id);

            userConfiguration
                .Property(ct => ct.Id)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            //userConfiguration
            //    .Property(ct => ct.Email)
            //    .UsePropertyAccessMode(PropertyAccessMode.Field)
            //    .HasColumnName("Email")
            //    .HasColumnType("nvarchar")
            //    .HasMaxLength(250)
            //    .IsRequired(false);

        }
    }
}