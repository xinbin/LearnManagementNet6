using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnManagement.Web.Data.Migrations
{
    public partial class addPeriodToLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bc2a98a-cdef-4c76-b93c-a5bc77d32c34", "AQAAAAEAACcQAAAAELMqrj78x+IlVitzNB5OqKYCWW4cNy30tyXLxMQt4+P0fmZmB1dMGLOpyztViIJ2jA==", "98b6f092-6274-4f00-9688-c096b82e2e84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f105b15-76a3-44eb-9891-776f58352674",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deb50a07-7877-43a0-9380-e50161e4384c", "AQAAAAEAACcQAAAAECIO+ifZRYvND/h18kFrPtnb15Rh1f9nMSH2PuRUuE/TxoDYArNwEEKgFhHUEGXKgA==", "c3039ed8-5dac-4070-91e2-a21344f93390" });
        }
    }
}
