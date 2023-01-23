using BlazorApp1.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetCategoryByUrl(string categoryUrl);
    }
}
