using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab_Exercises.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarModel",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 30, 17, 25, 0, 0, DateTimeKind.Utc), "i4", "System", new DateTime(2025, 11, 30, 17, 25, 0, 0, DateTimeKind.Utc) },
                    { 2, "System", new DateTime(2025, 11, 30, 17, 25, 0, 0, DateTimeKind.Utc), "X5", "System", new DateTime(2025, 11, 30, 17, 25, 0, 0, DateTimeKind.Utc) },
                    { 3, "System", new DateTime(2025, 11, 30, 17, 25, 0, 0, DateTimeKind.Utc), "Prius", "System", new DateTime(2025, 11, 30, 17, 25, 0, 0, DateTimeKind.Utc) },
                    { 4, "System", new DateTime(2025, 11, 30, 17, 25, 0, 0, DateTimeKind.Utc), "C-HR", "System", new DateTime(2025, 11, 30, 17, 25, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 30, 17, 19, 50, 0, DateTimeKind.Utc), "Black", "System", new DateTime(2025, 11, 30, 17, 19, 50, 0, DateTimeKind.Utc) },
                    { 2, "System", new DateTime(2025, 11, 30, 17, 19, 50, 0, DateTimeKind.Utc), "Blue", "System", new DateTime(2025, 11, 30, 17, 19, 50, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 30, 17, 19, 50, 0, DateTimeKind.Utc), "BMW", "System", new DateTime(2025, 11, 30, 17, 19, 50, 0, DateTimeKind.Utc) },
                    { 2, "System", new DateTime(2025, 11, 30, 17, 19, 50, 0, DateTimeKind.Utc), "Toyota", "System", new DateTime(2025, 11, 30, 17, 19, 50, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
