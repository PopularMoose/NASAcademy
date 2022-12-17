using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class beginner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86c81653-4df8-4fd4-8855-c659b13d62ac", "AQAAAAEAACcQAAAAEIBW17FFIJUUkZyPbLS5+EYZ68lhTEm3mIeZzQwEd3wYE5yVw8TO6jEjQ8UJRqI3Jw==", "72b47b77-fea4-4f11-b501-7ad60a884cf5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cfe4111-33ad-471b-bab8-79ddf854f8aa", "AQAAAAEAACcQAAAAEKNeAbNfGJ/iXzyjo233wzlPm3zdHLHa/vg3laDhI6JQ2DXqrAi8vf3Xg6tW15l4hA==", "f0850153-ac6f-411f-bfba-0de1bfa59b6d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Beginner");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8313a88e-2bf1-4f18-9c71-224ef2f94ad8", "AQAAAAEAACcQAAAAEK+VqogVK55/d6pfpANAJ2LItZf60WhlPejguZB2odTEd5Xqm5jeFTtdLRVCztiVNw==", "d3547bc7-ac14-40b6-8121-a4c60298af18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec5db4d3-a790-46e8-b08d-ca3d5b4c8a34", "AQAAAAEAACcQAAAAEGWtBJ1b6FoA6xmcAy19HX0oveBQwCdUU62kF12uT3IFU5z6HFxYoNwdvRiy6cJyYg==", "0fb5d1ff-0a6d-4ff9-8291-88a7544e9719" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Begginer");
        }
    }
}
