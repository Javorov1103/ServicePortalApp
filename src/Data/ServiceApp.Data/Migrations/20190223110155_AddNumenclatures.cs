using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceApp.Data.Migrations
{
    public partial class AddNumenclatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NomenclatureId",
                table: "Parts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Nomenclatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ServiceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nomenclatures_AspNetUsers_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parts_NomenclatureId",
                table: "Parts",
                column: "NomenclatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclatures_ServiceId",
                table: "Nomenclatures",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Nomenclatures_NomenclatureId",
                table: "Parts",
                column: "NomenclatureId",
                principalTable: "Nomenclatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Nomenclatures_NomenclatureId",
                table: "Parts");

            migrationBuilder.DropTable(
                name: "Nomenclatures");

            migrationBuilder.DropIndex(
                name: "IX_Parts_NomenclatureId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "NomenclatureId",
                table: "Parts");
        }
    }
}
