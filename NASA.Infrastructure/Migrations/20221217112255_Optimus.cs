using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class Optimus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teachers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fedfbd2-28d9-4877-9213-efd5725cab67", "AQAAAAEAACcQAAAAEJDRsz9Y4HiIXC3OKg9m3vyklybeZmQEL80uUuly7sV3i8MQuT49xww6u2csKJvabQ==", "49390d6c-4c16-486a-bafd-01efbe654096" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "605a56bb-2fc7-4399-aa81-4e3b35ebbf8b", "AQAAAAEAACcQAAAAEIDeromH/1JKOYojkiQS3Lk2b8UBmGWvGP9LwwBy2T0NKF7oB6YaXNRUnel8bPqfng==", "afb23c56-ee16-4330-b435-8ffed2f34ee0" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "Email@mail.com");
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
                values: new object[] { "eff7372b-a6c8-4224-bfe2-f5ed95b8b688", "AQAAAAEAACcQAAAAEELCLGi9gthjY/V4PeJ43IKQB9bH/8wwYAXHL3i8n55YYHA2TDP8Q3v7VGWLTdxk1A==", "5c43459e-657a-4b81-b5ee-befbf1c75f59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9499cf0-e151-4b76-a1b2-3e862a2f35f7", "AQAAAAEAACcQAAAAENsVe1ce/xA3umWmwkfsvU2EKimE0dNACh6FAP4MoykG1PcC3ZXOXmhG6ro0yyo2JQ==", "e8150592-c074-41b4-88ca-abf16ebf896c" });
        }
    }
}
