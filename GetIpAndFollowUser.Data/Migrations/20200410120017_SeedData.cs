using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GetIpAndFollowUser.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LocationUsers",
                columns: new[] { "Id", "DateCreate", "DateEnd", "IpClient", "Locations" },
                values: new object[] { 1, new DateTime(2020, 4, 10, 19, 0, 16, 923, DateTimeKind.Local).AddTicks(6220), 60, "100,100", "" });

            migrationBuilder.InsertData(
                table: "FollowWorkingPages",
                columns: new[] { "id", "Duration", "IdPageUser", "LinkPage", "ViewCount" },
                values: new object[] { 1, 0, 1, "VietNam", 0 });

            migrationBuilder.InsertData(
                table: "LocationDetails",
                columns: new[] { "id", "Country", "District", "IdLocationUser", "Province", "SmallAddress" },
                values: new object[] { 1, "VietNam", "HungHa", 1, "ThaiBinh", "TanLe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FollowWorkingPages",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LocationDetails",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LocationUsers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
