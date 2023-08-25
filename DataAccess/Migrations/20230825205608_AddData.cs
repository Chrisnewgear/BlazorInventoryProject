using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" },
                    { "PRF", "Perfumeería" },
                    { "SLD", "Salud" },
                    { "VDJ", "Video Juegos" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASP");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "HGR");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "PRF");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "SLD");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "VDJ");

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
        }
    }
}
