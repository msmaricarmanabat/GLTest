#nullable disable

namespace GLTest.Core.Migrations
{
    public partial class MigrateProductAndCategoryInProductCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                                    INSERT INTO ProductCategories (ProductId, CategoryId)
                                    SELECT 
                                        Products.ProductId AS ProductId,  -- Use ProductId from Products table
                                        Categories.CategoryId AS CategoryId  -- Use CategoryId from Categories table
                                    FROM Products
                                    JOIN Categories ON Products.CategoryId = Categories.CategoryId;  -- Adjust join condition if needed
                                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
