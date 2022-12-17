using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class dsawehhh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "884e2c6a-3cde-4381-ae7a-dc8e5a3b36c1", "AQAAAAEAACcQAAAAEJXAJQrOXEBCwG6cRbhg4Nt3AgFFCN08pQvQSwmdgDvLl0/32ECX8NDUeTKx/zTWaw==", "2bcac833-d821-4303-80c5-4d65270d5a2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2956485f-2f98-4d19-9ddf-1a51627e1a1b", "AQAAAAEAACcQAAAAEC6Jwn6Xsm2UUxe/1A5RdishNAFncqu+PsN+jQsgv+gfQ5Qtvre8XXTNHjKgyxr0Vw==", "5ad0b8ed-d840-4bee-96bd-4505ec3904ac" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
