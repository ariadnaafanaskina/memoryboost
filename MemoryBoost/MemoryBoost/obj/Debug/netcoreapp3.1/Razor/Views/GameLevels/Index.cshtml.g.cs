#pragma checksum "D:\unik\MemoryBoost\MemoryBoost\MemoryBoost\Views\GameLevels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af84b5058bd80ad80d6ecb1d131b22ab583cef39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GameLevels_Index), @"mvc.1.0.view", @"/Views/GameLevels/Index.cshtml")]
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
#line 1 "D:\unik\MemoryBoost\MemoryBoost\MemoryBoost\Views\_ViewImports.cshtml"
using MemoryBoost;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\unik\MemoryBoost\MemoryBoost\MemoryBoost\Views\_ViewImports.cshtml"
using MemoryBoost.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\unik\MemoryBoost\MemoryBoost\MemoryBoost\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\unik\MemoryBoost\MemoryBoost\MemoryBoost\Views\_ViewImports.cshtml"
using MemoryBoost.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af84b5058bd80ad80d6ecb1d131b22ab583cef39", @"/Views/GameLevels/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15a8b521c8d2b4577f7cf8319d37faf8fd7db740", @"/Views/_ViewImports.cshtml")]
    public class Views_GameLevels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MemoryBoost.Models.GameLevel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\unik\MemoryBoost\MemoryBoost\MemoryBoost\Views\GameLevels\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""background-color: #59F9CC; color: #806CDD; border-radius: 35px;""
     class=""container d-flex flex-column w-50 h-50 align-self-center justify-content-center"">
    <a class=""btn btn-lg btn-block btn-outline font-weight-bold"" style=""font-size: 35px;"">choose the level</a>
");
#nullable restore
#line 10 "D:\unik\MemoryBoost\MemoryBoost\MemoryBoost\Views\GameLevels\Index.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"btn btn-lg btn-block btn-outline font-weight-bold\"\r\n           style=\"border: #806CDD solid 3px; border-radius: 35px; font-size: 30px;\">");
#nullable restore
#line 14 "D:\unik\MemoryBoost\MemoryBoost\MemoryBoost\Views\GameLevels\Index.cshtml"
                                                                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 15 "D:\unik\MemoryBoost\MemoryBoost\MemoryBoost\Views\GameLevels\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MemoryBoost.Models.GameLevel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
