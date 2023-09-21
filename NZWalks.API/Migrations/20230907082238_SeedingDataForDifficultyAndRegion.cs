using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataForDifficultyAndRegion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("62880fd8-c0eb-4af8-8313-43dcb87581ae"), "Medium" },
                    { new Guid("85a475dc-7179-4e62-87e4-97e50846089c"), "Easy" },
                    { new Guid("b5e79ee9-126d-421d-beda-4764b359fff6"), "Hard" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("365c016a-8771-47bc-a434-6b75946f985b"), "WGN", "Wellington", "https://tec.edu.vn/wp-content/uploads/2022/12/179180-Wellington.jpg" },
                    { new Guid("47f44064-be12-464b-a4d6-bd64fba761f5"), "AKL", "Auckland", "https://a.cdn-hotels.com/gdcs/production133/d294/4e4195aa-b9ca-42cd-923f-e8a65c8c5c7b.jpg?impolicy=fcrop&w=800&h=533&q=medium" },
                    { new Guid("488ccb62-37a8-4e23-88bc-4ba742cb53dd"), "NSN", "Nelson", "https://d27k8xmh3cuzik.cloudfront.net/wp-content/uploads/2018/11/Places-to-Visit-in-Nelson-OG-min.jpg" },
                    { new Guid("c9eeb2a5-5f77-47a8-8625-907d7921d763"), "NSN", "Southland", "https://www.newzealand.com/assets/Tourism-NZ/Other/img-1536012255-9458-6899-2653996258_835f78284f_o__aWxvdmVrZWxseQo_CropResizeWzEyMDAsNjMwLDc1LCJqcGciXQ.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("62880fd8-c0eb-4af8-8313-43dcb87581ae"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("85a475dc-7179-4e62-87e4-97e50846089c"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("b5e79ee9-126d-421d-beda-4764b359fff6"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("365c016a-8771-47bc-a434-6b75946f985b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("47f44064-be12-464b-a4d6-bd64fba761f5"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("488ccb62-37a8-4e23-88bc-4ba742cb53dd"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c9eeb2a5-5f77-47a8-8625-907d7921d763"));
        }
    }
}
