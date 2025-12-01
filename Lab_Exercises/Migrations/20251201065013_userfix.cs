using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab_Exercises.Migrations
{
    /// <inheritdoc />
    public partial class userfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "f95df49e-272e-4410-acca-4a5a3a2f9b42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "d020e134-5d4a-4500-ae1b-952c9c497a67");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20a5db81-6736-4480-bf0c-ec59660c6c3a", "P@ssword1", "4f0bd12c-637d-4398-9591-fd5a2d3f0f93" });
        }
    }
}
