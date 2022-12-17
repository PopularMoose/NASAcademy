using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class EmailAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "441f5c25-ddd2-4431-a44b-4435eeda2974", "AQAAAAEAACcQAAAAEFJVtyQ5iVvbWYpvw8z7yHiyKHWy5Aay4hKZvziRw03m+wXM3tVgAU84mLmF69bRXg==", "5ecc91fb-7369-4173-86bb-6948429d60a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b8c5a9f-d4d5-4560-9438-8d6f53522408", "AQAAAAEAACcQAAAAEMGpRHucy+ZP92Jt9w7ww2xgEsnJrUEEMouGFjAsiV/T5G/xs1WaY4T/p6J2XjVF3w==", "8815a835-6051-4633-9925-d8303a4c991c" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teachers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddeee58e-022e-401e-8de5-58773ca7e46c", "AQAAAAEAACcQAAAAEAPEVEI1UtNOfI57/NP7jLU9U15Wyk/VFkGXqihkhMiBezg9xzPeAKnoxanIkHCXqQ==", "c6dbec8e-b5f1-465f-9e8e-6b91053699ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8511adc-a756-473a-8553-46429cd11496", "AQAAAAEAACcQAAAAEDC9CqH9/QqKpTb3UpuCm+tsq7y0Q8BdA4f9/OV2Gd/KzFvoHDqlQUbOCKghxxY0Gg==", "d4c0f7b1-70dd-4d0a-86d8-c2ee02420d43" });
        }
    }
}
