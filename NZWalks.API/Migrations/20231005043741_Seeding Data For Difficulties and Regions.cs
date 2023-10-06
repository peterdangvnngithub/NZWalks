using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataForDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2b7ef3e5-2a5e-4f63-8e06-1adcc0833591"), "Hard" },
                    { new Guid("345e77a3-6eba-40d2-bb34-c34bdfc911ae"), "Easy" },
                    { new Guid("382ac86b-d290-44cd-8dfa-681de06b3eaf"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("a5b6bc37-e12f-47c1-872a-80e01c02400e"), "WLG", "Wellington Region", "https://www.shutterstock.com/image-vector/wellington-new-zealand-flat-icon-250nw-742465774.jpg" },
                    { new Guid("fa044b05-50b6-4feb-9c85-5f9ed5c76b6a"), "AKL", "Auckland", "https://c8.alamy.com/comp/P26WFD/auckland-new-zealand-line-icon-with-red-ribbon-isolated-on-white-auckland-landmark-emblem-print-label-symbol-auckland-tv-tower-pictogram-w-P26WFD.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("2b7ef3e5-2a5e-4f63-8e06-1adcc0833591"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("345e77a3-6eba-40d2-bb34-c34bdfc911ae"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("382ac86b-d290-44cd-8dfa-681de06b3eaf"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a5b6bc37-e12f-47c1-872a-80e01c02400e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("fa044b05-50b6-4feb-9c85-5f9ed5c76b6a"));
        }
    }
}
