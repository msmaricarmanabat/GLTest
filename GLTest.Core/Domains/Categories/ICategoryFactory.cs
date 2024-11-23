using GLTest.Core.Common;

namespace GLTest.Core.Domains.Categories
{
    public interface ICategoryFactory
    {
        ResultModel<Category> CreateInstance(string name);
    }
}