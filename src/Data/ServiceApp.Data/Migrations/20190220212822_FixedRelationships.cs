using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceApp.Data.Migrations
{
    public partial class FixedRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdersParts");

            migrationBuilder.DropTable(
                name: "WarehousesPart");

            migrationBuilder.AddColumn<int>(
                name: "DeliveryId",
                table: "Parts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Parts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WarehouseId",
                table: "Parts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parts_DeliveryId",
                table: "Parts",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_OrderId",
                table: "Parts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_WarehouseId",
                table: "Parts",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Delivery_DeliveryId",
                table: "Parts",
                column: "DeliveryId",
                principalTable: "Delivery",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Orders_OrderId",
                table: "Parts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Warehouses_WarehouseId",
                table: "Parts",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Delivery_DeliveryId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Orders_OrderId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Warehouses_WarehouseId",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Parts_DeliveryId",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Parts_OrderId",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Parts_WarehouseId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "Parts");

            migrationBuilder.CreateTable(
                name: "OrdersParts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    PartId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersParts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersParts_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WarehousesPart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PartId = table.Column<int>(nullable: false),
                    WarehouseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehousesPart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarehousesPart_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WarehousesPart_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdersParts_OrderId",
                table: "OrdersParts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersParts_PartId",
                table: "OrdersParts",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesPart_PartId",
                table: "WarehousesPart",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesPart_WarehouseId",
                table: "WarehousesPart",
                column: "WarehouseId");
        }
    }
}
