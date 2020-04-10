using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GetIpAndFollowUser.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocationUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpClient = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Locations = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    DateCreate = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())"),
                    DateEnd = table.Column<int>(nullable: true, defaultValueSql: "((60))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FollowWorkingPages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkPage = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    ViewCount = table.Column<int>(nullable: true, defaultValueSql: "((1))"),
                    Duration = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    IdPageUser = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowWorkingPages", x => x.id);
                    table.ForeignKey(
                        name: "FK__FollowWor__IdPag__208CD6FA",
                        column: x => x.IdPageUser,
                        principalTable: "LocationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    Province = table.Column<string>(maxLength: 50, nullable: false),
                    District = table.Column<string>(maxLength: 50, nullable: false),
                    SmallAddress = table.Column<string>(maxLength: 100, nullable: true),
                    IdLocationUser = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK__LocationD__IdLoc__1AD3FDA4",
                        column: x => x.IdLocationUser,
                        principalTable: "LocationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FollowWorkingPages_IdPageUser",
                table: "FollowWorkingPages",
                column: "IdPageUser");

            migrationBuilder.CreateIndex(
                name: "IX_LocationDetails_IdLocationUser",
                table: "LocationDetails",
                column: "IdLocationUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FollowWorkingPages");

            migrationBuilder.DropTable(
                name: "LocationDetails");

            migrationBuilder.DropTable(
                name: "LocationUsers");
        }
    }
}
