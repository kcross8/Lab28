#pragma checksum "C:\Users\kyle\source\repos\601WebAPI_Intro\601WebAPI_Intro\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "752db1be4ea86c7eb952728627f1fbbdd3a2e492"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\kyle\source\repos\601WebAPI_Intro\601WebAPI_Intro\Views\_ViewImports.cshtml"
using _601WebAPI_Intro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kyle\source\repos\601WebAPI_Intro\601WebAPI_Intro\Views\_ViewImports.cshtml"
using _601WebAPI_Intro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"752db1be4ea86c7eb952728627f1fbbdd3a2e492", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7833d515edc795b3c80d8e09f9e83a7258d80c56", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Planet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n \r\n<h1>Stars War</h1>\r\n\r\n<p>Search by <a href=\"/Home/PersonSearch\">Person</a>, <a href=\"Home/PlanetSearch\">Planet</a>, or <a href=\"Home/StarshipSearch\">Starship</a></p>\r\n\r\n<h2>");
#nullable restore
#line 8 "C:\Users\kyle\source\repos\601WebAPI_Intro\601WebAPI_Intro\Views\Home\Index.cshtml"
Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Planet> Html { get; private set; }
    }
}
#pragma warning restore 1591
