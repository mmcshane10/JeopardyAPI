using Microsoft.EntityFrameworkCore.Migrations;

namespace JeopardyAPI.Migrations
{
    public partial class addSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FillInTheBlank",
                columns: new[] { "FillInTheBlankId", "Answer", "Category", "Difficulty", "Prompt" },
                values: new object[,]
                {
                    { 1, "operators", "JavaScript", "Easy", "+, -, *, /, and % are called _________. They are special characters that indicate an action to be performed." },
                    { 2, "modulo", "JavaScript", "Easy", "9 % 2; returns the remainder of 9 divided by 2. % is called _________." },
                    { 3, "arguments", "JavaScript", "Easy", "Some methods take one or more _________ that provide the method with additional information to help it perform its action." },
                    { 4, "DOM", "JavaScript", "Easy", "The _________ is your browser's interpretation of the HTML it reads." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 4);
        }
    }
}
