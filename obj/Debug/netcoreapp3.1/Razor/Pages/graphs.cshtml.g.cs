#pragma checksum "D:\Tung\Study\ĐATN\đồ án\NetworkMonitoring\Pages\Graphs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "308c0cb488e7c796dff43b21bb495d1f0208c290"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NetworkMonitoring.Pages.Pages_Graphs), @"mvc.1.0.razor-page", @"/Pages/Graphs.cshtml")]
namespace NetworkMonitoring.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Tung\Study\ĐATN\đồ án\NetworkMonitoring\Pages\_ViewImports.cshtml"
using NetworkMonitoring;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308c0cb488e7c796dff43b21bb495d1f0208c290", @"/Pages/Graphs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adc58bd8c899ae9a4112bfd6570c949b790cb7c6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Graphs : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Tung\Study\ĐATN\đồ án\NetworkMonitoring\Pages\Graphs.cshtml"
  
    ViewData["Title"] = "Graphs";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "D:\Tung\Study\ĐATN\đồ án\NetworkMonitoring\Pages\Graphs.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p> page is used to see the overall graphs </p>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GraphsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GraphsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GraphsModel>)PageContext?.ViewData;
        public GraphsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
