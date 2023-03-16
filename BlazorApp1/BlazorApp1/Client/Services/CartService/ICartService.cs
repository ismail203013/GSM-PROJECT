using BlazorApp1.Shared;
using System;
using System.Threading.Tasks;

namespace BlazorApp1.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(ProductVariant productVariant);

    }
}
