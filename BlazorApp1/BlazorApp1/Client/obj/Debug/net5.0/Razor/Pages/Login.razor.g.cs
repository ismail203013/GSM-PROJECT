#pragma checksum "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b24e5669259cf338603265b550aef6df2da7ea53"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Client.Pages
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
using BlazorApp1.Client.Services.FormService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "about-grid-container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "about-line");
            __builder.AddMarkupContent(4, "<h4 class=\"login-title\">Login</h4>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Login.razor"
                 user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Login.razor"
                                      UserLogin

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<label for=\"username\">Username</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "username");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Required", true);
                __builder2.AddAttribute(16, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Login.razor"
                                              user.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Username = __value, user.Username))));
                __builder2.AddAttribute(18, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Username));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label for=\"password\">Password</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "id", "password");
                __builder2.AddAttribute(25, "type", "password");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "Required", true);
                __builder2.AddAttribute(28, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Login.razor"
                                              user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                __builder2.AddAttribute(30, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __builder2.AddMarkupContent(32, "<button type=\"submit\" class=\"btn btn-primary\">Login</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n\r\n");
            __builder.OpenElement(34, "div");
            __builder.AddMarkupContent(35, "<h4 class=\"login-title\">Register</h4>\r\n\r\n    ");
            __builder.OpenElement(36, "form");
            __builder.AddAttribute(37, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Login.razor"
                      UserReg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "<div class=\"form-group\"><label for=\"email\">Email</label>\r\n        <input id=\"email\" type=\"email\" class=\"form-control\" Required></div>\r\n\r\n    ");
            __builder.AddMarkupContent(39, "<button type=\"submit\" class=\"btn btn-primary\">Register</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Login.razor"
       


    public User user = new User();

    private async void UserLogin()

    {

        Console.WriteLine("LOGGED IN!!!");
        await LocalStorage.SetItemAsync<string>("username", user.Username);
        await AuthStateProvider.GetAuthenticationStateAsync();
        ToastService.ShowSuccess("You have sucessfully logged in!");
        NavigationManager.NavigateTo("dashboard");
        


    }

    private void UserReg()

    {

        
        ToastService.ShowInfo("An email has been sent, please follow the instructions to complete registration !");
      


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
    }
}
#pragma warning restore 1591
