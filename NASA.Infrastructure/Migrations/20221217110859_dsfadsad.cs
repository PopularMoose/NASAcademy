using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class dsfadsad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "524fc577-70b9-485f-9491-a10007c810d2", "AQAAAAEAACcQAAAAEBZ+qRPRDyROwGLmnn3YV41ElymBYQYvOTlbKjmTBcf3oJgpSvzQjAIAT3Za7HkdVQ==", "5f07b652-8447-4b9a-89bf-34089f4315a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49d2ca6d-e2d4-47b0-8a8d-5b59c299fb85", "AQAAAAEAACcQAAAAEOD8ubS16NjUW+rC2DmsxMICKlVVWfSdNdkDviByCpz3C6Pyftcv3x0bxQW9LZ72sA==", "95082f41-c8e7-4b96-8199-e55bafc8dd62" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a4f97ee-82a3-4829-ba7e-5dc8aad1fe96", "AQAAAAEAACcQAAAAECt3U66votf2bVgR8d0Cv3uM7oKiVFEcOgGe3AuFGignq2T/dzEX6OZF9cmNesP3DA==", "eaafaee6-2a99-4d15-bc6e-f2d25469705e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97eddaed-4663-4a7b-8fe3-8f61f23c98de", "AQAAAAEAACcQAAAAEGJCnm7bdjIPj1JglFmTxNqVSbya8gKmImacurdSfhrlzkPuwHZ7xveCmQGHy3SbYw==", "8df0f9f2-5ed0-4172-a128-4902d2ef2aee" });
        }
    }
}
