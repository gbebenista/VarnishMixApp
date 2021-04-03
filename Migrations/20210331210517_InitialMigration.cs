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
                    additionalProductType = table.Column<int>(nullable: false)
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
                    BaseProductType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseProducts", x => x.BaseProductId);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalProductInsertedByUser",
                columns: table => new
                {
                    AdditionalProductInsertedByUserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdditionalProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalProductInsertedByUser", x => x.AdditionalProductInsertedByUserId);
                    table.ForeignKey(
                        name: "FK_AdditionalProductInsertedByUser_AdditionalProducts_AdditionalProductId",
                        column: x => x.AdditionalProductId,
                        principalTable: "AdditionalProducts",
                        principalColumn: "AdditionalProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaseProductInsertedByUser",
                columns: table => new
                {
                    BaseProductInsertedByUserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BaseProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseProductInsertedByUser", x => x.BaseProductInsertedByUserId);
                    table.ForeignKey(
                        name: "FK_BaseProductInsertedByUser_BaseProducts_BaseProductId",
                        column: x => x.BaseProductId,
                        principalTable: "BaseProducts",
                        principalColumn: "BaseProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductPropotions",
                columns: table => new
                {
                    ProductProportionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BaseProductId = table.Column<int>(nullable: true),
                    AdditionalProductId = table.Column<int>(nullable: true),
                    IsConstrainted = table.Column<int>(nullable: false),
                    DivisionProportion = table.Column<decimal>(type: "decimal(5, 2)", nullable: true),
                    PercentProportion = table.Column<decimal>(type: "decimal(5, 2)", nullable: true),
                    WeightProportion = table.Column<decimal>(type: "decimal(5, 2)", nullable: true)
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalProductInsertedByUser_AdditionalProductId",
                table: "AdditionalProductInsertedByUser",
                column: "AdditionalProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseProductInsertedByUser_BaseProductId",
                table: "BaseProductInsertedByUser",
                column: "BaseProductId");

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
                name: "AdditionalProductInsertedByUser");

            migrationBuilder.DropTable(
                name: "BaseProductInsertedByUser");

            migrationBuilder.DropTable(
                name: "ProductPropotions");

            migrationBuilder.DropTable(
                name: "AdditionalProducts");

            migrationBuilder.DropTable(
                name: "BaseProducts");
        }
    }
}
