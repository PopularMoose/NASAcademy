using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class CategoryChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ecbbd06-4ae6-4059-bc93-5a70e0e1a5e8", "AQAAAAEAACcQAAAAEEH5wje0iAb9FJSvpb9xlqzAJmN7oE477Z3efcp0qZ9Gji6s2zqMN5Rnz78BZ5PI8w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aaacd40c-1121-41f8-8828-732cc1993902", "AQAAAAEAACcQAAAAEJZN2lHz5/mjOoTZ0o/abWNox+b95p3w+vIvhTITO82dcurLDN6Z6f9lknux2/mPXQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Fundamentals");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Advanced");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a83ac9e-ce92-48e3-a5cb-fbea0043e6cf", "AQAAAAEAACcQAAAAEJc+wJyZYe8IV7d9nghTbMxwcKl2UWwKiXldTIVGTLMVKCJfzaBLWdqIAfuXDKXesg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "39a4dfab-9abf-452a-af4c-6d2ed38857a8", "AQAAAAEAACcQAAAAEDaoRrbS/rZvdbbj4T9+VUySDfsjivky7HUE1TtOv2o+eKtoz9xIe438WQvOH7ZThA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Fundamels");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Duplex");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 2);
        }
    }
}
