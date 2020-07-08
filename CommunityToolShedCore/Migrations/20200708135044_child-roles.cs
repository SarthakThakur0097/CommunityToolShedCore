using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityToolShedCore.Migrations
{
    public partial class childroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "ApplicationUserRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(nullable: false),
                    RoleId = table.Column<long>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUserRole_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0e7f96ff-7991-41e2-a6bd-426ce78456d1", 0, "d14bb5eb-d1ad-4ed6-97be-f9768ac4e38c", "NeoAnderson@gmail.com", false, "Neo", "Anderson", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "10ea95eb-1503-44f2-b7cd-f159023ab4b8", false, "NeoAnderson@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d0032824-5791-4774-b83c-58839c9cf2a0", 0, "6c01d4bd-8ce6-40cc-b761-5356ed0f6ef9", "DaveWill@gmail.com", false, "Dave", "Will", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "5067a29d-5557-4d8f-9d99-2116f12503ad", false, "DaveWill@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1be6d3fa-0401-42b9-8140-01f2f6ea3478", 0, "fca458d1-c4f6-42f9-be8c-01b9ba00a017", "SandraJosh@gmail.com", false, "Sandra", "Josh", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "3eb4a63b-b969-4c2d-8fe6-d70a2226448a", false, "SandraJosh@gmail.com" });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserRole_ApplicationUserId",
                table: "ApplicationUserRole",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserRole");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e7f96ff-7991-41e2-a6bd-426ce78456d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1be6d3fa-0401-42b9-8140-01f2f6ea3478");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0032824-5791-4774-b83c-58839c9cf2a0");

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
        }
    }
}
