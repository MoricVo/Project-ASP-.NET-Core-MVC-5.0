#pragma checksum "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\NumberCart\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bfc399ed6b04e28357cb2e0318ec95ff53d3c18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NumberCart_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NumberCart/Default.cshtml")]
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
#line 1 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\_ViewImports.cshtml"
using Website_DatPhong_TrucTuyen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\_ViewImports.cshtml"
using Website_DatPhong_TrucTuyen.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bfc399ed6b04e28357cb2e0318ec95ff53d3c18", @"/Views/Shared/Components/NumberCart/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f19b86e94451f9a78409722bdd97b207cd0a72", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NumberCart_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Website_DatPhong_TrucTuyen.ModelViews.CartItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\NumberCart\Default.cshtml"
 if (Model != null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"minicart-wrap me-3 me-lg-0\">\r\n        <a href=\"#miniCart\" class=\"minicart-btn toolbar-btn\">\r\n            <i class=\"pe-7s-shopbag\"></i>\r\n            <span class=\"quantity\">");
#nullable restore
#line 7 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\NumberCart\Default.cshtml"
                              Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </a>\r\n    </li>\r\n");
#nullable restore
#line 10 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\NumberCart\Default.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"minicart-wrap me-3 me-lg-0\">\r\n        <a href=\"#miniCart\" class=\"toolbar-btn\">\r\n            <i class=\"pe-7s-shopbag\"></i>\r\n            <span class=\"quantity\">0</span>\r\n        </a>\r\n    </li>\r\n");
#nullable restore
#line 19 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\NumberCart\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Website_DatPhong_TrucTuyen.ModelViews.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
