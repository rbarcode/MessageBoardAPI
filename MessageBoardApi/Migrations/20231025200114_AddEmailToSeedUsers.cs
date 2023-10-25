using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MessageBoardApi.Migrations
{
    public partial class AddEmailToSeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc123",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4c89348-2c21-42d3-8924-16c17a126dbd", "test1@test.com", "AQAAAAEAACcQAAAAEMbtbLIMpQqJJ0bDGa/x4RvNFrwP7L5PbzQPx5Ff4ufl9/2+VDL4avzw5wAgmyGENA==", "18efbc67-d51a-4254-b082-6ec56ebc0de7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "def456",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e19fa90a-23d1-4946-83d9-158c84160ea2", "test2@test.com", "AQAAAAEAACcQAAAAEFDtY10LG4JbcpKI7MOUXappwXOMkvSaw0LS1aQm+wMpobY+xbqj7d0AmS+wDEesXA==", "067cf589-389e-4796-81a3-93723dd15bae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ghi789",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b32dedd-0dbe-4d58-bbf6-d370bbcdc735", "test3@test.com", "AQAAAAEAACcQAAAAENXZhUt58UkPObOggxFuOhI91wP/aPxu8uHZTuBe6E1gL9+vD4Fk+47uGIqgMPZR+A==", "58c131b9-73be-4951-96d1-1b8d95692107" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc123",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3f74235-9053-4654-aad9-d577bc9a380e", null, "AQAAAAEAACcQAAAAELsPXSktwQg47Daw8Fgjs3+NGdQ8A7F4fM7udz3Xq978yT6rw75XICMEdVyEARnA8g==", "0513c562-2bbb-4010-8dad-98fc0fc6a807" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "def456",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d8dcc7a-12dc-4133-9b14-45995b5e7aee", null, "AQAAAAEAACcQAAAAEIE3FriKYvZZfJT8XMc2nkajCxFKMAygfmsXiqy1P1MqL/Em6LRv5xJDKP/6fDvLlA==", "a5608689-3ea0-4702-8a2d-a41c10ecfa0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ghi789",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6952365-469f-4a19-bfc0-b37926a64903", null, "AQAAAAEAACcQAAAAEN+v1590E2D+GDCcEz5fB/aF17MoumMrkDT8eU53lEL0OSAU3QVIKQ9Sgbmm5OERgw==", "f095461e-a895-4494-9426-0fff62894644" });
        }
    }
}
