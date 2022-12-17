using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class NewEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Teachers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47f919f9-c716-4b8a-937f-5187b7469f9e", "AQAAAAEAACcQAAAAEAZvb76pYowLpPkgxLsm8Tq7q72lNmAA23IXW1DCPzzVyBgh1a/dQRLKJrlNM+dhqQ==", "c0969456-31ab-45cb-961e-bfb1898359e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "395ee90d-d0be-4fb4-b3d7-0d30bbd0ca36", "AQAAAAEAACcQAAAAECFk5+1SXSCpdu0ozyiQ92V6LkChYVfCRlgJidUd4qwTpeoJl453yN8tCHv06kE2cw==", "075aaf6a-bd14-4de6-9afa-6ff72af0d231" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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
        }
    }
}
