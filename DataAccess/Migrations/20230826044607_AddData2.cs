using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "bdbc4140-b99f-493b-b43d-ab3f3a6aae50", "Alborada", "Bodega Central" },
                    { "cb316bb9-49c2-4c28-bb59-8a6cb4b4526b", "Esteros", "Bodega Sur" },
                    { "34b2357a-ac62-4fb0-833f-4bcf5e9ec423", "Mapasingue", "Bodega Oeste" },
                    { "ef554b1c-ac00-45b2-b307-40331e992f75", "Centenario", "Bodega Este" },
                    { "c8b3e207-f7d7-4f6e-b250-1af343415b56", "La Garzota", "Bodega Norte" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "34b2357a-ac62-4fb0-833f-4bcf5e9ec423");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "bdbc4140-b99f-493b-b43d-ab3f3a6aae50");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "c8b3e207-f7d7-4f6e-b250-1af343415b56");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "cb316bb9-49c2-4c28-bb59-8a6cb4b4526b");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "ef554b1c-ac00-45b2-b307-40331e992f75");

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
    }
}
