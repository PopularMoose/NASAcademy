using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class UserExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ba8597e-fb14-4a74-bd09-32a294920173", true, "AQAAAAEAACcQAAAAEJdciudgpKZCecm/iSp7HV8WqVp52KzrOsb5G491u2H2XtTWKtRfodr2zllMvOcD6w==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bbef102-35f9-48f7-a0d5-431a3f5f171c", true, "AQAAAAEAACcQAAAAEL286lLoeGHIIMYS9uponBDooFCj1ipEauX+wi3Tud8PogMfd/ds6NUwpVM8kfHJew==", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

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
        }
    }
}
