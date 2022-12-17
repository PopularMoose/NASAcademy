using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class NewUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "fb73dced-83c0-4c86-9d5c-7761537aeb70", "AQAAAAEAACcQAAAAED8HJdTPMqh/95rktNadF9py8yoa+uJAYUpmmR2ncTQIQCs4fdCEDYlNwiZBTBwAwQ==", "c4dfaebd-90aa-4195-a715-e85574299082" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "405b0b5a-4fa2-4e0e-be30-20065ef3ef02", "AQAAAAEAACcQAAAAEM096SWasPvMpSiQzVje/SipbCnwhtHhXRfzvOVplb+G1q0+aFS70n1oKQupwRzOYw==", "47f8153c-9abd-4ade-ba45-2d8f937f256b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                nullable: true,
                defaultValue: true);

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
                values: new object[] { "c3acdb9c-b243-4f65-97e2-1c9269dacd7c", true, "AQAAAAEAACcQAAAAEFlt+Tg8NmZ9bdF0+mJntApE8EQ11qSr99RwnozyrDD4Ube3cJRX5XUf+MSbyrBz5A==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0e066b6-055e-4481-bf0c-90945444892d", true, "AQAAAAEAACcQAAAAEEaBi1boG0jcgv8zGllEknj6W6XHIREDsr4TSu9s22oZ97n+4hV+YMSru1ubKLS3nQ==", null });
        }
    }
}
