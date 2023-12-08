using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetselGames.Data.Migrations
{
    public partial class Init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("50bf0616-6bff-491c-800b-bfe7e8bfbbd9"),
                column: "ConcurrencyStamp",
                value: "599b2e12-442c-4269-83cb-5115c7ff8a8b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e00726f9-87c1-4540-ab1e-3b0d3135868d"),
                column: "ConcurrencyStamp",
                value: "e822adbd-e30b-4b18-bf76-ebb80b90ec5f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f9496293-0393-4fc7-a3d0-51d17df4c821"),
                column: "ConcurrencyStamp",
                value: "c0b20079-c1d1-4490-95b4-8a3bc1392b55");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9cbec590-0916-4f4e-9d08-c65e561e81b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4852aad8-89d1-4690-bce4-45807b4f6d42", "AQAAAAEAACcQAAAAEJAChL6xxbCVA+gOeMCrp1G0zb3sIntdJTfvQv2zFxntzFqO7Vw6pcoeuWtVqHK8Sg==", "c212fad5-3368-439b-b073-177b5fb8ffc0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9e753d47-8f3e-4cde-b395-0260b2fe7960"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3682b12-6527-41ca-94b2-a9a1950a3713", "AQAAAAEAACcQAAAAENm/Pqtfa8dlljoLpcmybhKaENW5xGikRPl+O139ruIVhmhfpJ8/NKrcqnV2irnRug==", "a49f0af9-b73a-4ae8-b7bf-3115013de111" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { new Guid("d77c1b7f-29e4-4f4f-a9c7-98657fbd3165"), "Undefinied", new DateTime(2023, 12, 8, 21, 52, 25, 269, DateTimeKind.Local).AddTicks(9747), "Undefinied", null, null, false, "Undefinied", null, "Psp" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d77c1b7f-29e4-4f4f-a9c7-98657fbd3165"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("50bf0616-6bff-491c-800b-bfe7e8bfbbd9"),
                column: "ConcurrencyStamp",
                value: "bd1f8d77-b455-4d3c-a0e7-750169f9e7bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e00726f9-87c1-4540-ab1e-3b0d3135868d"),
                column: "ConcurrencyStamp",
                value: "71226f60-0b88-4699-878d-c46ba60f75c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f9496293-0393-4fc7-a3d0-51d17df4c821"),
                column: "ConcurrencyStamp",
                value: "b952a292-eacb-4b24-8d06-918f27c4d6c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9cbec590-0916-4f4e-9d08-c65e561e81b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "869a608d-f37e-404c-bb9e-a6a4ee97855d", "AQAAAAEAACcQAAAAENCyhGGVQ+UB7ZCkAHVoli/aFSdwlaL0Dwq2ZsLZJ4BJ86tQz8Mu1MAqgag8jRGRkQ==", "13e59128-f691-4827-b97a-aab203133162" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9e753d47-8f3e-4cde-b395-0260b2fe7960"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92b9a1b5-c344-418c-ac74-fc5dc462cd00", "AQAAAAEAACcQAAAAEJbhWozXuZjc7J24d+5AkuZTIYjYYSZtKanHVy5aY6wg7NNDbKrPQIM9uGYfLAnSBw==", "c39368e5-f0cb-4e79-be58-9aa5975592c7" });
        }
    }
}
