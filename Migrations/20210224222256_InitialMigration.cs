using Microsoft.EntityFrameworkCore.Migrations;

namespace VarnishMixApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalProducts",
                columns: table => new
                {
                    AdditionalProductId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdditionalProductName = table.Column<string>(nullable: true),
                    additionalProductType = table.Column<int>(nullable: false),
                    LayerThickness = table.Column<decimal>(nullable: false),
                    Layer = table.Column<decimal>(nullable: false),
                    DryOffTime = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalProducts", x => x.AdditionalProductId);
                });

            migrationBuilder.CreateTable(
                name: "BaseProducts",
                columns: table => new
                {
                    BaseProductId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BaseProductName = table.Column<string>(nullable: true),
                    baseProductType = table.Column<int>(nullable: false),
                    LayerThickness = table.Column<decimal>(nullable: false),
                    Layer = table.Column<decimal>(nullable: false),
                    DryOffTime = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseProducts", x => x.BaseProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductPropotions",
                columns: table => new
                {
                    ProductProportionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BaseProductId = table.Column<int>(nullable: false),
                    AdditionalProductId = table.Column<int>(nullable: true),
                    DivisionProportion = table.Column<decimal>(nullable: false),
                    PercentProportion = table.Column<decimal>(nullable: false),
                    WeightProportion = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPropotions", x => x.ProductProportionId);
                    table.ForeignKey(
                        name: "FK_ProductPropotions_AdditionalProducts_AdditionalProductId",
                        column: x => x.AdditionalProductId,
                        principalTable: "AdditionalProducts",
                        principalColumn: "AdditionalProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductPropotions_BaseProducts_BaseProductId",
                        column: x => x.BaseProductId,
                        principalTable: "BaseProducts",
                        principalColumn: "BaseProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPropotions_AdditionalProductId",
                table: "ProductPropotions",
                column: "AdditionalProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPropotions_BaseProductId",
                table: "ProductPropotions",
                column: "BaseProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPropotions");

            migrationBuilder.DropTable(
                name: "AdditionalProducts");

            migrationBuilder.DropTable(
                name: "BaseProducts");
        }
    }
}
