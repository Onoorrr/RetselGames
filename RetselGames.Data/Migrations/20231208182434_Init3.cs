using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetselGames.Data.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("50bf0616-6bff-491c-800b-bfe7e8bfbbd9"),
                column: "ConcurrencyStamp",
                value: "49fc97db-4cf0-4045-b2dd-98879f6f288e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e00726f9-87c1-4540-ab1e-3b0d3135868d"),
                column: "ConcurrencyStamp",
                value: "6bd846f1-cbb8-482c-bf2a-e7cb8cef8356");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f9496293-0393-4fc7-a3d0-51d17df4c821"),
                column: "ConcurrencyStamp",
                value: "3dcc3eb2-0ee8-4e32-96e9-3bec840788fd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9cbec590-0916-4f4e-9d08-c65e561e81b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "015b715f-4c2b-4fce-bf7c-b190151f5b21", "AQAAAAEAACcQAAAAEHUGnsryw2dfykDUMjMlZo4hbHfhgSo0FY4lJiNsj71zf2IXM2WFjwvogblojv0wOg==", "83412abe-5779-4d8f-9515-8ca9ba7e012b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9e753d47-8f3e-4cde-b395-0260b2fe7960"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1236a163-3e02-40a9-91f3-4596f31ef836", "AQAAAAEAACcQAAAAEDFbq+D+Bh8hABxVB7nKR9xz4HWRVe0L1K5Vr09cq8eg3E4eS3KJSDcGOfOBDNLtDg==", "d2716c00-71d3-4877-ac27-e1bd23d77c4b" });
        }
    }
}
