using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnManagement.Web.Data.Migrations
{
    public partial class updateUsersCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b159f10-79f3-44eb-9891-776f58352674",
                column: "ConcurrencyStamp",
                value: "143a64c4-b8c9-46d0-913e-944589c40435");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b159f10-79f3-44eb-9891-776f58352675",
                column: "ConcurrencyStamp",
                value: "3416bb50-d9a3-486c-82b2-41dcaa7fe11f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b159f10-76a3-9891-44eb-776f58352674",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0bc2a98a-cdef-4c76-b93c-a5bc77d32c34", true, "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAELMqrj78x+IlVitzNB5OqKYCWW4cNy30tyXLxMQt4+P0fmZmB1dMGLOpyztViIJ2jA==", "98b6f092-6274-4f00-9688-c096b82e2e84", "admin@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f105b15-76a3-44eb-9891-776f58352674",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "deb50a07-7877-43a0-9380-e50161e4384c", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAECIO+ifZRYvND/h18kFrPtnb15Rh1f9nMSH2PuRUuE/TxoDYArNwEEKgFhHUEGXKgA==", "c3039ed8-5dac-4070-91e2-a21344f93390", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b159f10-79f3-44eb-9891-776f58352674",
                column: "ConcurrencyStamp",
                value: "7c9e4c21-ff85-41f0-baf2-21bac675354e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b159f10-79f3-44eb-9891-776f58352675",
                column: "ConcurrencyStamp",
                value: "fcc3fdd3-4732-4c1a-accf-4500ebab4701");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b159f10-76a3-9891-44eb-776f58352674",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5a6a901e-ff11-4f8b-a1a6-a8d4b5c7cf8e", false, null, "AQAAAAEAACcQAAAAEIe97YPyOt1SmYBeK5oZJXk/Q8NugFMnPwtb4m6fdqzCV9K8VuXgODKZMYTtetZPCw==", "53a22e8d-2e83-4455-bc48-8ca06a3a418d", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f105b15-76a3-44eb-9891-776f58352674",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fa38f7c8-4fb0-4dfc-9f41-1cf7cfe5f6f2", false, null, "AQAAAAEAACcQAAAAEGhiTlyAB/OmYpVXTn4pgVJQRFFiWXi0uHHnLjTA5hYXBM7NJ2rA73cdWM6599mbDw==", "71e21434-04a1-43d9-b553-43ed502ee32c", null });
        }
    }
}
