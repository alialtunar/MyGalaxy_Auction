using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGalaxy_Auction_Data_Access.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "PaymentHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StripePaymentIntentId",
                table: "PaymentHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9481), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9510), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9513), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9519), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9531), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9536), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9539), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9542), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9545), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9548), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9551), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9554), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9557), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9561), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9564), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9567), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9573), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9579), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9582), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9585), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9588), new DateTime(2024, 8, 1, 18, 17, 39, 173, DateTimeKind.Local).AddTicks(9587) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "PaymentHistories");

            migrationBuilder.DropColumn(
                name: "StripePaymentIntentId",
                table: "PaymentHistories");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1728), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1755), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1764), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1772), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1785), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1795), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1807), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1817), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1826), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1835), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1845), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1855), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1865), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1873), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1887), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1895), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1903), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1911), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1920), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1926), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1932), new DateTime(2024, 7, 30, 12, 34, 14, 624, DateTimeKind.Local).AddTicks(1931) });
        }
    }
}
