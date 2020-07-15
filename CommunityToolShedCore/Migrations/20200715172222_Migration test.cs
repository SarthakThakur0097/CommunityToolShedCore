using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityToolShedCore.Migrations
{
    public partial class Migrationtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "33c3aa85-81fe-4975-afb6-648bfd41b2cf", 0, "a405aa34-3c91-43f9-ab63-30d1c99e45ee", "NeoAnderson@sarthakthakur.com", false, "Neo", "Anderson", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "e7eec166-8ee6-4bd1-ac0f-bf82db306a92", false, "NeoAnderson@sarthakthakur.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "858f456c-52c4-4c37-bc09-a16a309f41ae", 0, "ee15f985-eea8-4c03-8fff-05dc55b0d81d", "DaveWill@sarthakthakur.com", false, "Dave", "Will", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "efb109c9-90dc-4dd1-833c-0795571bcd8e", false, "DaveWill@sarthakthakur.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e5c60e0a-b422-450e-ad25-0a8d43613237", 0, "f7d768dd-2e39-4a97-aa3b-c9bded8805f2", "SandraJosh@sarthakthakur.com", false, "Sandra", "Josh", false, null, null, null, "AQAAAAEAACcQAAAAEKvZsx7i2jprhRAFzfF9Vrifk2nnEawZiT0UJ7DBTAmWezV0vpp74XaEGdweV957LA==", null, false, "aa930722-8fcb-4ea5-858d-963c214d5b07", false, "SandraJosh@sarthakthakur.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33c3aa85-81fe-4975-afb6-648bfd41b2cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "858f456c-52c4-4c37-bc09-a16a309f41ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5c60e0a-b422-450e-ad25-0a8d43613237");

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
        }
    }
}
