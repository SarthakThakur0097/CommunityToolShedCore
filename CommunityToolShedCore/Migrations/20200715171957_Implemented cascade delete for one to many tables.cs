using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityToolShedCore.Migrations
{
    public partial class Implementedcascadedeleteforonetomanytables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_CommunityMembers_AspNetUsers_ApplicationUserId",
                table: "CommunityMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_CommunityMembers_Communities_CommunityId",
                table: "CommunityMembers");

            migrationBuilder.DropTable(
                name: "ApplicationUserRole");

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

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AspNetUserRoles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUserRoles",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f0127970-0c59-416a-9eab-2723e36e3653", 0, "025897f0-07e2-47fd-ba4b-dee07f4d8acf", "NeoAnderson@sarthakthakur.com", false, "Neo", "Anderson", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "89b7022d-9afe-41c6-8276-381418f62746", false, "NeoAnderson@sarthakthakur.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d576056a-bf12-459a-8735-90a9ae187c93", 0, "69ed9b25-b021-4bbc-9ee8-755b28d22ddd", "DaveWill@sarthakthakur.com", false, "Dave", "Will", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "0224699e-d307-460f-bf74-6c2e14f6161f", false, "DaveWill@sarthakthakur.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8f2c57c9-d31b-4f80-9fd1-8751716006ff", 0, "f0c04475-4a07-45c2-bd05-c3901917d9fc", "SandraJosh@sarthakthakur.com", false, "Sandra", "Josh", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "72528ec6-a109-4aad-8e80-bfccebfb8b28", false, "SandraJosh@sarthakthakur.com" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommunityMembers_AspNetUsers_ApplicationUserId",
                table: "CommunityMembers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommunityMembers_Communities_CommunityId",
                table: "CommunityMembers",
                column: "CommunityId",
                principalTable: "Communities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_CommunityMembers_AspNetUsers_ApplicationUserId",
                table: "CommunityMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_CommunityMembers_Communities_CommunityId",
                table: "CommunityMembers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f2c57c9-d31b-4f80-9fd1-8751716006ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d576056a-bf12-459a-8735-90a9ae187c93");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0127970-0c59-416a-9eab-2723e36e3653");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUserRoles");

            migrationBuilder.CreateTable(
                name: "ApplicationUserRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUserRole_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserRole_ApplicationUserId",
                table: "ApplicationUserRole",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommunityMembers_AspNetUsers_ApplicationUserId",
                table: "CommunityMembers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommunityMembers_Communities_CommunityId",
                table: "CommunityMembers",
                column: "CommunityId",
                principalTable: "Communities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
