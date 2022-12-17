using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class CategoryUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 3);
        }
    }
}
