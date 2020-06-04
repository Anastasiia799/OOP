using Microsoft.EntityFrameworkCore.Migrations;

namespace TRASH.WebService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TRASHs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    YardName = table.Column<string>(nullable: true),
                    YardType = table.Column<string>(nullable: true),
                    YardArea = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRASHs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 1L, "18", "Контейнерная площадка № 1987645", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 28L, "8", "Контейнерная площадка № 1987685", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 29L, "9", "Контейнерная площадка № 1987686", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 30L, "6", "Контейнерная площадка № 1987687", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 31L, "13", "Контейнерная площадка № 1987688", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 32L, "6", "Контейнерная площадка № 1987689", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 33L, "6", "Контейнерная площадка № 1987690", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 34L, "14", "Контейнерная площадка № 1987691", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 35L, "7", "Контейнерная площадка № 1987692", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 36L, "10", "Контейнерная площадка № 1987693", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 37L, "32", "Контейнерная площадка № 1987696", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 38L, "14", "Контейнерная площадка № 1987697", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 39L, "8", "Контейнерная площадка № 1987698", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 40L, "16", "Контейнерная площадка № 1987699", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 41L, "14", "Контейнерная площадка № 1987700", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 42L, "9", "Контейнерная площадка № 1987702", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 43L, "7", "Контейнерная площадка № 1987703", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 44L, "12", "Контейнерная площадка № 1987704", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 45L, "14", "Контейнерная площадка № 1987705", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 46L, "10", "Контейнерная площадка № 1987707", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 47L, "9", "Контейнерная площадка № 1987708", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 48L, "4", "Контейнерная площадка № 1987709", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 27L, "23", "Контейнерная площадка № 1987684", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 26L, "16", "Контейнерная площадка № 1987682", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 25L, "6", "Контейнерная площадка № 1987681", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 24L, "7", "Контейнерная площадка № 1987680", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 2L, "16.25", "Контейнерная площадка № 1987649", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 3L, "10.4", "Контейнерная площадка № 1987653", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 4L, "16.25", "Контейнерная площадка № 1987654", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 5L, "280", "Контейнерная площадка № 1987655", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 6L, "13", "Контейнерная площадка № 1987656", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 7L, "13", "Контейнерная площадка № 1987659", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 8L, "10", "Контейнерная площадка № 1987660", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 9L, "21", "Контейнерная площадка № 1987661", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 10L, "11", "Контейнерная площадка № 1987662", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 11L, "16", "Контейнерная площадка № 1987663", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 49L, "7", "Контейнерная площадка № 1987712", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 12L, "33", "Контейнерная площадка № 1987665", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 14L, "15", "Контейнерная площадка № 1987668", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 15L, "22", "Контейнерная площадка № 1987669", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 16L, "16", "Контейнерная площадка № 1987670", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 17L, "10", "Контейнерная площадка № 1987671", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 18L, "14", "Контейнерная площадка № 1987672", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 19L, "21", "Контейнерная площадка № 1987674", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 20L, "6", "Контейнерная площадка № 1987675", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 21L, "10", "Контейнерная площадка № 1987676", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 22L, "18", "Контейнерная площадка № 1987677", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 23L, "9", "Контейнерная площадка № 1987679", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 13L, "4", "Контейнерная площадка № 1987666", "контейнерная площадка" });

            migrationBuilder.InsertData(
                table: "TRASHs",
                columns: new[] { "Id", "YardArea", "YardName", "YardType" },
                values: new object[] { 50L, "13.55", "Контейнерная площадка № 1987715", "контейнерная площадка" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TRASHs");
        }
    }
}
