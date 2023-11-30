using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b159f10-79f3-44eb-9891-776f58352674",
                column: "ConcurrencyStamp",
                value: "96345574-14c0-409f-9471-196cbb64f61c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b159f10-79f3-44eb-9891-776f58352675",
                column: "ConcurrencyStamp",
                value: "4a56766c-a237-48dc-b75f-bf87ac7d0d53");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b159f10-76a3-9891-44eb-776f58352674",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45df4a67-68d7-4b5e-ac13-a25aba641532", "AQAAAAEAACcQAAAAELwLkpg9L2r0WYSO4cgK90d4zAAcPdJKRKllZUuhp/u2QQ9nCj9PkTMki3ySV14AiA==", "1c8e7e1c-905c-4245-8a1c-4220f7e7bb13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f105b15-76a3-44eb-9891-776f58352674",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32047c65-5942-4c60-85c2-094b17c6fe39", "AQAAAAEAACcQAAAAEKRVhgym87KKIfLUCJlV0XkNCnfCR9Gur6sZIxQDz2CJtCbFYPZjccCoaAMj48yxag==", "a25c058b-0d04-4740-ad73-15bcc5da18bf" });
        }
    }
}
