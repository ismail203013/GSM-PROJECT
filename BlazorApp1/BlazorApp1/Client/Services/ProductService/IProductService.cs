using BlazorApp1.Shared;
using System.Collections.Generic;

namespace BlazorApp1.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}
