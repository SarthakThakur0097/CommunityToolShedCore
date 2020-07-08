using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityToolShedCore.Migrations
{
    public partial class CommunityMembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23caf6bf-ddef-4b36-8434-3c64a5635be8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4dca26bf-11ea-4d18-9dfa-d81d69dd42fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "561201cf-fbe1-4cd3-9740-81638c556224");

            migrationBuilder.CreateTable(
                name: "CommunityMember",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<string>(nullable: true),
                    CommunityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommunityMember_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommunityMember_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "15bcd8c8-0437-4255-9a17-847e8cc461c5", 0, "f66ac84d-6563-4229-9056-5ef97b0db8b1", "NeoAnderson@gmail.com", false, "Neo", "Anderson", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "3f818720-d1a3-461f-8397-23db460c6812", false, "NeoAnderson@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d90fc413-6ea8-43f9-a6fc-77a34123cb10", 0, "b4c56ffe-b6fa-4c8e-a3ca-ad925d01a748", "DaveWill@gmail.com", false, "Dave", "Will", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "cedb3e2a-91c7-438b-8a0c-bf7c1ff87861", false, "DaveWill@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "052419fe-dba0-4474-97ce-c1624d1316a7", 0, "0c4fd100-fb51-4872-becd-8d75aab9a7eb", "SandraJosh@gmail.com", false, "Sandra", "Josh", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "b41b0d4e-4d72-40bf-97ef-e0cca8b8321b", false, "SandraJosh@gmail.com" });

            migrationBuilder.CreateIndex(
                name: "IX_CommunityMember_CommunityId",
                table: "CommunityMember",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityMember_MemberId",
                table: "CommunityMember",
                column: "MemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommunityMember");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "052419fe-dba0-4474-97ce-c1624d1316a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15bcd8c8-0437-4255-9a17-847e8cc461c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d90fc413-6ea8-43f9-a6fc-77a34123cb10");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "23caf6bf-ddef-4b36-8434-3c64a5635be8", 0, "d9746574-548a-405e-ac38-53b935c3bc26", "NeoAnderson@gmail.com", false, "Neo", "Anderson", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "49fc6b1d-aa3d-45a3-b33a-46f04dba8c87", false, "NeoAnderson@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4dca26bf-11ea-4d18-9dfa-d81d69dd42fc", 0, "96f5ea0d-c353-405f-bc3e-60112382faa4", "DaveWill@gmail.com", false, "Dave", "Will", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "f01b41b9-7503-4493-9716-69c339abff73", false, "DaveWill@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "561201cf-fbe1-4cd3-9740-81638c556224", 0, "60af4884-140a-440d-b92f-256f2fca3d2c", "SandraJosh@gmail.com", false, "Sandra", "Josh", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "d17512a3-1917-41fa-a019-c230b3fb1131", false, "SandraJosh@gmail.com" });
        }
    }
}
