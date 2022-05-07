using Domain.AggregateModels.QuestionAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityConfigurations.QuestionEntityConfigurations
{
    public class QuestionEntityTypeConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> userConfiguration)
        {
            userConfiguration.ToTable("Question", TelamingoDbContext.DEFAULT_SCHEMA);

            userConfiguration.HasKey(ct => ct.Id);

            userConfiguration
                .Property(ct => ct.Id)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.AnswerType)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("AnswerType")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.CategoryId)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("CategoryId")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.ContextEn)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("ContextEn")
                .HasColumnType("nvarchar")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.MultiSelect)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("MultiSelect")
                .HasColumnType("bit")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.ContextFa)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("ContextFa")
                .HasColumnType("nvarchar");
        }
    }
}