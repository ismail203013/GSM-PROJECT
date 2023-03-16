using BlazorApp1.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(ProductVariant productVariant);

        Task<List<CartItem>> GetCartItems();

        Task DeleteItem(CartItem item);
    }
}
