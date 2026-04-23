using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    CollegeProgram = table.Column<string>(type: "TEXT", nullable: false),
                    Instructor = table.Column<string>(type: "TEXT", nullable: false),
                    YearInProgram = table.Column<string>(type: "TEXT", nullable: false),
                    FavoriteMajorCourse = table.Column<string>(type: "TEXT", nullable: false),
                    FavoriteElectiveCourse = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInfos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "Category", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Outdoor", "Scaling natural and artificial rock faces", "Rock Climbing" },
                    { 2, "Creative", "Acrylic and watercolor painting", "Painting" },
                    { 3, "Strategy", "Competitive and casual chess play", "Chess" },
                    { 4, "Outdoor", "Trail hiking and backpacking", "Hiking" },
                    { 5, "Music", "Acoustic and electric guitar", "Guitar" }
                });

            migrationBuilder.InsertData(
                table: "StudentInfos",
                columns: new[] { "Id", "CollegeProgram", "FavoriteElectiveCourse", "FavoriteMajorCourse", "FullName", "Instructor", "YearInProgram" },
                values: new object[,]
                {
                    { 1, "Information Technology", "Digital Photography", "Web Development", "Jane Doe", "Dr. Smith", "Junior" },
                    { 2, "Computer Science", "Music Theory", "Data Structures", "John Smith", "Dr. Jones", "Sophomore" },
                    { 3, "Cybersecurity", "Art History", "Network Security", "Maria Garcia", "Prof. Lee", "Freshman" },
                    { 4, "Software Engineering", "Philosophy", "System Design", "Alex Johnson", "Dr. Patel", "Senior" },
                    { 5, "Information Technology", "Psychology", "Database Systems", "Sam Williams", "Dr. Smith", "Junior" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "StudentInfos");
        }
    }
}
