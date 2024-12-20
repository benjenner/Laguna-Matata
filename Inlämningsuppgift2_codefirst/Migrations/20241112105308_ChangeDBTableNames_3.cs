using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inlämningsuppgift2_codefirst.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDBTableNames_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomTypes_RoomTypeRoomID",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "RoomID",
                table: "RoomTypes",
                newName: "RoomTypeID");

            migrationBuilder.RenameColumn(
                name: "RoomTypeRoomID",
                table: "Rooms",
                newName: "RoomTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_RoomTypeRoomID",
                table: "Rooms",
                newName: "IX_Rooms_RoomTypeID");

            migrationBuilder.AlterColumn<string>(
                name: "RoomTypeName",
                table: "RoomTypes",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomTypes_RoomTypeID",
                table: "Rooms",
                column: "RoomTypeID",
                principalTable: "RoomTypes",
                principalColumn: "RoomTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomTypes_RoomTypeID",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "RoomTypeID",
                table: "RoomTypes",
                newName: "RoomID");

            migrationBuilder.RenameColumn(
                name: "RoomTypeID",
                table: "Rooms",
                newName: "RoomTypeRoomID");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_RoomTypeID",
                table: "Rooms",
                newName: "IX_Rooms_RoomTypeRoomID");

            migrationBuilder.AlterColumn<string>(
                name: "RoomTypeName",
                table: "RoomTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomTypes_RoomTypeRoomID",
                table: "Rooms",
                column: "RoomTypeRoomID",
                principalTable: "RoomTypes",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
