#pragma checksum "C:\Users\josea\source\repos\MarvelComics\MavelApi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c966697a29c006e26314ae1e03e136a735b622a"
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
#line 1 "C:\Users\josea\source\repos\MarvelComics\MavelApi\Views\_ViewImports.cshtml"
using MavelApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josea\source\repos\MarvelComics\MavelApi\Views\_ViewImports.cshtml"
using MavelApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c966697a29c006e26314ae1e03e136a735b622a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f6ece097cfd6223a2a7bdcba199cf3961577c61", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MavelApi.Models.Comics>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\josea\source\repos\MarvelComics\MavelApi\Views\Home\Index.cshtml"
 foreach(var item in @Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"overflow: hidden; margin-top: 50px;\">\n    <div style=\"float: left; margin-right: 50px;\">\n        <img");
            BeginWriteAttribute("src", " src=\"", 182, "\"", 199, 1);
#nullable restore
#line 6 "C:\Users\josea\source\repos\MarvelComics\MavelApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 188, item.Image, 188, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\" width=\"200\" />\n    </div>\n    <div style=\"margin-left: 50px;\">\n        <h2><a");
            BeginWriteAttribute("href", " href=\"", 291, "\"", 307, 1);
#nullable restore
#line 9 "C:\Users\josea\source\repos\MarvelComics\MavelApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 298, item.URL, 298, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "C:\Users\josea\source\repos\MarvelComics\MavelApi\Views\Home\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\n        <p>UPC:");
#nullable restore
#line 10 "C:\Users\josea\source\repos\MarvelComics\MavelApi\Views\Home\Index.cshtml"
          Write(item.UPC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <h4><a");
            BeginWriteAttribute("href", " href=\"", 373, "\"", 393, 1);
#nullable restore
#line 11 "C:\Users\josea\source\repos\MarvelComics\MavelApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 380, item.Details, 380, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detalhes</a></h4>\n    </div>\n</div>\n");
#nullable restore
#line 14 "C:\Users\josea\source\repos\MarvelComics\MavelApi\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MavelApi.Models.Comics>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
