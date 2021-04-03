using Microsoft.EntityFrameworkCore.Migrations;

namespace VarnishMixApp.Migrations
{
    public partial class MoveInserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalProductInsertedByUser");

            migrationBuilder.DropTable(
                name: "BaseProductInsertedByUser");

            migrationBuilder.AddColumn<int>(
                name: "InsertedByUser",
                table: "BaseProducts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsertedByUser",
                table: "AdditionalProducts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsertedByUser",
                table: "BaseProducts");

            migrationBuilder.DropColumn(
                name: "InsertedByUser",
                table: "AdditionalProducts");

            migrationBuilder.CreateTable(
                name: "AdditionalProductInsertedByUser",
                columns: table => new
                {
                    AdditionalProductInsertedByUserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdditionalProductId = table.Column<int>(type: "INTEGER", nullable: true)
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
                    BaseProductInsertedByUserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BaseProductId = table.Column<int>(type: "INTEGER", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalProductInsertedByUser_AdditionalProductId",
                table: "AdditionalProductInsertedByUser",
                column: "AdditionalProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseProductInsertedByUser_BaseProductId",
                table: "BaseProductInsertedByUser",
                column: "BaseProductId");
        }
    }
}
