using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Telamingo.Infrastructure.Migrations
{
    public partial class DatabaseBaseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Climate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Climate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disorder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disorder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FildOfStudy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FildOfStudy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CulturalInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CulturalInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CulturalInformation_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationalInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalInformation_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnvironmentalInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    ReligiousIssues = table.Column<int>(type: "int", nullable: false),
                    Immigration = table.Column<int>(type: "int", nullable: false),
                    SocialRelationshipMatching = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvironmentalInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnvironmentalInformation_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguageInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageEpidemicRates = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LanguageInformation_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MentalHealthInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    AbilityToVisitFamily = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentalHealthInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MentalHealthInformation_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalHealthInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StatusOfTheTreatmentSystemForSpecificDiseases = table.Column<double>(type: "float", nullable: false),
                    DoctorAccess = table.Column<int>(type: "int", nullable: false),
                    AveragePerCapitaHealthExpenditure = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalHealthInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhysicalHealthInformation_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WelfareInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    AnnualSavingsRates = table.Column<double>(type: "float", nullable: false),
                    RequiredSpecialization = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelfareInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WelfareInformation_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WelfareInformation_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CulturalClimateInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClimateId = table.Column<int>(type: "int", nullable: false),
                    CulturalInformationId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CulturalClimateInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CulturalClimateInformation_Climate_ClimateId",
                        column: x => x.ClimateId,
                        principalTable: "Climate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CulturalClimateInformation_CulturalInformation_CulturalInformationId",
                        column: x => x.CulturalInformationId,
                        principalTable: "CulturalInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CulturalweatherInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CulturalInformationId = table.Column<int>(type: "int", nullable: false),
                    WeatherId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CulturalweatherInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CulturalweatherInformation_CulturalInformation_CulturalInformationId",
                        column: x => x.CulturalInformationId,
                        principalTable: "CulturalInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CulturalweatherInformation_Weather_WeatherId",
                        column: x => x.WeatherId,
                        principalTable: "Weather",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationalInformationTuition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationalInformationId = table.Column<int>(type: "int", nullable: false),
                    FildOfStudyId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalInformationTuition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalInformationTuition_EducationalInformation_EducationalInformationId",
                        column: x => x.EducationalInformationId,
                        principalTable: "EducationalInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationalInformationTuition_FildOfStudy_FildOfStudyId",
                        column: x => x.FildOfStudyId,
                        principalTable: "FildOfStudy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationalProbabilityOfAcceptance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationalInformationId = table.Column<int>(type: "int", nullable: false),
                    FildOfStudyId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalProbabilityOfAcceptance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalProbabilityOfAcceptance_EducationalInformation_EducationalInformationId",
                        column: x => x.EducationalInformationId,
                        principalTable: "EducationalInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationalProbabilityOfAcceptance_FildOfStudy_FildOfStudyId",
                        column: x => x.FildOfStudyId,
                        principalTable: "FildOfStudy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnvironmentalLanguageInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnvironmentalInformationId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvironmentalLanguageInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnvironmentalLanguageInformation_EnvironmentalInformation_EnvironmentalInformationId",
                        column: x => x.EnvironmentalInformationId,
                        principalTable: "EnvironmentalInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnvironmentalLanguageInformation_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MentalHealthPossibilityOfExacerbationOfTheDisorder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MentalHealthInformationId = table.Column<int>(type: "int", nullable: false),
                    DisorderId = table.Column<int>(type: "int", nullable: false),
                    Possibility = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentalHealthPossibilityOfExacerbationOfTheDisorder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MentalHealthPossibilityOfExacerbationOfTheDisorder_Disorder_DisorderId",
                        column: x => x.DisorderId,
                        principalTable: "Disorder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MentalHealthPossibilityOfExacerbationOfTheDisorder_MentalHealthInformation_MentalHealthInformationId",
                        column: x => x.MentalHealthInformationId,
                        principalTable: "MentalHealthInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalHealthDesiredFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    PhysicalHealthInformationId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalHealthDesiredFood", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhysicalHealthDesiredFood_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalHealthDesiredFood_PhysicalHealthInformation_PhysicalHealthInformationId",
                        column: x => x.PhysicalHealthInformationId,
                        principalTable: "PhysicalHealthInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CulturalClimateInformation_ClimateId",
                table: "CulturalClimateInformation",
                column: "ClimateId");

            migrationBuilder.CreateIndex(
                name: "IX_CulturalClimateInformation_CulturalInformationId",
                table: "CulturalClimateInformation",
                column: "CulturalInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_CulturalInformation_CountryId",
                table: "CulturalInformation",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CulturalweatherInformation_CulturalInformationId",
                table: "CulturalweatherInformation",
                column: "CulturalInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_CulturalweatherInformation_WeatherId",
                table: "CulturalweatherInformation",
                column: "WeatherId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalInformation_CountryId",
                table: "EducationalInformation",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalInformationTuition_EducationalInformationId",
                table: "EducationalInformationTuition",
                column: "EducationalInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalInformationTuition_FildOfStudyId",
                table: "EducationalInformationTuition",
                column: "FildOfStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalProbabilityOfAcceptance_EducationalInformationId",
                table: "EducationalProbabilityOfAcceptance",
                column: "EducationalInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalProbabilityOfAcceptance_FildOfStudyId",
                table: "EducationalProbabilityOfAcceptance",
                column: "FildOfStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_EnvironmentalInformation_CountryId",
                table: "EnvironmentalInformation",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_EnvironmentalLanguageInformation_EnvironmentalInformationId",
                table: "EnvironmentalLanguageInformation",
                column: "EnvironmentalInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_EnvironmentalLanguageInformation_LanguageId",
                table: "EnvironmentalLanguageInformation",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageInformation_CountryId",
                table: "LanguageInformation",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_MentalHealthInformation_CountryId",
                table: "MentalHealthInformation",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_MentalHealthPossibilityOfExacerbationOfTheDisorder_DisorderId",
                table: "MentalHealthPossibilityOfExacerbationOfTheDisorder",
                column: "DisorderId");

            migrationBuilder.CreateIndex(
                name: "IX_MentalHealthPossibilityOfExacerbationOfTheDisorder_MentalHealthInformationId",
                table: "MentalHealthPossibilityOfExacerbationOfTheDisorder",
                column: "MentalHealthInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalHealthDesiredFood_FoodId",
                table: "PhysicalHealthDesiredFood",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalHealthDesiredFood_PhysicalHealthInformationId",
                table: "PhysicalHealthDesiredFood",
                column: "PhysicalHealthInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalHealthInformation_CountryId",
                table: "PhysicalHealthInformation",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareInformation_CountryId",
                table: "WelfareInformation",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_WelfareInformation_JobId",
                table: "WelfareInformation",
                column: "JobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CulturalClimateInformation");

            migrationBuilder.DropTable(
                name: "CulturalweatherInformation");

            migrationBuilder.DropTable(
                name: "EducationalInformationTuition");

            migrationBuilder.DropTable(
                name: "EducationalProbabilityOfAcceptance");

            migrationBuilder.DropTable(
                name: "EnvironmentalLanguageInformation");

            migrationBuilder.DropTable(
                name: "LanguageInformation");

            migrationBuilder.DropTable(
                name: "MentalHealthPossibilityOfExacerbationOfTheDisorder");

            migrationBuilder.DropTable(
                name: "PhysicalHealthDesiredFood");

            migrationBuilder.DropTable(
                name: "WelfareInformation");

            migrationBuilder.DropTable(
                name: "Climate");

            migrationBuilder.DropTable(
                name: "CulturalInformation");

            migrationBuilder.DropTable(
                name: "Weather");

            migrationBuilder.DropTable(
                name: "EducationalInformation");

            migrationBuilder.DropTable(
                name: "FildOfStudy");

            migrationBuilder.DropTable(
                name: "EnvironmentalInformation");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Disorder");

            migrationBuilder.DropTable(
                name: "MentalHealthInformation");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "PhysicalHealthInformation");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "dbo");
        }
    }
}
