using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityToolShedCore.Migrations
{
    public partial class changeClaimStrings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dd44c-2891-4ba6-8141-d79ee87274ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f12f79b3-40a8-460b-a444-0b89dc90b97c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7ff93a8-2bb4-4607-8264-d32788a68c09");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a0ecb766-21ba-4a03-8f48-5b87eca955f7", 0, "3ccbc52b-b1cd-4614-a74f-d82a02a45ddd", "NeoAnderson@gmail.com", false, "Neo", "Anderson", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "85605418-18d0-4a2b-a99d-58cbb81a7223", false, "NeoAnderson@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "497cd003-0abe-4a5d-8cdf-85d0c75ba587", 0, "cdabd821-404a-4634-8727-0e0b2a0f309e", "DaveWill@gmail.com", false, "Dave", "Will", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "a313289e-f3f8-433c-9abd-70b6c9d3d73a", false, "DaveWill@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5c966cf9-be28-4eca-a85e-5fdadde071e5", 0, "4a4ebf2e-a0fb-479a-97b4-93ad5942bda6", "SandraJosh@gmail.com", false, "Sandra", "Josh", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "c8660330-4535-42f6-8ea6-c4f5c52f4a6c", false, "SandraJosh@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "497cd003-0abe-4a5d-8cdf-85d0c75ba587");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c966cf9-be28-4eca-a85e-5fdadde071e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0ecb766-21ba-4a03-8f48-5b87eca955f7");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e18dd44c-2891-4ba6-8141-d79ee87274ea", 0, "fe585dff-0a0b-4c94-af9e-bdefc5625f43", "NeoAnderson@gmail.com", false, "Neo", "Anderson", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "2be4b894-71fb-4173-a937-1ca2162cf2bb", false, "NeoAnderson@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f7ff93a8-2bb4-4607-8264-d32788a68c09", 0, "9ccc332f-e408-467b-b479-adb362bc45c0", "DaveWill@gmail.com", false, "Dave", "Will", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "8d6a15c3-4691-4089-bb27-b52ae3bbc6ff", false, "DaveWill@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f12f79b3-40a8-460b-a444-0b89dc90b97c", 0, "ae34ded5-d89a-4d78-96d4-598923420013", "SandraJosh@gmail.com", false, "Sandra", "Josh", false, null, null, null, "AQAAAAEAACcQAAAAELq6+1vPzbk3Yo63sjNIa44iVvgombBvM0FCaj9vt7hHXWhaVI+ysn3URyl3jkx8kg==", null, false, "ad99ceb9-4fb2-4658-b212-fe9efb9fe101", false, "SandraJosh@gmail.com" });
        }
    }
}
