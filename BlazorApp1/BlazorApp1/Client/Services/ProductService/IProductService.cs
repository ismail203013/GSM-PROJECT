using BlazorApp1.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action OnChange;
        List<Product> Products { get; set; }
        Task LoadProducts(string categoryUrl = null);
    }
}
