#pragma checksum "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\OrderReview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b45481a2204ccda2e7fe6a2adef81617b90a9ec3"
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
    public partial class OrderReview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 1 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\OrderReview.razor"
 foreach (var pizza in Order.Pizzas)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\n        ");
            __builder.OpenElement(3, "strong");
            __builder.AddMarkupContent(4, "\n            ");
            __builder.AddContent(5, 
#line 5 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\OrderReview.razor"
              pizza.Size

#line default
#line hidden
            );
            __builder.AddMarkupContent(6, "\"\n            ");
            __builder.AddContent(7, 
#line 6 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\OrderReview.razor"
             pizza.Special.Name

#line default
#line hidden
            );
            __builder.AddMarkupContent(8, "\n            (£");
            __builder.AddContent(9, 
#line 7 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\OrderReview.razor"
               pizza.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.AddMarkupContent(10, ")\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n");
            __builder.AddContent(13, "    ");
            __builder.OpenElement(14, "ul");
            __builder.AddMarkupContent(15, "\n");
#line 12 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\OrderReview.razor"
         foreach (var topping in pizza.Toppings)
        {

#line default
#line hidden
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "li");
            __builder.AddContent(18, "+ ");
            __builder.AddContent(19, 
#line 14 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\OrderReview.razor"
                   topping.Topping.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n");
#line 15 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\OrderReview.razor"
        }

#line default
#line hidden
            __builder.AddContent(21, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n");
#line 17 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\OrderReview.razor"
}

#line default
#line hidden
            __builder.AddMarkupContent(23, "\n");
            __builder.OpenElement(24, "p");
            __builder.AddMarkupContent(25, "\n    ");
            __builder.OpenElement(26, "strong");
            __builder.AddMarkupContent(27, "\n        Total price:\n        £");
            __builder.AddContent(28, 
#line 22 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\OrderReview.razor"
          Order.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.AddMarkupContent(29, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 26 "D:\Splungeworks2020\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\OrderReview.razor"
       
    [Parameter] public Order Order { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
