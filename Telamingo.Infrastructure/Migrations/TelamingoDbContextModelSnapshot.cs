﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Telamingo.Infrastructure;

#nullable disable

namespace Telamingo.Infrastructure.Migrations
{
    [DbContext(typeof(TelamingoDbContext))]
    partial class TelamingoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.AdminAggregate.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Password");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleId");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.ToTable("Admin", "dbo");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.AdminAggregate.AdminRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Name");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int")
                        .HasColumnName("Role");

                    b.HasKey("Id");

                    b.ToTable("AdminRole", "dbo");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Country", "dbo");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.CulturalClimateInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClimateId")
                        .HasColumnType("int");

                    b.Property<int>("CulturalInformationId")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ClimateId");

                    b.HasIndex("CulturalInformationId");

                    b.ToTable("CulturalClimateInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.CulturalInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("CulturalInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.CulturalweatherInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CulturalInformationId")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("WeatherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CulturalInformationId");

                    b.HasIndex("WeatherId");

                    b.ToTable("CulturalweatherInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.EducationalInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("EducationalInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.EducationalInformationTuition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EducationalInformationId")
                        .HasColumnType("int");

                    b.Property<int>("FildOfStudyId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EducationalInformationId");

                    b.HasIndex("FildOfStudyId");

                    b.ToTable("EducationalInformationTuition");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.EducationalProbabilityOfAcceptance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EducationalInformationId")
                        .HasColumnType("int");

                    b.Property<int>("FildOfStudyId")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EducationalInformationId");

                    b.HasIndex("FildOfStudyId");

                    b.ToTable("EducationalProbabilityOfAcceptance");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.EnvironmentalInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("Immigration")
                        .HasColumnType("int");

                    b.Property<int>("ReligiousIssues")
                        .HasColumnType("int");

                    b.Property<int>("SocialRelationshipMatching")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("EnvironmentalInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.EnvironmentalLanguageInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EnvironmentalInformationId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EnvironmentalInformationId");

                    b.HasIndex("LanguageId");

                    b.ToTable("EnvironmentalLanguageInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.LanguageInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<double>("LanguageEpidemicRates")
                        .HasColumnType("float");

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("LanguageInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.MentalHealthInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AbilityToVisitFamily")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("MentalHealthInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.MentalHealthPossibilityOfExacerbationOfTheDisorder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DisorderId")
                        .HasColumnType("int");

                    b.Property<int>("MentalHealthInformationId")
                        .HasColumnType("int");

                    b.Property<double>("Possibility")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DisorderId");

                    b.HasIndex("MentalHealthInformationId");

                    b.ToTable("MentalHealthPossibilityOfExacerbationOfTheDisorder");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.PhysicalHealthDesiredFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int>("PhysicalHealthInformationId")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("PhysicalHealthInformationId");

                    b.ToTable("PhysicalHealthDesiredFood");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.PhysicalHealthInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("AveragePerCapitaHealthExpenditure")
                        .HasColumnType("float");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorAccess")
                        .HasColumnType("int");

                    b.Property<double>("StatusOfTheTreatmentSystemForSpecificDiseases")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("PhysicalHealthInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.WelfareInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("AnnualSavingsRates")
                        .HasColumnType("float");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<double>("RequiredSpecialization")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("JobId");

                    b.ToTable("WelfareInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.SharedAggregate.Climate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Climate");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.SharedAggregate.Disorder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Disorder");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.SharedAggregate.FildOfStudy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FildOfStudy");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.SharedAggregate.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.SharedAggregate.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.SharedAggregate.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.SharedAggregate.Weather", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Weather");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.UserAggregate.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Email");

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Password");

                    b.HasKey("Id");

                    b.ToTable("User", "dbo");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.CulturalClimateInformation", b =>
                {
                    b.HasOne("Telamingo.Domain.AggregateModels.SharedAggregate.Climate", "Climate")
                        .WithMany("culturalClimateInformation")
                        .HasForeignKey("ClimateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Telamingo.Domain.AggregateModels.CountryAggregate.CulturalInformation", "CulturalInformation")
                        .WithMany("culturalClimateInformation")
                        .HasForeignKey("CulturalInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Climate");

                    b.Navigation("CulturalInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.CulturalInformation", b =>
                {
                    b.HasOne("Telamingo.Domain.AggregateModels.CountryAggregate.Country", "Country")
                        .WithMany("culturalInformation")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.CulturalweatherInformation", b =>
                {
                    b.HasOne("Telamingo.Domain.AggregateModels.CountryAggregate.CulturalInformation", "CulturalInformation")
                        .WithMany("culturalweatherInformation")
                        .HasForeignKey("CulturalInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Telamingo.Domain.AggregateModels.SharedAggregate.Weather", "Weather")
                        .WithMany("culturalweatherInformation")
                        .HasForeignKey("WeatherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CulturalInformation");

                    b.Navigation("Weather");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.EducationalInformation", b =>
                {
                    b.HasOne("Telamingo.Domain.AggregateModels.CountryAggregate.Country", "Country")
                        .WithMany("educationalInformation")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.EducationalInformationTuition", b =>
                {
                    b.HasOne("Telamingo.Domain.AggregateModels.CountryAggregate.EducationalInformation", "EducationalInformation")
                        .WithMany("educationalInformationTuitions")
                        .HasForeignKey("EducationalInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Telamingo.Domain.AggregateModels.SharedAggregate.FildOfStudy", "FildOfStudy")
                        .WithMany("educationalInformationTuitions")
                        .HasForeignKey("FildOfStudyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EducationalInformation");

                    b.Navigation("FildOfStudy");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.EducationalProbabilityOfAcceptance", b =>
                {
                    b.HasOne("Telamingo.Domain.AggregateModels.CountryAggregate.EducationalInformation", "EducationalInformation")
                        .WithMany("educationalProbabilityOfAcceptances")
                        .HasForeignKey("EducationalInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Telamingo.Domain.AggregateModels.SharedAggregate.FildOfStudy", "FildOfStudy")
                        .WithMany("educationalProbabilityOfAcceptances")
                        .HasForeignKey("FildOfStudyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EducationalInformation");

                    b.Navigation("FildOfStudy");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.EnvironmentalInformation", b =>
                {
                    b.HasOne("Telamingo.Domain.AggregateModels.CountryAggregate.Country", "Country")
                        .WithMany("environmentalInformation")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.EnvironmentalLanguageInformation", b =>
                {
                    b.HasOne("Telamingo.Domain.AggregateModels.CountryAggregate.EnvironmentalInformation", "EnvironmentalInformation")
                        .WithMany("environmentalLanguageInformation")
                        .HasForeignKey("EnvironmentalInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Telamingo.Domain.AggregateModels.SharedAggregate.Language", "Language")
                        .WithMany("environmentalLanguageInformation")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EnvironmentalInformation");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.LanguageInformation", b =>
                {
                    b.HasOne("Telamingo.Domain.AggregateModels.CountryAggregate.Country", "Country")
                        .WithMany("languageInformation")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.MentalHealthInformation", b =>
                {
                    b.HasOne("Telamingo.Domain.AggregateModels.CountryAggregate.Country", "Country")
                        .WithMany("mentalHealthInformation")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.MentalHealthPossibilityOfExacerbationOfTheDisorder", b =>
                {
                    b.HasOne("Telamingo.Domain.AggregateModels.SharedAggregate.Disorder", "Disorder")
                        .WithMany("mentalHealthPossibilityOfExacerbationOfTheDisorders")
                        .HasForeignKey("DisorderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Telamingo.Domain.AggregateModels.CountryAggregate.MentalHealthInformation", "MentalHealthInformation")
                        .WithMany("mentalHealthPossibilityOfExacerbationOfTheDisorders")
                        .HasForeignKey("MentalHealthInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disorder");

                    b.Navigation("MentalHealthInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.PhysicalHealthDesiredFood", b =>
                {
                    b.HasOne("Telamingo.Domain.AggregateModels.SharedAggregate.Food", "Food")
                        .WithMany("physicalHealthDesiredFoods")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Telamingo.Domain.AggregateModels.CountryAggregate.PhysicalHealthInformation", "PhysicalHealthInformation")
                        .WithMany("physicalHealthDesiredFoods")
                        .HasForeignKey("PhysicalHealthInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("PhysicalHealthInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.PhysicalHealthInformation", b =>
                {
                    b.HasOne("Telamingo.Domain.AggregateModels.CountryAggregate.Country", "Country")
                        .WithMany("PhysicalHealthInformation")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.WelfareInformation", b =>
                {
                    b.HasOne("Telamingo.Domain.AggregateModels.CountryAggregate.Country", "Country")
                        .WithMany("welfareInformation")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Telamingo.Domain.AggregateModels.SharedAggregate.Job", "Job")
                        .WithMany("welfareInformation")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.Country", b =>
                {
                    b.Navigation("PhysicalHealthInformation");

                    b.Navigation("culturalInformation");

                    b.Navigation("educationalInformation");

                    b.Navigation("environmentalInformation");

                    b.Navigation("languageInformation");

                    b.Navigation("mentalHealthInformation");

                    b.Navigation("welfareInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.CulturalInformation", b =>
                {
                    b.Navigation("culturalClimateInformation");

                    b.Navigation("culturalweatherInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.EducationalInformation", b =>
                {
                    b.Navigation("educationalInformationTuitions");

                    b.Navigation("educationalProbabilityOfAcceptances");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.EnvironmentalInformation", b =>
                {
                    b.Navigation("environmentalLanguageInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.MentalHealthInformation", b =>
                {
                    b.Navigation("mentalHealthPossibilityOfExacerbationOfTheDisorders");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.CountryAggregate.PhysicalHealthInformation", b =>
                {
                    b.Navigation("physicalHealthDesiredFoods");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.SharedAggregate.Climate", b =>
                {
                    b.Navigation("culturalClimateInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.SharedAggregate.Disorder", b =>
                {
                    b.Navigation("mentalHealthPossibilityOfExacerbationOfTheDisorders");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.SharedAggregate.FildOfStudy", b =>
                {
                    b.Navigation("educationalInformationTuitions");

                    b.Navigation("educationalProbabilityOfAcceptances");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.SharedAggregate.Food", b =>
                {
                    b.Navigation("physicalHealthDesiredFoods");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.SharedAggregate.Job", b =>
                {
                    b.Navigation("welfareInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.SharedAggregate.Language", b =>
                {
                    b.Navigation("environmentalLanguageInformation");
                });

            modelBuilder.Entity("Telamingo.Domain.AggregateModels.SharedAggregate.Weather", b =>
                {
                    b.Navigation("culturalweatherInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
