using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityToolShedCore.Migrations
{
    public partial class changingPasswordsForSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserRole_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserRole");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d716d249-366b-4578-8361-26d40be03794");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1419bea-179a-4fd4-b317-b09eb98d7887");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8cf649d-99d8-4131-9bb0-1121fc551bfc");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "CommunityMembers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b0ecb515-c530-43ad-b1a4-0cf261ec1b33", 0, "d977edd4-5dea-4007-bdf8-6823c91f4ffa", "NeoAnderson@sarthakthakur.com", false, "Neo", "Anderson", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "803cbb97-d656-4b51-b1aa-d79e23185ea0", false, "NeoAnderson@sarthakthakur.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cecf63dd-3757-4863-b894-507279eda35e", 0, "dc4f560e-b68e-4115-9156-c963e9528465", "DaveWill@sarthakthakur.com", false, "Dave", "Will", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "44e2e8e4-b677-4ae9-8d02-084991b95c57", false, "DaveWill@sarthakthakur.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "33cd15b4-9cf5-417f-903b-45e79315c9d1", 0, "27e3405c-4d4e-4d93-beb6-7e0b909f7d58", "SandraJosh@sarthakthakur.com", false, "Sandra", "Josh", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "80dd898c-3a61-41ec-9729-0d023dd60938", false, "SandraJosh@sarthakthakur.com" });

            migrationBuilder.CreateIndex(
                name: "IX_CommunityMembers_ApplicationUserId",
                table: "CommunityMembers",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserRole_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserRole",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommunityMembers_AspNetUsers_ApplicationUserId",
                table: "CommunityMembers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserRole_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_CommunityMembers_AspNetUsers_ApplicationUserId",
                table: "CommunityMembers");

            migrationBuilder.DropIndex(
                name: "IX_CommunityMembers_ApplicationUserId",
                table: "CommunityMembers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33cd15b4-9cf5-417f-903b-45e79315c9d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0ecb515-c530-43ad-b1a4-0cf261ec1b33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cecf63dd-3757-4863-b894-507279eda35e");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "CommunityMembers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d716d249-366b-4578-8361-26d40be03794", 0, "f764240d-6411-4f12-9f62-f010cc031fe6", "NeoAnderson@gmail.com", false, "Neo", "Anderson", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "81858c15-60a6-41d5-9f14-e53da6e80271", false, "NeoAnderson@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e8cf649d-99d8-4131-9bb0-1121fc551bfc", 0, "61cbff59-a160-4448-9759-ed5147b733e6", "DaveWill@gmail.com", false, "Dave", "Will", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "f0557c72-79a0-408b-8799-6f9415d8aaeb", false, "DaveWill@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e1419bea-179a-4fd4-b317-b09eb98d7887", 0, "7d8c5a0e-53e7-4489-bf15-e1850553ed51", "SandraJosh@gmail.com", false, "Sandra", "Josh", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "9711b7e4-1b4e-4c61-a6b3-a285a2ffd1be", false, "SandraJosh@gmail.com" });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserRole_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserRole",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
