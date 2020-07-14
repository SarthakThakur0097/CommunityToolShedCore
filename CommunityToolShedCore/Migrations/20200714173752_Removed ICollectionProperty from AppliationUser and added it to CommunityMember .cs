using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityToolShedCore.Migrations
{
    public partial class RemovedICollectionPropertyfromAppliationUserandaddedittoCommunityMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToolCommunityMembers_AspNetUsers_ApplicationUserId",
                table: "ToolCommunityMembers");

            migrationBuilder.DropIndex(
                name: "IX_ToolCommunityMembers_ApplicationUserId",
                table: "ToolCommunityMembers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10bcfe28-7fcf-41b8-a322-eff88a09d9e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2697cf1c-8565-4427-ba36-a424cb4727f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da1ecab1-c330-4c5b-a7a0-d34eb002f11f");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "ToolCommunityMembers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3db6ef55-c847-4da0-8134-807a65df599a", 0, "ffd21312-b58a-434e-901e-6194ee1108d9", "NeoAnderson@sarthakthakur.com", false, "Neo", "Anderson", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "f1d9cd7d-1ec5-4137-88e3-6ea74b5f38af", false, "NeoAnderson@sarthakthakur.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "20912440-f21e-40a3-ab79-ace04d2719fa", 0, "56bbd792-2363-496a-a50e-26a8523169d1", "DaveWill@sarthakthakur.com", false, "Dave", "Will", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "2f4e8870-be26-41b8-9829-680091c76e80", false, "DaveWill@sarthakthakur.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5d5c0737-a685-4244-b7af-2d08be56b305", 0, "31416938-e5b3-431f-bee8-3fceed9a0423", "SandraJosh@sarthakthakur.com", false, "Sandra", "Josh", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "32279151-8f59-4b28-97ca-0304c7241ba0", false, "SandraJosh@sarthakthakur.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20912440-f21e-40a3-ab79-ace04d2719fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3db6ef55-c847-4da0-8134-807a65df599a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d5c0737-a685-4244-b7af-2d08be56b305");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "ToolCommunityMembers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "da1ecab1-c330-4c5b-a7a0-d34eb002f11f", 0, "d59f411c-5ffa-4eed-8b37-b76b5b989220", "NeoAnderson@sarthakthakur.com", false, "Neo", "Anderson", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "327c710e-8c29-4da5-b78e-ef9d0c46e497", false, "NeoAnderson@sarthakthakur.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "10bcfe28-7fcf-41b8-a322-eff88a09d9e9", 0, "4f2428a8-cbe2-4f68-8140-427999aa13f4", "DaveWill@sarthakthakur.com", false, "Dave", "Will", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "f5577e74-ef18-49ee-a671-5006bf4f4673", false, "DaveWill@sarthakthakur.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2697cf1c-8565-4427-ba36-a424cb4727f5", 0, "6fb755a7-1830-4e5e-b44e-1f1dee4ce9f3", "SandraJosh@sarthakthakur.com", false, "Sandra", "Josh", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "15fee6cf-be22-499c-9be2-da8eeca6d2ab", false, "SandraJosh@sarthakthakur.com" });

            migrationBuilder.CreateIndex(
                name: "IX_ToolCommunityMembers_ApplicationUserId",
                table: "ToolCommunityMembers",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToolCommunityMembers_AspNetUsers_ApplicationUserId",
                table: "ToolCommunityMembers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
