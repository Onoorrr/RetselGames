using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetselGames.Data.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_UserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Platforms_PlatformId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropIndex(
                name: "IX_Categories_UserId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DownloadCount",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "PlatformId",
                table: "Games",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_PlatformId",
                table: "Games",
                newName: "IX_Games_UserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Games_AspNetUsers_UserId",
                table: "Games",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_AspNetUsers_UserId",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Games",
                newName: "PlatformId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_UserId",
                table: "Games",
                newName: "IX_Games_PlatformId");

            migrationBuilder.AddColumn<int>(
                name: "DownloadCount",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("50bf0616-6bff-491c-800b-bfe7e8bfbbd9"),
                column: "ConcurrencyStamp",
                value: "4437f1d9-b246-44f8-995a-221b489a3be5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e00726f9-87c1-4540-ab1e-3b0d3135868d"),
                column: "ConcurrencyStamp",
                value: "a398d1c4-ebcb-4828-b757-0f397778a942");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f9496293-0393-4fc7-a3d0-51d17df4c821"),
                column: "ConcurrencyStamp",
                value: "44662a4e-0dd4-4940-952d-0f7d3fd86562");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9cbec590-0916-4f4e-9d08-c65e561e81b1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2f2a61b-fc82-4229-b717-1690f5bf7b03", "AQAAAAEAACcQAAAAEEzoLSecamQbz376bLj4ss3K81YWMInyeqTNiQQHY/wBxftg6cQiabhvVy1r+pDVBw==", "d12ef9b7-0354-4531-9be4-6e7089b013c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9e753d47-8f3e-4cde-b395-0260b2fe7960"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28c68e82-5178-4b6d-b9f4-3d1f3ce59047", "AQAAAAEAACcQAAAAEAqDZK/8QGcogWdEVVE6YXFVTOOGIOYbPK7y3mnLQw+e6CgoFF0cNk6hRA2yRgkIRg==", "366474a8-2eb0-4d30-bf92-db9e918e0c7c" });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UserId",
                table: "Categories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_UserId",
                table: "Categories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Platforms_PlatformId",
                table: "Games",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
