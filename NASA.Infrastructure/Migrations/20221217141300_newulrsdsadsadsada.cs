using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class newulrsdsadsadsada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8313a88e-2bf1-4f18-9c71-224ef2f94ad8", "AQAAAAEAACcQAAAAEK+VqogVK55/d6pfpANAJ2LItZf60WhlPejguZB2odTEd5Xqm5jeFTtdLRVCztiVNw==", "d3547bc7-ac14-40b6-8121-a4c60298af18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec5db4d3-a790-46e8-b08d-ca3d5b4c8a34", "AQAAAAEAACcQAAAAEGWtBJ1b6FoA6xmcAy19HX0oveBQwCdUU62kF12uT3IFU5z6HFxYoNwdvRiy6cJyYg==", "0fb5d1ff-0a6d-4ff9-8291-88a7544e9719" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Physics for Beginners");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a179d5b8-6566-4964-84e0-9f82a378ec9e", "AQAAAAEAACcQAAAAEO+waCFhzVD18R6/NO5T5g5e++DcAGLdAVOadNXz2SLuKBB2YxG34lQZe+OlG8zITw==", "9932cc02-5cb4-46c7-9adb-324dd193a130" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc55ce07-62cb-4b15-8004-fcd2c35e60bd", "AQAAAAEAACcQAAAAED5/Et9sYND45vjpsEtd9A9bFsBRTJrYit7YTmLcdLx+lpan6+iUSKXXighFmHU2+g==", "33fab2c3-4b18-4dec-aad0-5ced6ec1c8c4" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Phycis for Beginners");
        }
    }
}
