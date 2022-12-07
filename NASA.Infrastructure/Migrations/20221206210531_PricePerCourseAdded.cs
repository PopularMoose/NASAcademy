using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class PricePerCourseAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PricePerMonth",
                table: "Courses",
                newName: "PricePerCourse");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PricePerCourse",
                table: "Courses",
                newName: "PricePerMonth");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "56217e01-9f7d-4887-8f50-539171b57959", "AQAAAAEAACcQAAAAEN5G+KJpnF3XcWSFzyWyy5DkueyEf3G5gDoIUQz5OgCrbKV1JPd8jOLgb91XOoiYPw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c270fbb-b25c-49f3-8040-aa71aaf3e324", "AQAAAAEAACcQAAAAEDd4TTskIaj+i55IyYV4Wd53DIYlpSxMm05eTZTFdKi5M6r2ylCKdxv2bA8UEwZFpw==" });
        }
    }
}
