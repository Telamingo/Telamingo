using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Telamingo.Infrastructure.Migrations
{
    public partial class UserAnswerFixTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Primary",
                newName: "First_LangLevel",
                schema: "dbo");

            migrationBuilder.RenameColumn(
                name: "Marriage",
                table: "Primary",
                newName: "MaritalStatus",
                schema: "dbo");

            migrationBuilder.AlterColumn<string>(
                name: "MaritalStatus",
                schema: "dbo",
                table: "Primary",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Third_LangLevel",
                schema: "dbo",
                table: "Primary",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Second_LangLevel",
                schema: "dbo",
                table: "Primary",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Age",
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
            migrationBuilder.RenameColumn(
                name: "First_LangLevel",
                table: "Primary",
                newName: "Level",
                schema: "dbo");

            migrationBuilder.RenameColumn(
                name: "MaritalStatus",
                table: "Primary",
                newName: "Marriage",
                schema: "dbo");

            migrationBuilder.AlterColumn<int>(
                name: "Third_LangLevel",
                schema: "dbo",
                table: "Primary",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Second_LangLevel",
                schema: "dbo",
                table: "Primary",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
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
