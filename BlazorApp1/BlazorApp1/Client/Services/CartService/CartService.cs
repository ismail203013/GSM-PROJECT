using BlazorApp1.Client.Services.ProductService;
using BlazorApp1.Shared;
using Blazored.LocalStorage;
using Blazored.Toast.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IProductService _productService;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorage, IToastService toastservice, IProductService productservice)
        {
           _localStorage = localStorage;
            _toastService = toastservice;
           _productService = productservice;
        }

        public async Task AddToCart(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            var sameItem = cart.Find(x=> x.ProductId == item.ProductId && x.EditionId == item.EditionId); ;

            if (sameItem == null)

            {
                cart.Add(item);
            }
            else 
            { 
              sameItem.Quantity += item.Quantity;
            }

            await _localStorage.SetItemAsync("cart",cart);
            


            var product = await _productService.GetProduct(item.ProductId);
            _toastService.ShowSuccess(product.Title, "Added to cart:");

            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
           
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return new List<CartItem>();
            }

            return cart;
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");

            if (cart == null)
            {
                return;

            }
            var cartItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);
            cart.Remove(cartItem);

            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        public async Task EmptyCart()
        {

            await _localStorage.RemoveItemAsync("cart");
            OnChange.Invoke();


        }
    }
}
