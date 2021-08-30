using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Command.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mark = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Birthday", "Mark", "Name" },
                values: new object[] { 1, "Cong ty Hoa Nhan", new DateTime(1990, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5m, "Diem khung" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Birthday", "Mark", "Name" },
                values: new object[] { 2, "Ly Tu Tan", new DateTime(1990, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "An khong khung" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Birthday", "Mark", "Name" },
                values: new object[] { 3, "Go Vap", new DateTime(1991, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6m, "Vinh dien" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
