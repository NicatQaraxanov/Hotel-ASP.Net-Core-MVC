using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class RezervationStringId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervations_AspNetUsers_UserId1",
                table: "Rezervations");

            migrationBuilder.DropIndex(
                name: "IX_Rezervations_UserId1",
                table: "Rezervations");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Rezervations");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Rezervations",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervations_UserId",
                table: "Rezervations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervations_AspNetUsers_UserId",
                table: "Rezervations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervations_AspNetUsers_UserId",
                table: "Rezervations");

            migrationBuilder.DropIndex(
                name: "IX_Rezervations_UserId",
                table: "Rezervations");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Rezervations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Rezervations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rezervations_UserId1",
                table: "Rezervations",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervations_AspNetUsers_UserId1",
                table: "Rezervations",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
