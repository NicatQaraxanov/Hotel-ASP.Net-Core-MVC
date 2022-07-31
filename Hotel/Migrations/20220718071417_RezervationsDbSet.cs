using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class RezervationsDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervation_AspNetUsers_UserId1",
                table: "Rezervation");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervation_Rooms_RoomId",
                table: "Rezervation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rezervation",
                table: "Rezervation");

            migrationBuilder.RenameTable(
                name: "Rezervation",
                newName: "Rezervations");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervation_UserId1",
                table: "Rezervations",
                newName: "IX_Rezervations_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervation_RoomId",
                table: "Rezervations",
                newName: "IX_Rezervations_RoomId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId1",
                table: "Rezervations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rezervations",
                table: "Rezervations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervations_AspNetUsers_UserId1",
                table: "Rezervations",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervations_Rooms_RoomId",
                table: "Rezervations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervations_AspNetUsers_UserId1",
                table: "Rezervations");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervations_Rooms_RoomId",
                table: "Rezervations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rezervations",
                table: "Rezervations");

            migrationBuilder.RenameTable(
                name: "Rezervations",
                newName: "Rezervation");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervations_UserId1",
                table: "Rezervation",
                newName: "IX_Rezervation_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervations_RoomId",
                table: "Rezervation",
                newName: "IX_Rezervation_RoomId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId1",
                table: "Rezervation",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rezervation",
                table: "Rezervation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervation_AspNetUsers_UserId1",
                table: "Rezervation",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervation_Rooms_RoomId",
                table: "Rezervation",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
