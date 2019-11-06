using Microsoft.EntityFrameworkCore.Migrations;

namespace JeopardyAPI.Migrations
{
    public partial class UpdateDbCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "MultipleChoice",
                keyColumn: "MultipleChoiceId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 9,
                column: "Category",
                value: "General");

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 20,
                column: "Difficulty",
                value: "Hard");

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 29,
                column: "Difficulty",
                value: "Hard");

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 36,
                columns: new[] { "Answer", "Prompt" },
                values: new object[] { "strictly", "C# is a _________-typed compiled language developed by Microsoft." });

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 41,
                column: "Difficulty",
                value: "Medium");

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 43,
                column: "Difficulty",
                value: "Medium");

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 51,
                column: "Category",
                value: "General");

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 53,
                columns: new[] { "Category", "Difficulty" },
                values: new object[] { "General", "Hard" });

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 56,
                column: "Difficulty",
                value: "Medium");

            migrationBuilder.InsertData(
                table: "FillInTheBlank",
                columns: new[] { "FillInTheBlankId", "Answer", "Category", "Difficulty", "Prompt" },
                values: new object[,]
                {
                    { 62, "version control", "Git", "Easy", "Git is a distributed _________ system for tracking changes in source code during software development" },
                    { 63, "commit", "Git", "Easy", "A _________ in Git is a way of saving changes to the permanent history of our project." },
                    { 64, "git remote -v", "Git", "Medium", "This command in Git shows the names and URLs for all of the repositories that the project's Git repository has stored." },
                    { 65, "amend", "Git", "Medium", "To modify the most recent commit message or add an additional file to the most recent commit, we can use the command 'git commit --_________." },
                    { 66, "checkout -b", "Git", "Hard", "The command 'git _________ <new_branch>' will create and switch to a new branch in Git." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 66);

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 9,
                column: "Category",
                value: "JavaScript");

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 20,
                column: "Difficulty",
                value: "Medium");

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 29,
                column: "Difficulty",
                value: "Medium");

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 36,
                columns: new[] { "Answer", "Prompt" },
                values: new object[] { "c#", "_________ is a strictly-typed compiled language developed by Microsoft." });

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 41,
                column: "Difficulty",
                value: "Easy");

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 43,
                column: "Difficulty",
                value: "Hard");

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 51,
                column: "Category",
                value: "C#");

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 53,
                columns: new[] { "Category", "Difficulty" },
                values: new object[] { "C#", "Medium" });

            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 56,
                column: "Difficulty",
                value: "Hard");

            migrationBuilder.InsertData(
                table: "FillInTheBlank",
                columns: new[] { "FillInTheBlankId", "Answer", "Category", "Difficulty", "Prompt" },
                values: new object[] { 57, "try/catch", "Testing", "Hard", "We can manually add code to tell our application how to handle exceptions by using _________/_________ blocks." });

            migrationBuilder.InsertData(
                table: "MultipleChoice",
                columns: new[] { "MultipleChoiceId", "Answer", "Category", "Difficulty", "Prompt", "Wrong1", "Wrong2", "Wrong3" },
                values: new object[] { 9, "", "", "", "", "", "", "" });
        }
    }
}
