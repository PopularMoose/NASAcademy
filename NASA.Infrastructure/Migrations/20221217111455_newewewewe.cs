using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class newewewewe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "884e2c6a-3cde-4381-ae7a-dc8e5a3b36c1", "AQAAAAEAACcQAAAAEJXAJQrOXEBCwG6cRbhg4Nt3AgFFCN08pQvQSwmdgDvLl0/32ECX8NDUeTKx/zTWaw==", "2bcac833-d821-4303-80c5-4d65270d5a2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2956485f-2f98-4d19-9ddf-1a51627e1a1b", "AQAAAAEAACcQAAAAEC6Jwn6Xsm2UUxe/1A5RdishNAFncqu+PsN+jQsgv+gfQ5Qtvre8XXTNHjKgyxr0Vw==", "5ad0b8ed-d840-4bee-96bd-4505ec3904ac" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "Email");
        }
    }
}
