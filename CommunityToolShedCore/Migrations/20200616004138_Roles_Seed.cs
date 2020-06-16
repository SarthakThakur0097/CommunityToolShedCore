using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityToolShedCore.Migrations
{
    public partial class Roles_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3591d691-0499-428c-9aa8-e244a91f8fdc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40730a25-6374-41a8-8455-d01663be34fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "985f5838-eb4f-4f1d-8dd9-8431e89448da");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "896e80b0-87e5-4327-bcfc-73bf513c13eb", 0, "b0e5eb66-60cc-43c9-87cb-5edc9f378c26", "NeoAnderson@gmail.com", false, "Neo", "Anderson", false, null, null, null, null, null, false, "41343b6f-96e5-4e67-a127-2d4f740ebff0", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c4eaef29-15da-4256-a1e4-4057f7091f14", 0, "d53b4c5f-9aed-445e-8b7b-fa7cb15b099c", "DaveWill@gmail.com", false, "Dave", "Will", false, null, null, null, null, null, false, "d88ab08e-9617-4d90-9c92-0ddcbdf55c19", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a3796b18-38ba-486f-8d18-fca6ed37b620", 0, "77aaf44f-130b-46c5-a2fe-7dea97f0aa53", "SandraJosh@gmail.com", false, "Sandra", "Josh", false, null, null, null, null, null, false, "149a0d79-bc13-4820-8566-ed74711595cc", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "896e80b0-87e5-4327-bcfc-73bf513c13eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3796b18-38ba-486f-8d18-fca6ed37b620");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4eaef29-15da-4256-a1e4-4057f7091f14");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "985f5838-eb4f-4f1d-8dd9-8431e89448da", 0, "7eefce2c-d2cc-4921-af86-f9e4a747c79c", "NeoAnderson@gmail.com", false, "Neo", "Anderson", false, null, null, null, null, null, false, "12c7d45f-7eaa-45f5-bee1-71df1c471966", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "40730a25-6374-41a8-8455-d01663be34fe", 0, "8fabe171-2f3a-47d1-97bd-9a7a13fbb648", "DaveWill@gmail.com", false, "Dave", "Will", false, null, null, null, null, null, false, "5b838a75-55c7-4d03-91e3-b59e338996e1", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3591d691-0499-428c-9aa8-e244a91f8fdc", 0, "943af0d7-da7a-492d-89d4-25b408135c83", "SandraJosh@gmail.com", false, "Sandra", "Josh", false, null, null, null, null, null, false, "ded89b1e-7478-4256-9b69-c0fe78c80288", false, null });
        }
    }
}
