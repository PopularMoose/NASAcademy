using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class NewCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2735af1c-bec9-4d26-b951-fbea6ee32009", "AQAAAAEAACcQAAAAEMW4vbkDh1QSvfwx0t+tnbxsLlOoOTJe+avkGEZMcHYmmOdq+LdeRLbEiUWfbXBzbQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "50b9f544-369e-41af-8c53-15afc9db4681", "AQAAAAEAACcQAAAAEG90LJGNprKkuqX0zMA7iFOxxbIR30VUVtRNkH4viu3ocaLF02xOWfdw77HUK0UpmA==" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "IsActive", "PricePerCourse", "StudentId", "TeacherId", "Title" },
                values: new object[,]
                {
                    { 4, 2, "'Engineering Introduction' provides basic understanding of 'Mechatronics','Electronics','Robot Systems','Software Engineering','Chemical and Biotechnoly Engineering' and many more", true, 450.00m, null, 1, "Engineering Introduction" },
                    { 5, 2, "'Aviation Introduction' provides basic understanding of 'Principles of Flight','Airframe and Systems','Airline Operations','Air Traffic Services','Airline & Airport Marketing Management' and many more", true, 450.00m, null, 1, "Aviation Introduction" },
                    { 6, 3, "'Practise with Air-crafts' physical trainning and understanding of the air-craft model ", true, 1000.00m, null, 1, "Practise with Air-crafts" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2d193e5-e429-4ea4-a4ff-c01c8ada689c", "AQAAAAEAACcQAAAAEHS7SHtM5sr3pOkRYc3oUeepPGr6zt5VIiTpu9Tj+K5s07qxqPnNMavQx3XX4aBxxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79c1103a-c6d5-4c9d-b637-3886395afb2d", "AQAAAAEAACcQAAAAEM4tWyUZf6jM5NPy/Q0smqTUUeeJzezldNa+Z3rgiaea/mvUtnuJFnhH4tHt1DSrGA==" });
        }
    }
}
