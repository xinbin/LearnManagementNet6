using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnManagement.Web.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5b159f10-79f3-44eb-9891-776f58352674", "7c9e4c21-ff85-41f0-baf2-21bac675354e", "User", "USER" },
                    { "5b159f10-79f3-44eb-9891-776f58352675", "fcc3fdd3-4732-4c1a-accf-4500ebab4701", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5b159f10-76a3-9891-44eb-776f58352674", 0, "5a6a901e-ff11-4f8b-a1a6-a8d4b5c7cf8e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "Admin", "Lastname", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEIe97YPyOt1SmYBeK5oZJXk/Q8NugFMnPwtb4m6fdqzCV9K8VuXgODKZMYTtetZPCw==", null, false, "53a22e8d-2e83-4455-bc48-8ca06a3a418d", "", false, null },
                    { "9f105b15-76a3-44eb-9891-776f58352674", 0, "fa38f7c8-4fb0-4dfc-9f41-1cf7cfe5f6f2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEGhiTlyAB/OmYpVXTn4pgVJQRFFiWXi0uHHnLjTA5hYXBM7NJ2rA73cdWM6599mbDw==", null, false, "71e21434-04a1-43d9-b553-43ed502ee32c", "", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5b159f10-79f3-44eb-9891-776f58352675", "5b159f10-76a3-9891-44eb-776f58352674" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5b159f10-79f3-44eb-9891-776f58352674", "9f105b15-76a3-44eb-9891-776f58352674" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5b159f10-79f3-44eb-9891-776f58352675", "5b159f10-76a3-9891-44eb-776f58352674" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5b159f10-79f3-44eb-9891-776f58352674", "9f105b15-76a3-44eb-9891-776f58352674" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b159f10-79f3-44eb-9891-776f58352674");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b159f10-79f3-44eb-9891-776f58352675");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b159f10-76a3-9891-44eb-776f58352674");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f105b15-76a3-44eb-9891-776f58352674");
        }
    }
}
