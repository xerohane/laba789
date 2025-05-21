using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LabaVrode.Migrations
{
    /// <inheritdoc />
    public partial class popa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Пользователи",
                columns: table => new
                {
                    Ключ = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Имя_пользователя = table.Column<string>(type: "TEXT", nullable: false),
                    Пароль = table.Column<string>(type: "TEXT", nullable: false),
                    Является_Администратором = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Пользователи", x => x.Ключ);
                });

            migrationBuilder.InsertData(
                table: "Пользователи",
                columns: new[] { "Ключ", "Имя_пользователя", "Пароль", "Является_Администратором" },
                values: new object[,]
                {
                    { 1, "admin", "123", true },
                    { 2, "user1", "321", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Пользователи");
        }
    }
}
