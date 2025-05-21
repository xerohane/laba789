using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabaVrode.Migrations
{
    public partial class AddedStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "группы",
                columns: table => new
                {
                    ключ = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    название = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_группы", x => x.ключ);
                });

            migrationBuilder.CreateTable(
                name: "предметы",
                columns: table => new
                {
                    ключ = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    название = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_предметы", x => x.ключ);
                });

            migrationBuilder.CreateTable(
                name: "студенты",
                columns: table => new
                {
                    ключ = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    имя = table.Column<string>(type: "TEXT", nullable: false),
                    фамилия = table.Column<string>(type: "TEXT", nullable: false),
                    отчество = table.Column<string>(type: "TEXT", nullable: true),
                    дата_рождения = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ключ_группы = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_студенты", x => x.ключ);
                    table.ForeignKey(
                        name: "FK_студенты_группы_ключ_группы",
                        column: x => x.ключ_группы,
                        principalTable: "группы",
                        principalColumn: "ключ");
                });

            migrationBuilder.CreateIndex(
                name: "IX_студенты_ключ_группы",
                table: "студенты",
                column: "ключ_группы");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "предметы");

            migrationBuilder.DropTable(
                name: "студенты");

            migrationBuilder.DropTable(
                name: "группы");
        }
    }
}
