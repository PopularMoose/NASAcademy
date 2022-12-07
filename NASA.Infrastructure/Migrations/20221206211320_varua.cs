using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class varua : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2109249d-79dd-4dda-9eed-a8cd95cf19d9", "AQAAAAEAACcQAAAAENmzPkeJh1qx/Tbcyl4axAkko2+X2KZLDdEeqpkgBz7ot9QqAPX+jgGPlgJBrzni9g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9361c2a2-7f61-428f-a432-1711876da89e", "AQAAAAEAACcQAAAAEFPEG4QsaWZeXD3dUTPADrOHqn8Aa9HqaDeXT6OatRVXE3ZayKTTkgFAt5gn4A4xfA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68d2aa81-d789-4906-9b10-96c701c5b565", "AQAAAAEAACcQAAAAEOI3aTPOckFuD+iRe4DMJjnQbB4qXu25nhLoHoUT6Rqr5rb7ED7BdSnpb40eJXkxbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9dffbf84-ad7b-47f2-bb42-73f86990f652", "AQAAAAEAACcQAAAAEIxTM9KeVfkzjGTSuFwNW6B8EWa654xNuMqdWlb1OZjscZ9NsWc2vm1vlaIWO5x7iA==" });
        }
    }
}
