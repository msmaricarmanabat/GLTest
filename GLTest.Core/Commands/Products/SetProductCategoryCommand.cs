using GLTest.Core.Common;
using GLTest.Core.Domains.ProductCategories;
using GLTest.Core.Repositories.Categories;
using GLTest.Core.Repositories.ProductCategories;
using GLTest.Core.Repositories.Products;

namespace GLTest.Core.Commands.Products
{
    public class SetProductCategoryCommand : ISetProductCategoryCommand
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SetProductCategoryCommand(IProductRepository productRepository,
            ICategoryRepository categoryRepository,
            IProductCategoryRepository productCategoryRepository,
            IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _productCategoryRepository = productCategoryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<CommandResult<bool>> ExecuteAsync(Guid productId, Guid categoryId)
        {
            var product = await _productRepository.FirstOrDefaultAsync(a => a.ProductId == productId);
            if (product == null)
                return new CommandResult<bool>("Set_Product_Category_Product_NotFound", "Product not found. ");

            var category = await _categoryRepository.FirstOrDefaultAsync(a => a.CategoryId == categoryId);
            if (category == null)
                return new CommandResult<bool>("Set_Product_Category_Category_NotFound", "Category not found. ");

            var existingProductCategory = await _productCategoryRepository.FirstOrDefaultAsync(a => a.ProductId == productId && a.CategoryId == categoryId);
            if (existingProductCategory != null)
            {
                return new CommandResult<bool>("Set_Product_Category_AlreadyExists", "The product is already associated with the category.");
            }

            var productCategory = ProductCategory.Create(productId, categoryId);
            _productCategoryRepository.Add(productCategory);

            try
            {
                await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {
                return new CommandResult<bool>("Set_Product_Category_SaveFailed", "Failed to save the association.");
            }

            return new CommandResult<bool>(true);
        }
    }
}
