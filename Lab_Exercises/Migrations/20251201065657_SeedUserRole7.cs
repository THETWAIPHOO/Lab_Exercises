using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab_Exercises.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "f23f8038-6229-420c-a4e2-887aba8a9315");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "ad3c5f0c-fb7d-4c84-8b1a-3fe172876b47");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6fa2613-fce3-4dc1-b756-9d957f212da5", "AQAAAAIAAYagAAAAEGHnnWHYmd4M8+HcojlxDRaAcGKuHhVaJ7f71rENR4HdO0yg1Ku/FjDP3Wsq0D/Zsg==", "e12bb09d-b9de-41df-90be-bb4b9319cb1e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "752875de-ea57-4afa-9770-b7f84cecc745");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "dd606b6e-31cd-4d1f-a474-6941a74aeee8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10c6d945-3490-417f-9713-ba99a6393abd", "AQAAAAIAAYagAAAAEFAAsID1dwsKsotyYbJb1keijgy6SPFbIcG9VnSGw+ZNUA5bSB2Ks/JQP2KgmNe60Q==", "a8fa71b1-1ad6-4a08-9b71-fa66a39e7496" });
        }
    }
}
