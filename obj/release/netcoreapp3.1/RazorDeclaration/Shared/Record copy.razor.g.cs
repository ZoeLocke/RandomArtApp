#pragma checksum "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\Record copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc67657f113e5cf8cded70a2c0c8d21e86bc0fc0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\Record copy.razor"
using RandomArtApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\Record copy.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    public partial class Record_copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\Local Repos\random-art-prompter-blazor\RandomArtApp\Shared\Record copy.razor"
       
    private bool prompted = false;
    private Models.Record record { get; set; } = new Models.Record(); 
    [Required, EnumDataType(typeof(NounTypes))]
    public string  NounType { get; set; } = "object";
    private void SetPrompted(){
        prompted = !prompted;
    }
    private async Task FetchRecord()
        {
            record = await RecordService.GetRecordsAsync(NounType);
        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RecordService RecordService { get; set; }
    }
}
#pragma warning restore 1591
