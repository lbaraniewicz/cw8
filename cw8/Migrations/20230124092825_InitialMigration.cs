using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cw8.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NrIndeksu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RokStudiow = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.IdStudent);
                });

            migrationBuilder.CreateTable(
                name: "Studia",
                columns: table => new
                {
                    IdStudia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Tryb = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StudentIdStudent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studia", x => x.IdStudia);
                    table.ForeignKey(
                        name: "FK_Studia_Students_StudentIdStudent",
                        column: x => x.StudentIdStudent,
                        principalTable: "Students",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Studia_StudentIdStudent",
                table: "Studia",
                column: "StudentIdStudent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studia");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
