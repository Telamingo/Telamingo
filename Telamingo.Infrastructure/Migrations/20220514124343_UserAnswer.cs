using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Telamingo.Infrastructure.Migrations
{
    public partial class UserAnswer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAnwer",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnwer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cultural",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAnswerId = table.Column<int>(type: "int", nullable: false),
                    ReligiousMatters = table.Column<int>(type: "int", nullable: false),
                    NationalMatters = table.Column<bool>(type: "bit", nullable: false),
                    IfYesHowMuch = table.Column<int>(type: "int", nullable: false),
                    ImmigrantCommunity = table.Column<int>(type: "int", nullable: false),
                    Similarity = table.Column<int>(type: "int", nullable: false),
                    UserAnswerId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cultural", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cultural_UserAnwer_UserAnswerId",
                        column: x => x.UserAnswerId,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cultural_UserAnwer_UserAnswerId1",
                        column: x => x.UserAnswerId1,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Economy",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAnswerId = table.Column<int>(type: "int", nullable: false),
                    CurrentJob = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CurrentSaving = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PreferredJob = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PreferredSaving = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UserAnswerId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Economy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Economy_UserAnwer_UserAnswerId",
                        column: x => x.UserAnswerId,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Economy_UserAnwer_UserAnswerId1",
                        column: x => x.UserAnswerId1,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Environmental",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAnswerId = table.Column<int>(type: "int", nullable: false),
                    SpecialWeather = table.Column<bool>(type: "bit", nullable: false),
                    Cloudy = table.Column<int>(type: "int", nullable: false),
                    Snowy = table.Column<int>(type: "int", nullable: false),
                    Sunny = table.Column<int>(name: "Sunny ", type: "int", nullable: false),
                    Moderate = table.Column<int>(type: "int", nullable: false),
                    UnusualDaytime = table.Column<int>(type: "int", nullable: false),
                    UserAnswerId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Environmental", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Environmental_UserAnwer_UserAnswerId",
                        column: x => x.UserAnswerId,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Environmental_UserAnwer_UserAnswerId1",
                        column: x => x.UserAnswerId1,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Mental",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAnswerId = table.Column<int>(type: "int", nullable: false),
                    MentalIll = table.Column<bool>(type: "bit", nullable: false),
                    First = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Secend = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Third = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FamilyVisit = table.Column<int>(type: "int", nullable: false),
                    UserAnswerId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mental", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mental_UserAnwer_UserAnswerId",
                        column: x => x.UserAnswerId,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mental_UserAnwer_UserAnswerId1",
                        column: x => x.UserAnswerId1,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MostImportants",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAnswerId = table.Column<int>(type: "int", nullable: false),
                    FirstProblem = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SecendProblem = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UserAnswerId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MostImportants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MostImportants_UserAnwer_UserAnswerId",
                        column: x => x.UserAnswerId,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MostImportants_UserAnwer_UserAnswerId1",
                        column: x => x.UserAnswerId1,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Physical",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAnswerId = table.Column<int>(type: "int", nullable: false),
                    MedicineNeed = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SpecialIll = table.Column<bool>(type: "bit", nullable: false),
                    First = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Secend = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Third = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MedicineCost = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SpecialFood = table.Column<int>(type: "int", nullable: false),
                    TraditionalFood = table.Column<int>(type: "int", nullable: false),
                    FastFood = table.Column<int>(type: "int", nullable: false),
                    Vegeterian = table.Column<int>(type: "int", nullable: false),
                    UserAnswerId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Physical", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Physical_UserAnwer_UserAnswerId",
                        column: x => x.UserAnswerId,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Physical_UserAnwer_UserAnswerId1",
                        column: x => x.UserAnswerId1,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Primary",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAnswerId = table.Column<int>(type: "int", nullable: false),
                    User_Destination = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Preferred_Visa_Type = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    First_Lang = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Second_Lang = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Second_LangLevel = table.Column<int>(type: "int", nullable: false),
                    Third_Lang = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Third_LangLevel = table.Column<int>(type: "int", nullable: false),
                    Marriage = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfCompanions = table.Column<int>(type: "int", nullable: false),
                    UserAnswerId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Primary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Primary_UserAnwer_UserAnswerId",
                        column: x => x.UserAnswerId,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Primary_UserAnwer_UserAnswerId1",
                        column: x => x.UserAnswerId1,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserInformation",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAnswerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserAnswerId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInformation_UserAnwer_UserAnswerId",
                        column: x => x.UserAnswerId,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInformation_UserAnwer_UserAnswerId1",
                        column: x => x.UserAnswerId1,
                        principalSchema: "dbo",
                        principalTable: "UserAnwer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Companions",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    First_Lang = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Second_Lang = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Third_Lang = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Relationship = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PrimaryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companions_Primary_PrimaryId",
                        column: x => x.PrimaryId,
                        principalSchema: "dbo",
                        principalTable: "Primary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companions_PrimaryId",
                schema: "dbo",
                table: "Companions",
                column: "PrimaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cultural_UserAnswerId",
                schema: "dbo",
                table: "Cultural",
                column: "UserAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cultural_UserAnswerId1",
                schema: "dbo",
                table: "Cultural",
                column: "UserAnswerId1",
                unique: true,
                filter: "[UserAnswerId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Economy_UserAnswerId",
                schema: "dbo",
                table: "Economy",
                column: "UserAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Economy_UserAnswerId1",
                schema: "dbo",
                table: "Economy",
                column: "UserAnswerId1",
                unique: true,
                filter: "[UserAnswerId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Environmental_UserAnswerId",
                schema: "dbo",
                table: "Environmental",
                column: "UserAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Environmental_UserAnswerId1",
                schema: "dbo",
                table: "Environmental",
                column: "UserAnswerId1",
                unique: true,
                filter: "[UserAnswerId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Mental_UserAnswerId",
                schema: "dbo",
                table: "Mental",
                column: "UserAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Mental_UserAnswerId1",
                schema: "dbo",
                table: "Mental",
                column: "UserAnswerId1",
                unique: true,
                filter: "[UserAnswerId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MostImportants_UserAnswerId",
                schema: "dbo",
                table: "MostImportants",
                column: "UserAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_MostImportants_UserAnswerId1",
                schema: "dbo",
                table: "MostImportants",
                column: "UserAnswerId1",
                unique: true,
                filter: "[UserAnswerId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Physical_UserAnswerId",
                schema: "dbo",
                table: "Physical",
                column: "UserAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Physical_UserAnswerId1",
                schema: "dbo",
                table: "Physical",
                column: "UserAnswerId1",
                unique: true,
                filter: "[UserAnswerId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Primary_UserAnswerId",
                schema: "dbo",
                table: "Primary",
                column: "UserAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Primary_UserAnswerId1",
                schema: "dbo",
                table: "Primary",
                column: "UserAnswerId1",
                unique: true,
                filter: "[UserAnswerId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformation_UserAnswerId",
                schema: "dbo",
                table: "UserInformation",
                column: "UserAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformation_UserAnswerId1",
                schema: "dbo",
                table: "UserInformation",
                column: "UserAnswerId1",
                unique: true,
                filter: "[UserAnswerId1] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companions",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Cultural",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Economy",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Environmental",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Mental",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MostImportants",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Physical",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserInformation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Primary",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserAnwer",
                schema: "dbo");
        }
    }
}
