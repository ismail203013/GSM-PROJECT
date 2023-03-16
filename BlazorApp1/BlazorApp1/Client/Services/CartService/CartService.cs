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

        public async Task AddToCart(ProductVariant productVariant)
        {
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");
            if (cart == null)
            {
                cart = new List<ProductVariant>();
            }
            cart.Add(productVariant);
            await _localStorage.SetItemAsync("cart",cart);

            var product = await _productService.GetProduct(productVariant.ProductId);
            _toastService.ShowSuccess(product.Title, "Added to cart:");

            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
           var result = new List<CartItem>();
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");
            if (cart == null)
            {
                return result;
            }

            foreach (var item in cart) 
            {
                var product = await _productService.GetProduct(item.ProductId);
                var cartItem = new CartItem
                {
                    ProductId = product.Id,
                    ProductTitle = product.Title,
                    Image = product.Image,
                    EditionId = item.EditionId
                };
                var varinat = product.Variants.Find(v => v.EditionId == item.EditionId);
                if (varinat != null)
                {
                    cartItem.EditionName = varinat.Edition?.Name;
                    cartItem.Price = varinat.Price;
                }
                result.Add(cartItem);
            }
            return result;
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");

            if (cart == null)
            {
                return;

            }
            var cartItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);
            cart.Remove(cartItem);

            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }
    }
}
