using GLTest.Controllers.Products.InputModels;
using GLTest.Core.Commands.Products;
using Microsoft.AspNetCore.Mvc;

namespace GLTest.Controllers.Products
{
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly ISetProductCategoryCommand _setProductCategoryCommand;

        public ProductController(ISetProductCategoryCommand setProductCategoryCommand)
        {
            _setProductCategoryCommand = setProductCategoryCommand;
        }

        [HttpPut("{productId}")]
        public async Task<ActionResult> SetProductCategory([FromRoute] Guid productId, [FromBody] SetCategoryInputModel model)
        { 
            var commandResult = await _setProductCategoryCommand.ExecuteAsync(productId, model.CategoryId);
            
            // Check if the command was not successful
            if (!commandResult.IsSuccessful && commandResult.Error.HasValue)
            {
                var cmdResult = commandResult.Error.Value;

                // Return BadRequest with the error message(s)
                return BadRequest(new
                {
                    errorCode = cmdResult.Code,
                    errorMessage = cmdResult.Message
                });
            }

            return Ok();
        }
    }
}
