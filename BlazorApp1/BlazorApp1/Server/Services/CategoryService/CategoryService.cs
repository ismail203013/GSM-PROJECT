using BlazorApp1.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using BlazorApp1.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();


        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));

        }
    }
}
