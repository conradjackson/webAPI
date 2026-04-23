using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddFrequencyToHobby : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Instructor",
                table: "StudentInfos");

            migrationBuilder.AddColumn<string>(
                name: "FrequencyPerWeek",
                table: "Hobbies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 1,
                column: "FrequencyPerWeek",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 2,
                column: "FrequencyPerWeek",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 3,
                column: "FrequencyPerWeek",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 4,
                column: "FrequencyPerWeek",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 5,
                column: "FrequencyPerWeek",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FrequencyPerWeek",
                table: "Hobbies");

            migrationBuilder.AddColumn<string>(
                name: "Instructor",
                table: "StudentInfos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "StudentInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Instructor",
                value: "Dr. Smith");

            migrationBuilder.UpdateData(
                table: "StudentInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Instructor",
                value: "Dr. Jones");

            migrationBuilder.UpdateData(
                table: "StudentInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Instructor",
                value: "Prof. Lee");

            migrationBuilder.UpdateData(
                table: "StudentInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Instructor",
                value: "Dr. Patel");

            migrationBuilder.UpdateData(
                table: "StudentInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Instructor",
                value: "Dr. Smith");
        }
    }
}
