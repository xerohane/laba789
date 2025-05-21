using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabaVrode.Migrations
{
    public partial class MarksAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "оценки",
                columns: table => new
                {
                    ключ = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ключ_студента = table.Column<int>(type: "INTEGER", nullable: false),
                    ключ_предмета = table.Column<int>(type: "INTEGER", nullable: false),
                    балл = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_оценки", x => x.ключ);
                    table.ForeignKey(
                        name: "FK_оценки_предметы_ключ_предмета",
                        column: x => x.ключ_предмета,
                        principalTable: "предметы",
                        principalColumn: "ключ",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_оценки_студенты_ключ_студента",
                        column: x => x.ключ_студента,
                        principalTable: "студенты",
                        principalColumn: "ключ",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_оценки_ключ_предмета",
                table: "оценки",
                column: "ключ_предмета");

            migrationBuilder.CreateIndex(
                name: "IX_оценки_ключ_студента",
                table: "оценки",
                column: "ключ_студента");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "оценки");
        }
    }
}
