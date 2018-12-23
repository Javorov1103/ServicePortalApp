using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceApp.Data.Migrations
{
    public partial class CarOwnerUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarOwners_AspNetUsers_ServiceAppUserId",
                table: "CarOwners");

            migrationBuilder.RenameColumn(
                name: "ServiceAppUserId",
                table: "CarOwners",
                newName: "ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_CarOwners_ServiceAppUserId",
                table: "CarOwners",
                newName: "IX_CarOwners_ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarOwners_AspNetUsers_ServiceId",
                table: "CarOwners",
                column: "ServiceId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarOwners_AspNetUsers_ServiceId",
                table: "CarOwners");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "CarOwners",
                newName: "ServiceAppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_CarOwners_ServiceId",
                table: "CarOwners",
                newName: "IX_CarOwners_ServiceAppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarOwners_AspNetUsers_ServiceAppUserId",
                table: "CarOwners",
                column: "ServiceAppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
