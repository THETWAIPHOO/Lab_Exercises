using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab_Exercises.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "d2c90356-5eb0-4b8c-b133-1a0353088f5d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "cfe9f657-7c44-480e-9364-dd6ffa4f1c08");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "818c1282-0221-4a31-9654-26a0af0c846c", "P@ssword1", "39d23e72-9d05-4b52-b471-d27b794fd8cb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "9c0ccad2-dff1-40fe-94a6-a494366d39eb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "d6d7d73b-40d4-4a52-97db-ecbcd4637115");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f16f6bf-1ac9-4832-b3d0-8d37b32dee96", "AQAAAAIAAYagAAAAEBk0z13Ra4TOLF03xMGXSRiPXL7TNBfQYfT6cIbGpsoBKaruCW3TyoHFtVEvh+Kevg==", "a3976e66-aee7-49cb-b952-3a8b7de59446" });
        }
    }
}
