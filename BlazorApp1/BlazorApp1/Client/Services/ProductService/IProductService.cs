using BlazorApp1.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task LoadProducts();
    }
}
