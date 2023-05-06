using BlazorApp1.Shared;
using Stripe.Checkout;
using System.Collections.Generic;
namespace BlazorApp1.Client.Services.PaymentService
{
    public interface IPaymentService 
    {

        Session CreateCheckoutSession(List<CartItem> cartItems);
    }
}
