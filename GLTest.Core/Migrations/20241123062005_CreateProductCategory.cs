#nullable disable

namespace GLTest.Core.Migrations
{
    public partial class CreateProductCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                   name: "ProductCategories",
                   columns: table => new
                   {
                       Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                       CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                       ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                   },
                   constraints: table =>
                   {
                       table.PrimaryKey("PK_ProductCategories", x => x.Id);

                       table.ForeignKey(
                           name: "FK_ProductCategories_Categories",
                           column: x => x.CategoryId,
                           principalTable: "Categories",
                           principalColumn: "CategoryId",
                           onDelete: ReferentialAction.Cascade);

                       table.ForeignKey(
                           name: "FK_ProductCategories_Products",
                           column: x => x.ProductId,
                           principalTable: "Products",
                           principalColumn: "ProductId",
                           onDelete: ReferentialAction.Cascade);
                   });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "ProductCategories");
        }
    }
}
