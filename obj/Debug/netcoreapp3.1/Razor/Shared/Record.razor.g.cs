#pragma checksum "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\Record.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d937b794d37e2022592fc349cac3fc844cffe93"
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
#nullable restore
#line 1 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\Record.razor"
using RandomArtApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\Record.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    public partial class Record : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row mt-4 mb-4\">\r\n    <h2>What kind of thing would you like to draw today?</h2>\r\n</div> \r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\Record.razor"
                                    e => FetchRecord(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <img src=\"/images/object.svg\" alt=\"object icon\">\r\n        ");
            __builder.AddMarkupContent(8, "<p>Object</p>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\Record.razor"
                                    e => FetchRecord(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "\r\n        <img src=\"/images/concept.svg\" alt=\"concept icon\">\r\n        ");
            __builder.AddMarkupContent(18, "<p>Concept</p>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row");
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\Record.razor"
                                    e => FetchRecord(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "\r\n        <img src=\"/images/scene.svg\" alt=\"scene icon\">\r\n        ");
            __builder.AddMarkupContent(28, "<p>Scene</p>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n");
#nullable restore
#line 27 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\Record.razor"
 if (showingPrompt) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "    ");
            __builder.OpenComponent<RandomArtApp.Shared.PromptDialog>(32);
            __builder.AddAttribute(33, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 28 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\Record.razor"
                           Prompt

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(34, "PromptText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\Record.razor"
                                                promptText

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 29 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\Record.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\Record.razor"
       
    public bool showingPrompt = false;
    private Models.Record record { get; set; } = new Models.Record(); 
    private string promptText;
    [Required, EnumDataType(typeof(NounTypes))]
    public string  nounType { get; set; } = "object";
    private async Task FetchRecord(int nt)
        {
            switch (nt)
            {
                case 0:
                    nounType = "object";
                    break;
                case 1:
                    nounType = "concept";
                    break;
                case 2:
                    nounType = "scene";
                    break;
                default:
                    nounType = "object";
                    break;
            }
            record = await RecordService.GetRecordsAsync(nounType);
            promptText = record.IndefiniteArticle + " " + record.Noun;
            Prompt();
        }    
    private void Prompt(){
        showingPrompt = !showingPrompt;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RecordService RecordService { get; set; }
    }
}
#pragma warning restore 1591
