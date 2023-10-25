using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MessageBoardApi.Migrations
{
    public partial class AddNormalizedNameEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc123",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1858e848-4e5c-4720-9cfa-381d60e8df16", "TEST1@TEST.COM", "JOEY", "AQAAAAEAACcQAAAAENNeAK7Cg+/6UDh5KotsF1XsQJxQdEueQsFGtvfjC7K9X2qpneO7MH+VNW4kEKPWzQ==", "091eb240-5287-4f5d-b7df-73e2257895ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "def456",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b2b802f-ca05-4fbe-8ac4-77ee3c22d081", "TEST2@TEST.COM", "RICHARD", "AQAAAAEAACcQAAAAEF0WQ4jiwLOzsjEc6dhynPzeHolWwMdlReEIv/2lcNj0PA44m0h41pLsqf8Jp42mBA==", "a7668cb5-1af9-4ea8-9d02-9624a488fd2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ghi789",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88bc34c0-5e43-4e10-9463-8270ca9e0110", "TEST3@TEST.COM", "ONUR", "AQAAAAEAACcQAAAAEB6FX899grUhPuLEjcjRVHRGM0tEnhqGgx0tCGZsNd9FJKUhhBJvkJGOYRF3BRe9/Q==", "d8a5d49f-7254-4cf1-9cf2-a0acf6f9a180" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc123",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4c89348-2c21-42d3-8924-16c17a126dbd", null, null, "AQAAAAEAACcQAAAAEMbtbLIMpQqJJ0bDGa/x4RvNFrwP7L5PbzQPx5Ff4ufl9/2+VDL4avzw5wAgmyGENA==", "18efbc67-d51a-4254-b082-6ec56ebc0de7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "def456",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e19fa90a-23d1-4946-83d9-158c84160ea2", null, null, "AQAAAAEAACcQAAAAEFDtY10LG4JbcpKI7MOUXappwXOMkvSaw0LS1aQm+wMpobY+xbqj7d0AmS+wDEesXA==", "067cf589-389e-4796-81a3-93723dd15bae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ghi789",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b32dedd-0dbe-4d58-bbf6-d370bbcdc735", null, null, "AQAAAAEAACcQAAAAENXZhUt58UkPObOggxFuOhI91wP/aPxu8uHZTuBe6E1gL9+vD4Fk+47uGIqgMPZR+A==", "58c131b9-73be-4951-96d1-1b8d95692107" });
        }
    }
}
