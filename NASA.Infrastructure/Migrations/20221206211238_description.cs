using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class description : Migration
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
                oldDefaultValue: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68d2aa81-d789-4906-9b10-96c701c5b565", "AQAAAAEAACcQAAAAEOI3aTPOckFuD+iRe4DMJjnQbB4qXu25nhLoHoUT6Rqr5rb7ED7BdSnpb40eJXkxbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9dffbf84-ad7b-47f2-bb42-73f86990f652", "AQAAAAEAACcQAAAAEIxTM9KeVfkzjGTSuFwNW6B8EWa654xNuMqdWlb1OZjscZ9NsWc2vm1vlaIWO5x7iA==" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PricePerCourse", "Title" },
                values: new object[] { 100.00m, "Phycis for Beginners" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "PricePerCourse", "Title" },
                values: new object[] { "Course 'Math for Beginners' gives people basic understanding of math needed for further specialization in NASAcademy.The course includes'Rational Numbers','IRational Numbers','Real Numbers','Prime Numbers','Composite Numbers' and many more", 100.00m, "Math for Beginners" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "PricePerCourse", "Title" },
                values: new object[] { "Course 'Biology for Beginners' gives people basic understanding of biology needed for further specialization in NASAcademy.The course includes'Life','Cells','Evolution','Genes','Homeostasis' and many more", 100.00m, "Biology for Beginners" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

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
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PricePerCourse", "Title" },
                values: new object[] { 2100.00m, "Big Course Marina" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "PricePerCourse", "Title" },
                values: new object[] { "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.", 1200.00m, "Family Course Comfort" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "PricePerCourse", "Title" },
                values: new object[] { "This luxurious house is everything you will need. It is just excellent.", 2000.00m, "Grand Course" });
        }
    }
}
