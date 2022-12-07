using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASA.Infrastructure.Migrations
{
    public partial class GREATSUCCESS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2109249d-79dd-4dda-9eed-a8cd95cf19d9", "AQAAAAEAACcQAAAAENmzPkeJh1qx/Tbcyl4axAkko2+X2KZLDdEeqpkgBz7ot9QqAPX+jgGPlgJBrzni9g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9361c2a2-7f61-428f-a432-1711876da89e", "AQAAAAEAACcQAAAAEFPEG4QsaWZeXD3dUTPADrOHqn8Aa9HqaDeXT6OatRVXE3ZayKTTkgFAt5gn4A4xfA==" });
        }
    }
}
