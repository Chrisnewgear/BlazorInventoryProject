using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class HomeMIgration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "0e79e35d-ce16-4d99-9b66-5ca628984ad6");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "40eb5f92-fcd9-479e-889f-6975fb9408dd");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "62504370-fa23-49a9-90e5-7a3993db1ced");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "959dc828-aadf-41c7-900d-30d4bd6f2661");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "b8cad801-e259-4a2a-ba7a-db180f8d6940");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAdress", "WarehouseName" },
                values: new object[,]
                {
                    { "820d2ce0-f837-4c34-bd56-97a113898cd8", "Alborada", "Bodega Central" },
                    { "a148a012-f778-4770-adea-8386ad178dad", "Esteros", "Bodega Sur" },
                    { "aff50a42-527d-44b5-b666-fb08248774d0", "Mapasingue", "Bodega Oeste" },
                    { "56d0b5d0-45d4-4592-933f-494ea6345ce1", "Centenario", "Bodega Este" },
                    { "47e7b338-eabd-445d-b436-f739c96f6591", "La Garzota", "Bodega Norte" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "47e7b338-eabd-445d-b436-f739c96f6591");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "56d0b5d0-45d4-4592-933f-494ea6345ce1");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "820d2ce0-f837-4c34-bd56-97a113898cd8");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "a148a012-f778-4770-adea-8386ad178dad");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "aff50a42-527d-44b5-b666-fb08248774d0");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAdress", "WarehouseName" },
                values: new object[,]
                {
                    { "62504370-fa23-49a9-90e5-7a3993db1ced", "Alborada", "Bodega Central" },
                    { "b8cad801-e259-4a2a-ba7a-db180f8d6940", "Esteros", "Bodega Sur" },
                    { "959dc828-aadf-41c7-900d-30d4bd6f2661", "Mapasingue", "Bodega Oeste" },
                    { "40eb5f92-fcd9-479e-889f-6975fb9408dd", "Centenario", "Bodega Este" },
                    { "0e79e35d-ce16-4d99-9b66-5ca628984ad6", "La Garzota", "Bodega Norte" }
                });
        }
    }
}
