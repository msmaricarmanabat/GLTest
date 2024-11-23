using GLTest.Core.Domains.ProductCategories;

namespace GLTest.Core.DataModels
{

    public class ProductCategoryConfigurations : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd();

            builder.HasOne(pc => pc.Category)
                   .WithMany()
                   .HasForeignKey(pc => pc.CategoryId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(pc => pc.Product)
                   .WithMany()
                   .HasForeignKey(pc => pc.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
