using BlazorApp1.Shared;
using System.Collections.Generic;

namespace BlazorApp1.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category> {
            new Category { Id = 1, Name ="Plugs", Url="plugs", Icon="plug"},
            new Category { Id = 2, Name ="Cables", Url="cables", Icon="cable"},
            new Category { Id = 3, Name ="Phones", Url="phones", Icon="phone"}

            };
        }
    }
}
