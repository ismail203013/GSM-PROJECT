using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.LocalStorage;
using System.Security.Claims;

namespace BlazorApp1.Shared
{
    public class LoginAuth : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorage;

        public LoginAuth(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {

            var state = new AuthenticationState(new ClaimsPrincipal()); // checking that user is authenicated or not

            string username = await _localStorage.GetItemAsStringAsync("username");
           
            if (!string.IsNullOrEmpty(username)) // adding the user to the cliams 
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, username)
                }, "test authentication type");

                state = new AuthenticationState(new ClaimsPrincipal(identity));
            }

            NotifyAuthenticationStateChanged(Task.FromResult(state));

            return state;
        }
    }
}
