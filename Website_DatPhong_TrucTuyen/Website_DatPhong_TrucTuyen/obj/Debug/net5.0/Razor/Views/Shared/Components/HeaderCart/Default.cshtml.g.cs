#pragma checksum "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\HeaderCart\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a460697dd3f9b67216d12a93ce58eb7ea4915d84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HeaderCart_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HeaderCart/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a460697dd3f9b67216d12a93ce58eb7ea4915d84", @"/Views/Shared/Components/HeaderCart/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f19b86e94451f9a78409722bdd97b207cd0a72", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HeaderCart_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Website_DatPhong_TrucTuyen.ModelViews.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\HeaderCart\Default.cshtml"
 if (Model != null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""harmic-offcanvas-body"">
        <div class=""minicart-content"">
            <div class=""minicart-heading"">
                <h4 class=""mb-0"">Giỏ hàng</h4>
                <a href=""#"" class=""button-close""><i class=""pe-7s-close""></i></a>
            </div>
            <ul class=""minicart-list"">
");
#nullable restore
#line 11 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\HeaderCart\Default.cshtml"
                 foreach (var item in Model)
                {
                    string url = $"{item.homestay.IdHomstay}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"minicart-product\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 632, "\"", 643, 1);
#nullable restore
#line 15 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 639, url, 639, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-item_img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a460697dd3f9b67216d12a93ce58eb7ea4915d845727", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 727, "~/Image2/", 727, 9, true);
#nullable restore
#line 16 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\HeaderCart\Default.cshtml"
AddHtmlAttributeValue("", 736, Html.DisplayFor(modelItem => item.homestay.Hinhanh), 736, 52, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </a>\r\n                        <div class=\"product-item_content\">\r\n                            <a class=\"product-item_title\"");
            BeginWriteAttribute("href", " href=\"", 940, "\"", 951, 1);
#nullable restore
#line 19 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 947, url, 947, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                                 Write(item.homestay.Tenhomestay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <span class=\"product-item_quantity\">");
#nullable restore
#line 20 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                           Write(item.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 20 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                                          Write(item.homestay.Giatien.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 23 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\HeaderCart\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"minicart-item_total\">\r\n            <span>Tổng tiền</span>\r\n");
            WriteLiteral("        </div>\r\n        <div class=\"group-btn_wrap d-grid gap-2\">\r\n            <a href=\"cart.html\" class=\"btn btn-secondary btn-primary-hover\">Xem giỏ hàng</a>\r\n");
#nullable restore
#line 32 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\HeaderCart\Default.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Thanh toán</a>\r\n");
#nullable restore
#line 35 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\HeaderCart\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"/dang-nhap.html?returnUrl=/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Thanh toán</a>\r\n");
#nullable restore
#line 39 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\HeaderCart\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 42 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\HeaderCart\Default.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"harmic-offcanvas-body\">\r\n        <div class=\"minicart-content\">\r\n            <div class=\"minicart-heading\">\r\n                <h4 class=\"mb-0\">Giỏ hàng rỗng</h4>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 52 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Shared\Components\HeaderCart\Default.cshtml"
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