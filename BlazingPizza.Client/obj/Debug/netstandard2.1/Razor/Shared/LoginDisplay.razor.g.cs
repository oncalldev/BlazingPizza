#pragma checksum "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f68e7a9bb4a23cd731b8d34ad8bb177ea1bb032"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#line 3 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 4 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 5 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 7 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 8 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 9 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#line 10 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 11 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#line 12 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#line 13 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
#line 14 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary.Map;

#line default
#line hidden
#line 15 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using BlazingComponents;

#line default
#line hidden
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "user-info");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
            __builder.AddAttribute(4, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\n            ");
                __builder2.AddMarkupContent(6, "<text>...</text>\n        ");
            }
            ));
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\n            <img src=\"img/user.svg\">\n            ");
                __builder2.OpenElement(9, "div");
                __builder2.AddMarkupContent(10, "\n                ");
                __builder2.OpenElement(11, "a");
                __builder2.AddAttribute(12, "href", "authentication/profile");
                __builder2.AddAttribute(13, "class", "username");
                __builder2.AddContent(14, 
#line 12 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\LoginDisplay.razor"
                                                                   context.User.Identity.Name

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\n                ");
                __builder2.OpenElement(16, "button");
                __builder2.AddAttribute(17, "class", "btn btn-link sign-out");
                __builder2.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 13 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\LoginDisplay.razor"
                                                                BeginSignOut

#line default
#line hidden
                ));
                __builder2.AddContent(19, "Sign out");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n        ");
            }
            ));
            __builder.AddAttribute(22, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(23, "\n            ");
                __builder2.AddMarkupContent(24, "<a class=\"sign-in\" href=\"authentication/register\">Register</a>\n            ");
                __builder2.AddMarkupContent(25, "<a class=\"sign-in\" href=\"authentication/login\">Log in</a>\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 23 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\LoginDisplay.razor"
      
    async Task BeginSignOut()
    {
        await SignOutManager.SetSignOutState();
        Navigation.NavigateTo("authentication/logout");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
