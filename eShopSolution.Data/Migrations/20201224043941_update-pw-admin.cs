using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class updatepwadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a2aaa415-6d6d-4cd3-8831-b2edd12fc3a2"),
                column: "ConcurrencyStamp",
                value: "372a87e8-4a5f-4756-a07f-6bb83ffe6e74");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c149b2f1-b9b2-4fd1-86f1-2044ba50cba2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "07e881f6-97c3-4ba0-8917-41f22862e2fe", "AQAAAAEAACcQAAAAEHkPOZ9xRyXUpbmb+oErpMMZu9qePUstVTAPyidDz3HohRyGrPi+O/52SYpt6nHNjQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 24, 11, 39, 40, 704, DateTimeKind.Local).AddTicks(8292));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a2aaa415-6d6d-4cd3-8831-b2edd12fc3a2"),
                column: "ConcurrencyStamp",
                value: "c5dd8383-6436-4a7f-8504-a93a5f1e7206");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c149b2f1-b9b2-4fd1-86f1-2044ba50cba2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd5fd7cd-f8a7-41b1-bb8e-db11ab00c91f", "AQAAAAEAACcQAAAAEMjd5NHi61M96iFheduqzwd8dVRk+9i9tCq+TX72LgP2NANPGoGDw60eEOqXUZl8sw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 24, 8, 53, 59, 437, DateTimeKind.Local).AddTicks(4198));
        }
    }
}
