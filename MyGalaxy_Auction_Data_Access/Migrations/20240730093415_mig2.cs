using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGalaxy_Auction_Data_Access.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "PaymentHistories",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IsActive",
                table: "PaymentHistories",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3319), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3327), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3330), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3333), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3336), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3338), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3341), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3344), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3347), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3350), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3353), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3356), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3359), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3362), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3364), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3367), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3370), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3373), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3376), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3379), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3382), new DateTime(2024, 7, 30, 11, 47, 51, 436, DateTimeKind.Local).AddTicks(3381) });
        }
    }
}
