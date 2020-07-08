using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityToolShedCore.Migrations
{
    public partial class CommunityMemberChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommunityMembers_AspNetUsers_ApplicationUserId",
                table: "CommunityMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_CommunityMembers_AspNetUsers_MemberId",
                table: "CommunityMembers");

            migrationBuilder.DropIndex(
                name: "IX_CommunityMembers_MemberId",
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
                name: "MemberId",
                table: "CommunityMembers");

            migrationBuilder.AlterColumn<int>(
                name: "CommunityId",
                table: "CommunityMembers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "CommunityMembers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a29c434f-99c4-4cb3-a75a-42a4e31d519e", 0, "1f866947-ed80-4768-afdc-5d6c13a12cee", "NeoAnderson@sarthakthakur.com", false, "Neo", "Anderson", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "2c1625b1-8de5-47f5-92a6-852aff823eff", false, "NeoAnderson@sarthakthakur.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "386d073d-b0c7-40c5-9cfa-5552106f6487", 0, "29cac80e-4e03-460c-93d7-ef3ce4954395", "DaveWill@sarthakthakur.com", false, "Dave", "Will", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "51b0c134-4515-4476-8d34-3f0f872d7892", false, "DaveWill@sarthakthakur.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "81583477-b648-4d00-a0b4-45c1e38d237f", 0, "065c738b-6922-49e0-88c9-e3e226bd763c", "SandraJosh@sarthakthakur.com", false, "Sandra", "Josh", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "7e0ecf85-d473-47c4-a30b-351e12994622", false, "SandraJosh@sarthakthakur.com" });

            migrationBuilder.CreateIndex(
                name: "IX_CommunityMembers_ApplicationUserId1",
                table: "CommunityMembers",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CommunityMembers_AspNetUsers_ApplicationUserId",
                table: "CommunityMembers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommunityMembers_AspNetUsers_ApplicationUserId1",
                table: "CommunityMembers",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommunityMembers_AspNetUsers_ApplicationUserId",
                table: "CommunityMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_CommunityMembers_AspNetUsers_ApplicationUserId1",
                table: "CommunityMembers");

            migrationBuilder.DropIndex(
                name: "IX_CommunityMembers_ApplicationUserId1",
                table: "CommunityMembers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "386d073d-b0c7-40c5-9cfa-5552106f6487");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81583477-b648-4d00-a0b4-45c1e38d237f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a29c434f-99c4-4cb3-a75a-42a4e31d519e");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "CommunityMembers");

            migrationBuilder.AlterColumn<int>(
                name: "CommunityId",
                table: "CommunityMembers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "MemberId",
                table: "CommunityMembers",
                type: "nvarchar(450)",
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
                name: "IX_CommunityMembers_MemberId",
                table: "CommunityMembers",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommunityMembers_AspNetUsers_ApplicationUserId",
                table: "CommunityMembers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommunityMembers_AspNetUsers_MemberId",
                table: "CommunityMembers",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
