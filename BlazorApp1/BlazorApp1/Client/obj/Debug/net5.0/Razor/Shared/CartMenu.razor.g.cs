#pragma checksum "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Shared\CartMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ddb5d608f26ab19ad5419baa3b48bb2cf616386"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    public partial class CartMenu : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "href", "cart");
            __builder.AddAttribute(2, "class", "btn-info");
            __builder.AddMarkupContent(3, "<i class=\"oi-cart\"></i>\r\n    Cart\r\n    ");
            __builder.OpenElement(4, "span");
            __builder.AddAttribute(5, "class", "badge-pill badge-light");
#nullable restore
#line 8 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Shared\CartMenu.razor"
__builder.AddContent(6, GetProductCount());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Shared\CartMenu.razor"
       
    protected override void OnInitialized()
    {
        CartService.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        CartService.OnChange -= StateHasChanged;
    }

    private int GetProductCount()
    {
        var cart = LocalStorage.GetItem<List<ProductVariant>>("cart"); 
        return cart != null ? cart.Count : 0; //return cart count if null return 0


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncLocalStorageService LocalStorage { get; set; }
    }
}
#pragma warning restore 1591
