using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cw8.Migrations
{
    /// <inheritdoc />
    public partial class new1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studia_Students_StudentIdStudent",
                table: "Studia");

            migrationBuilder.RenameColumn(
                name: "StudentIdStudent",
                table: "Studia",
                newName: "IdStudent");

            migrationBuilder.RenameIndex(
                name: "IX_Studia_StudentIdStudent",
                table: "Studia",
                newName: "IX_Studia_IdStudent");

            migrationBuilder.InsertData(
                table: "Studia",
                columns: new[] { "IdStudia", "IdStudent", "Nazwa", "Tryb" },
                values: new object[] { 1, 1, "Dlugie studia", "stacjonarne" });

            migrationBuilder.AddForeignKey(
                name: "FK_Studia_Students_IdStudent",
                table: "Studia",
                column: "IdStudent",
                principalTable: "Students",
                principalColumn: "IdStudent",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studia_Students_IdStudent",
                table: "Studia");

            migrationBuilder.DeleteData(
                table: "Studia",
                keyColumn: "IdStudia",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "IdStudent",
                table: "Studia",
                newName: "StudentIdStudent");

            migrationBuilder.RenameIndex(
                name: "IX_Studia_IdStudent",
                table: "Studia",
                newName: "IX_Studia_StudentIdStudent");

            migrationBuilder.AddForeignKey(
                name: "FK_Studia_Students_StudentIdStudent",
                table: "Studia",
                column: "StudentIdStudent",
                principalTable: "Students",
                principalColumn: "IdStudent",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
