using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TaskName = table.Column<string>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    Urgent = table.Column<bool>(nullable: false),
                    Important = table.Column<bool>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskID);
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskID", "Category", "Completed", "DueDate", "Important", "TaskName", "Urgent" },
                values: new object[] { 1, "Church", false, new DateTime(2022, 2, 5, 17, 1, 33, 860, DateTimeKind.Local).AddTicks(4202), false, "Read Scriptures", true });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskID", "Category", "Completed", "DueDate", "Important", "TaskName", "Urgent" },
                values: new object[] { 2, "School", false, new DateTime(2022, 2, 5, 17, 1, 33, 871, DateTimeKind.Local).AddTicks(1207), true, "404 Homework", false });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskID", "Category", "Completed", "DueDate", "Important", "TaskName", "Urgent" },
                values: new object[] { 3, "Home", false, new DateTime(2022, 2, 5, 17, 1, 33, 871, DateTimeKind.Local).AddTicks(1294), false, "Clean Dishes", false });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskID", "Category", "Completed", "DueDate", "Important", "TaskName", "Urgent" },
                values: new object[] { 4, "Work", false, new DateTime(2022, 2, 5, 17, 1, 33, 871, DateTimeKind.Local).AddTicks(1301), true, "Submit Time Correction", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
