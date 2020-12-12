using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class Add_InfoEmploy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 10, 21, 53, 3, 835, DateTimeKind.Local).AddTicks(4625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 10, 16, 32, 32, 339, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.AlterColumn<decimal>(
                name: "LUONG_CB",
                table: "InfoEmployees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LUONG_BH",
                table: "InfoEmployees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "40efd9ba-11ac-4410-a305-23fe0d7e00d7");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77426a47-0fb0-4ea9-b672-6b6e6ae48cd6", "AQAAAAEAACcQAAAAEHV39hx6g78sclAxwHqQL/LnXrkff7FmmpyQ99v77K3ocmsfcA0M8VZmIfXxiK0oaw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.InsertData(
                table: "InfoEmployees",
                columns: new[] { "Id", "CMND", "DAN_TOC", "DIA_CHI", "DTDD", "DVCS_ID", "EMAIL", "GIOI_TINH", "HON_NHAN", "HO_TEN", "LUONG_BH", "LUONG_CB", "MA_NV", "MA_PB", "NGAY_CAP", "NGAY_SINH", "NOI_CAP", "NOI_SINH", "QUE_QUAN", "QUOC_TICH", "TON_GIAO" },
                values: new object[] { 1, "2491242225", "Kinh", "Quận 9", "038504070", "VP", "vynguyen@gmail.com", "Nữ", "Chưa kết hôn", null, 4500000m, 4500000m, "NV001", "Kế toán", new DateTime(2013, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lâm Đồng", "Lâm Đồng", "Bình Định", "Việt nam", "Không" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 10, 21, 53, 3, 856, DateTimeKind.Local).AddTicks(2413));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InfoEmployees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 10, 16, 32, 32, 339, DateTimeKind.Local).AddTicks(5758),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 10, 21, 53, 3, 835, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.AlterColumn<string>(
                name: "LUONG_CB",
                table: "InfoEmployees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "LUONG_BH",
                table: "InfoEmployees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "7debbf2b-fd01-4387-8d03-3281c00e3c8a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b67a769a-0490-4bac-b5e3-538c66b68263", "AQAAAAEAACcQAAAAEG5Tv+LfHY2raS/jR26/tutYLGOXBdjWq/Marrm4QUM1D70Q2o3dSo+iPjWLZ5p94A==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 10, 16, 32, 32, 362, DateTimeKind.Local).AddTicks(938));
        }
    }
}
