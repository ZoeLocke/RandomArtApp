#pragma checksum "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\PromptDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e7c8d7b781fd2100e82d421098ca09e4658e310"
// <auto-generated/>
#pragma warning disable 1591
namespace RandomArtApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\_Imports.razor"
using RandomArtApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\_Imports.razor"
using RandomArtApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class PromptDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dialog-container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "dialog");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "id", "x");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\PromptDialog.razor"
                                 OnClose

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(9, "\r\n            X\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.AddMarkupContent(11, "<h2>Your prompt is...</h2>\r\n        ");
            __builder.OpenElement(12, "p");
            __builder.AddAttribute(13, "class", "prompt");
            __builder.AddContent(14, 
#nullable restore
#line 7 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\PromptDialog.razor"
                           PromptText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddMarkupContent(16, "<p>Go draw, you\'ve got this 👊</p>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\PromptDialog.razor"
       
    [Parameter] public EventCallback OnClose { get; set; }
    [Parameter] public string PromptText { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
