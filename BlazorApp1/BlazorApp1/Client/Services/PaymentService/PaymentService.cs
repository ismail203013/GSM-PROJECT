using BlazorApp1.Shared;
using Stripe;
using Stripe.Checkout;
using System.Collections.Generic;

namespace BlazorApp1.Client.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        public PaymentService()
        {
            StripeConfiguration.ApiKey = "sk_test_51N4sKyJSRsVKzO4J0BDuaJcXshWAuwpGwfDiqQTTIxEDSqIAbA4UuEKBbdQCcnZYZn6zw1ulHTUH6R8xvhmAzbyP00W3W9GdBp";
        }
        public Session CreateCheckoutSession(List<CartItem> cartItems)
        {
            var lineItems = new List<SessionLineItemOptions>();
            cartItems.ForEach(x => lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmountDecimal = x.Price * 100,
                    Currency = "GBP",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = x.ProductTitle,
                        Images = new List<string> { x.Image }
                    }

                },
                Quantity = x.Quantity
            }));


            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                    "card"
                },
                LineItems = lineItems,
        
          
         
                Mode = "payment",
                SuccessUrl = "https://localhost:5001/orderdone",
                CancelUrl = "http://localhost:5001/cancel",
            };

            var service = new SessionService();
            Session session = service.Create(options);

            return session;
        }
    }
}
