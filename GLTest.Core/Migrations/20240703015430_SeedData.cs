using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GLTest.Core.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categories (CategoryId, CategoryName) values ('58c7e7b7-e884-40be-829b-9284993c2c12', 'Underchassis Parts')");
            migrationBuilder.Sql("Insert into Categories (CategoryId, CategoryName) values ('9334e106-17a3-404f-8339-b9e6950925db', 'Tie rod end')");
            migrationBuilder.Sql("Insert into Categories (CategoryId, CategoryName) values ('04de0df7-b5cb-4869-991f-1700acafc627', 'Ball joint')");
            migrationBuilder.Sql("Insert into Categories (CategoryId, CategoryName) values ('2cb7f3eb-0876-41d5-b05c-a1fe82ffee06', 'Drag Link')");

            migrationBuilder.Sql("Insert into Products (ProductId, ProductName, CategoryId) values ('6d5d732f-e1c6-4abb-ad57-720543137e34', 'Toyota Vios Tie Rod End', '9334e106-17a3-404f-8339-b9e6950925db')");
            migrationBuilder.Sql("Insert into Products (ProductId, ProductName, CategoryId) values ('28ad81c6-c36e-4b40-b33a-c8cd5815192d', 'Nissan Altima Ball Joint', '04de0df7-b5cb-4869-991f-1700acafc627')");
            migrationBuilder.Sql("Insert into Products (ProductId, ProductName, CategoryId) values ('545d5d88-9454-47f2-9e33-493b262a28c8', 'Honda Civic Drag link', '2cb7f3eb-0876-41d5-b05c-a1fe82ffee06')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
