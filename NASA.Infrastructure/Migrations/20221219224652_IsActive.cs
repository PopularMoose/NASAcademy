using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class IsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77b499f7-7e8c-427e-a664-e66ed476e7ed", "AQAAAAEAACcQAAAAEIZHeg77sW2zplasCPNp9/MNUE4/tZPMgus37oL6X1quooqardTLPmmQ6rqQGnpiqQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1d0bb19-2002-4125-84ce-1e615260481d", "AQAAAAEAACcQAAAAEKl/KvH+G1NTJYQCikyYP0tpOkcFFoI5pfhIP5qekc2VpNjP20b7tX+rnDVGAHA50g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ba8597e-fb14-4a74-bd09-32a294920173", "AQAAAAEAACcQAAAAEJdciudgpKZCecm/iSp7HV8WqVp52KzrOsb5G491u2H2XtTWKtRfodr2zllMvOcD6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2bbef102-35f9-48f7-a0d5-431a3f5f171c", "AQAAAAEAACcQAAAAEL286lLoeGHIIMYS9uponBDooFCj1ipEauX+wi3Tud8PogMfd/ds6NUwpVM8kfHJew==" });
        }
    }
}
