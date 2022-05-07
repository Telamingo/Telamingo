using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telamingo.Domain.AggregateModels.QuestionAggregate;

namespace Telamingo.Infrastructure.EntityConfigurations.QuestionEntityConfigurations
{
    public class AnswerEntityTypeConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> userConfiguration)
        {
            userConfiguration.ToTable("Answer", TelamingoDbContext.DEFAULT_SCHEMA);

            userConfiguration.HasKey(ct => ct.Id);

            userConfiguration
                .Property(ct => ct.Id)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.QuestionId)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("QuestionId")
                .HasColumnType("int")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.TextEn)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("TextEn")
                .HasColumnType("nvarchar")
                .IsRequired();

            userConfiguration
                .Property(ct => ct.TextFa)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("TextFa")
                .HasColumnType("nvarchar");

            userConfiguration
                .HasOne(a => a.Question)
                .WithMany(a => a.Answers)
                .HasForeignKey(a => a.QuestionId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}