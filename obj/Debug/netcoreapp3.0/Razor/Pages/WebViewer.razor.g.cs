#pragma checksum "C:\Users\Yon\Documents\blazor-nppm\webviewer-blazor-sample\Pages\WebViewer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3de9398a5323cffa553a9750de8bf32dbd15be07"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebViewerServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Yon\Documents\blazor-nppm\webviewer-blazor-sample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Yon\Documents\blazor-nppm\webviewer-blazor-sample\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\Yon\Documents\blazor-nppm\webviewer-blazor-sample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\Yon\Documents\blazor-nppm\webviewer-blazor-sample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\Yon\Documents\blazor-nppm\webviewer-blazor-sample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\Yon\Documents\blazor-nppm\webviewer-blazor-sample\_Imports.razor"
using BlazorWebViewerServer;

#line default
#line hidden
#line 7 "C:\Users\Yon\Documents\blazor-nppm\webviewer-blazor-sample\_Imports.razor"
using BlazorWebViewerServer.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/webviewer")]
    public class WebViewer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>WebViewer</h1>\r\n<div id=\"viewer\" style=\"width: 1024px; height: 600px; margin: 0 auto;\"></div>");
        }
        #pragma warning restore 1998
#line 7 "C:\Users\Yon\Documents\blazor-nppm\webviewer-blazor-sample\Pages\WebViewer.razor"
       
    protected override async void OnAfterRender()
    {
       await JSRuntime.InvokeAsync<object>("webviewerFunctions.initWebViewer");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
