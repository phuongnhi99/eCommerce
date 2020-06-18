using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce.Data.Migrations
{
    public partial class addrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "6072e616-a21e-4fe2-96cc-df970e09dfa5", "Employee role", "employee", "employee" });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("98d30750-ffe1-4d9c-9dfe-05f0c5d64a0f"), "4ff25895-003d-49f7-81a5-b564954ae1de", "Customer role", "customer", "customer" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea1552da-42b1-4717-aca0-2586f1a28185", "AQAAAAEAACcQAAAAELwH+FDnuZdcY3rbijQQI2Ysi8/WEMYuDS6L+D/KVofU6W8t2FZoaHDB4RdJ99Oc3w==" });

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
                value: new DateTime(2020, 6, 18, 0, 30, 14, 95, DateTimeKind.Local).AddTicks(5206));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("98d30750-ffe1-4d9c-9dfe-05f0c5d64a0f"));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "ffa5027b-58d0-4582-82b0-5b6acad8ec17", "Administrator role", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "39d6f983-be56-4f8d-b68d-71b4d0d34ce2", "AQAAAAEAACcQAAAAEJlz/2JODrUxQqBnajK2/nz5aLh6PzG1SowG5RVbQLEoeKnP6sBVZFXWjImIzjKuyQ==" });

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
                value: new DateTime(2020, 6, 16, 15, 30, 1, 823, DateTimeKind.Local).AddTicks(9521));
        }
    }
}
