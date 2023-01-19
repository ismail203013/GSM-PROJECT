using BlazorApp1.Shared;
using System.Collections.Generic;

namespace BlazorApp1.Client.Services.CategoryService
{
    public interface ICategoryService
    {
         List<Category> Categories { get; set; }
         void LoadCategories();
    }
}
