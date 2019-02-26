using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceApp.Data.Migrations
{
    public partial class AddNumenclaturesOneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nomenclatures_AspNetUsers_ServiceId",
                table: "Nomenclatures");

            migrationBuilder.DropIndex(
                name: "IX_Nomenclatures_ServiceId",
                table: "Nomenclatures");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Nomenclatures");

            migrationBuilder.AddColumn<int>(
                name: "NomenclatureId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NomenclatureId",
                table: "AspNetUsers",
                column: "NomenclatureId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Nomenclatures_NomenclatureId",
                table: "AspNetUsers",
                column: "NomenclatureId",
                principalTable: "Nomenclatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Nomenclatures_NomenclatureId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_NomenclatureId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NomenclatureId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ServiceId",
                table: "Nomenclatures",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclatures_ServiceId",
                table: "Nomenclatures",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nomenclatures_AspNetUsers_ServiceId",
                table: "Nomenclatures",
                column: "ServiceId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
