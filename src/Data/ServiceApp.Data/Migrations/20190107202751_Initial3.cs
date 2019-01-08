using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceApp.Data.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarOwners_AspNetUsers_AutoServiceId",
                table: "CarOwners");

            migrationBuilder.RenameColumn(
                name: "AutoServiceId",
                table: "CarOwners",
                newName: "ServiceAppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_CarOwners_AutoServiceId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarOwners_AspNetUsers_ServiceAppUserId",
                table: "CarOwners");

            migrationBuilder.RenameColumn(
                name: "ServiceAppUserId",
                table: "CarOwners",
                newName: "AutoServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_CarOwners_ServiceAppUserId",
                table: "CarOwners",
                newName: "IX_CarOwners_AutoServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarOwners_AspNetUsers_AutoServiceId",
                table: "CarOwners",
                column: "AutoServiceId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
