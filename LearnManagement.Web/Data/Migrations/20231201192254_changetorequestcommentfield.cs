using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnManagement.Web.Data.Migrations
{
    public partial class changetorequestcommentfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b159f10-79f3-44eb-9891-776f58352674",
                column: "ConcurrencyStamp",
                value: "794fc6ad-3f0d-4d7e-b769-084116c5e188");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b159f10-79f3-44eb-9891-776f58352675",
                column: "ConcurrencyStamp",
                value: "f3719821-a4b2-439f-8bd4-72d0ce5f7387");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b159f10-76a3-9891-44eb-776f58352674",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a9794a7-72df-4f2a-9f90-fe45ff15d770", "AQAAAAEAACcQAAAAEID1K+bbq36jcccJUEPRlJGWr9Lc8B0m1i16wczr8sn19NmlkelAg6499UOzX1Ilmg==", "5a8db231-71f4-4c09-9992-af6f05f7a4fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f105b15-76a3-44eb-9891-776f58352674",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbf98730-0499-43c0-8a81-e799f0c9dccc", "AQAAAAEAACcQAAAAEIkHV+3mEAg4/cFo/cceHuMVAbmhhtQ/xRtucPm9v+xEz6rgjANdKEBxwd8BF76ppg==", "8fbae23f-1602-4410-9de2-8718c87f6fb8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b159f10-79f3-44eb-9891-776f58352674",
                column: "ConcurrencyStamp",
                value: "626ed77e-c280-4131-88d4-0b636a2dea78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b159f10-79f3-44eb-9891-776f58352675",
                column: "ConcurrencyStamp",
                value: "5fc82995-48c2-45fa-aad5-113295d525ad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b159f10-76a3-9891-44eb-776f58352674",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ea99c34-ed87-4d83-8fbe-24263a5de731", "AQAAAAEAACcQAAAAEGJ+pSZpT9VmEzG8BYB/phHk/vo3jwFNzNm9rZAhiKo92HVuBBolLdOQG1HBPBFcuw==", "11398712-ef53-48a6-a924-62a32241bf5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f105b15-76a3-44eb-9891-776f58352674",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10ab0a25-d9fc-42fb-91ee-3a3ee9ca16d6", "AQAAAAEAACcQAAAAEM1XkhRK2KGCX3+UE38A9UrPaq5Py4RXeeR0LJ9Nw29qNNoABQHGuySK6qk/oF1nYQ==", "35ff2086-d208-4a4a-b803-18c4261249b4" });
        }
    }
}
