using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab_Exercises.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "a4eb0a1e-738b-46c5-a68b-2cea2c10e35c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "a3b2b19e-8c1a-470d-869b-177377516574");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dce7d8d7-90b9-49e2-a95c-bfbd9c04ec44", "AQAAAAIAAYagAAAAEJd39k6vFb+WT48NC93dISSuX6cdpvaI8/5T8odtt7L+/RsI/du3QeSmCOr8vKGBYQ==", "4949371e-5585-4cec-9316-42e1ab9d2c6b" });
        }
    }
}
