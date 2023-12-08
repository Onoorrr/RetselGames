using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetselGames.Data.Migrations
{
    public partial class Init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("50bf0616-6bff-491c-800b-bfe7e8bfbbd9"),
                column: "ConcurrencyStamp",
                value: "11d4a5e7-65b0-4c6f-96dd-43cf4fa72d07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e00726f9-87c1-4540-ab1e-3b0d3135868d"),
                column: "ConcurrencyStamp",
                value: "287d2ad6-145c-4b11-81b7-1501945eda52");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f9496293-0393-4fc7-a3d0-51d17df4c821"),
                column: "ConcurrencyStamp",
                value: "f6e57c3c-ff24-48d8-975e-f07501889cbe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9cbec590-0916-4f4e-9d08-c65e561e81b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52c878e4-fb3d-43b8-a521-a498f51571af", "AQAAAAEAACcQAAAAEGXL6M4lMM6b0b4f85mATmwlAHu+ZFR7eIO4r6FqHAMIGLQevZqDTP+qkaeCkg0DZA==", "8d1c9f7a-2229-4018-a3a7-ec1e258e4888" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9e753d47-8f3e-4cde-b395-0260b2fe7960"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a96e1098-5302-440c-8676-d24e47d13adb", "AQAAAAEAACcQAAAAEK2x9zUqAcZAgTHs1x73PJcw1IGOyqMU2m1yrj9NuFn6eOfVThx/tcAjbUG2DRUV/w==", "bf471a67-ea12-47c1-994e-4fbacf35208f" });
        }
    }
}
