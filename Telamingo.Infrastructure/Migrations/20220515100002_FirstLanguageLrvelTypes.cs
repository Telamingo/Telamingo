using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Telamingo.Infrastructure.Migrations
{
    public partial class FirstLanguageLrvelTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "First_LangLevel",
                schema: "dbo",
                table: "Primary",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "First_LangLevel",
                schema: "dbo",
                table: "Primary",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);
        }
    }
}
