using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetBreeders.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initialDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Breedings",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "Email", "ImageUrl", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Phone", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 14, 14, 28, 18, 85, DateTimeKind.Local).AddTicks(7836), null, "Proven breeding", "RoyalGoldens@petbreeders.com", "", null, null, null, null, "RoyalGoldens", "123456789", 1 },
                    { 2, new DateTime(2023, 2, 14, 14, 28, 18, 85, DateTimeKind.Local).AddTicks(7839), null, "Proven breeding", "SnowySamoyeds@petbreeders.com", "", null, null, null, null, "SnowySamoyeds", "111222333", 1 }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "BreedingId", "City", "Created", "CreatedBy", "FlatNumber", "HouseNumber", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, 1, "Warsaw", new DateTime(2023, 2, 14, 14, 28, 18, 85, DateTimeKind.Local).AddTicks(7850), null, "1", "42", null, null, null, null, 1, "Mickiewicza", "11-214" },
                    { 2, 2, "Cracow", new DateTime(2023, 2, 14, 14, 28, 18, 85, DateTimeKind.Local).AddTicks(7853), null, "8", "115", null, null, null, null, 1, "Brzozowa", "45-124" }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "BreedingId", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "ReceivedDate", "StatusId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 2, 14, 14, 28, 18, 85, DateTimeKind.Local).AddTicks(7888), null, "Związek Kynologiczny w Polsce", null, null, null, null, "ZKwP", new DateTime(2023, 2, 14, 14, 28, 18, 85, DateTimeKind.Local).AddTicks(7886), 1 },
                    { 2, 2, new DateTime(2023, 2, 14, 14, 28, 18, 85, DateTimeKind.Local).AddTicks(7891), null, "Związek Kynologiczny w Polsce", null, null, null, null, "ZKwP", new DateTime(2023, 2, 14, 14, 28, 18, 85, DateTimeKind.Local).AddTicks(7889), 1 }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "BirthDate", "Breed", "BreedingId", "Color", "Created", "CreatedBy", "Description", "ImageUrl", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 14, 14, 28, 18, 85, DateTimeKind.Local).AddTicks(7700), "Golden Retriever", 1, "Creamy", new DateTime(2023, 2, 14, 14, 28, 18, 85, DateTimeKind.Local).AddTicks(7741), null, "Confident, friendly", "", null, null, null, null, 1, "Dog" },
                    { 2, new DateTime(2023, 2, 14, 14, 28, 18, 85, DateTimeKind.Local).AddTicks(7744), "Samoyed", 2, "White", new DateTime(2023, 2, 14, 14, 28, 18, 85, DateTimeKind.Local).AddTicks(7745), null, "Confident, brave", "", null, null, null, null, 1, "Dog" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Breedings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Breedings",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
