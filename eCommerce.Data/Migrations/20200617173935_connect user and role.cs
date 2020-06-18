using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce.Data.Migrations
{
    public partial class connectuserandrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "2cae208d-b5cb-4a33-a2cf-3b6411fed08f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("98d30750-ffe1-4d9c-9dfe-05f0c5d64a0f"),
                column: "ConcurrencyStamp",
                value: "b66151b1-f658-48df-9db3-70ab55c28834");

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("5dfd7db6-11d3-43dd-da0f-08d811b6ed1f"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") },
                    { new Guid("3185e3e5-b1ee-4205-02a4-08d8127567cd"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") },
                    { new Guid("2892904e-4bb4-4ab0-b16f-08d812c371e3"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") },
                    { new Guid("a21f1ce7-f421-46d4-b170-08d812c371e3"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") },
                    { new Guid("ee2febef-2b6f-4860-b171-08d812c371e3"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") },
                    { new Guid("8f6e6938-2c2b-4075-b172-08d812c371e3"), new Guid("98d30750-ffe1-4d9c-9dfe-05f0c5d64a0f") },
                    { new Guid("c96c4420-5398-438d-b173-08d812c371e3"), new Guid("98d30750-ffe1-4d9c-9dfe-05f0c5d64a0f") },
                    { new Guid("4c3f8de1-ae9b-4499-b174-08d812c371e3"), new Guid("98d30750-ffe1-4d9c-9dfe-05f0c5d64a0f") },
                    { new Guid("431c8ea6-d8ef-45d6-b175-08d812c371e3"), new Guid("98d30750-ffe1-4d9c-9dfe-05f0c5d64a0f") },
                    { new Guid("d2ac625b-fa25-4c71-b176-08d812c371e3"), new Guid("98d30750-ffe1-4d9c-9dfe-05f0c5d64a0f") }
                });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "50297337-4986-4e1d-b26e-92921027cf1d", "AQAAAAEAACcQAAAAEBblsDsWxLb9CZWqPaf0qpc3Agy60l+uE4PHUfbhBGR/i6IwVMbvhoVBchPEpNqZnw==" });

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
                value: new DateTime(2020, 6, 18, 0, 39, 35, 59, DateTimeKind.Local).AddTicks(7862));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("2892904e-4bb4-4ab0-b16f-08d812c371e3"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("3185e3e5-b1ee-4205-02a4-08d8127567cd"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("431c8ea6-d8ef-45d6-b175-08d812c371e3"), new Guid("98d30750-ffe1-4d9c-9dfe-05f0c5d64a0f") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("4c3f8de1-ae9b-4499-b174-08d812c371e3"), new Guid("98d30750-ffe1-4d9c-9dfe-05f0c5d64a0f") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("5dfd7db6-11d3-43dd-da0f-08d811b6ed1f"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("8f6e6938-2c2b-4075-b172-08d812c371e3"), new Guid("98d30750-ffe1-4d9c-9dfe-05f0c5d64a0f") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("a21f1ce7-f421-46d4-b170-08d812c371e3"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("c96c4420-5398-438d-b173-08d812c371e3"), new Guid("98d30750-ffe1-4d9c-9dfe-05f0c5d64a0f") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("d2ac625b-fa25-4c71-b176-08d812c371e3"), new Guid("98d30750-ffe1-4d9c-9dfe-05f0c5d64a0f") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ee2febef-2b6f-4860-b171-08d812c371e3"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6072e616-a21e-4fe2-96cc-df970e09dfa5");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("98d30750-ffe1-4d9c-9dfe-05f0c5d64a0f"),
                column: "ConcurrencyStamp",
                value: "4ff25895-003d-49f7-81a5-b564954ae1de");

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
    }
}
