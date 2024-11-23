using GLTest.Core.Common;

namespace GLTest.Core.Commands.Products
{
    public interface ISetProductCategoryCommand
    {
        Task<CommandResult<bool>> ExecuteAsync(Guid productId, Guid categoryId);
    }
}