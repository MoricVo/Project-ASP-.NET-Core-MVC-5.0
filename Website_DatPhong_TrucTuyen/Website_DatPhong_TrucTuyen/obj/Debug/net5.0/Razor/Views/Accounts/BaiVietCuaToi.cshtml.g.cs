#pragma checksum "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Accounts\BaiVietCuaToi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7474a6efe42d0b2db97be40e156d1a3cde9c0f49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_BaiVietCuaToi), @"mvc.1.0.view", @"/Views/Accounts/BaiVietCuaToi.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7474a6efe42d0b2db97be40e156d1a3cde9c0f49", @"/Views/Accounts/BaiVietCuaToi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f19b86e94451f9a78409722bdd97b207cd0a72", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_BaiVietCuaToi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TabBaiviet>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User_TabBaiviets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-icon-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger btn-icon-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Accounts\BaiVietCuaToi.cshtml"
 if (Model != null && Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-striped w-auto\">\r\n    <div class=\"float-end col-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7474a6efe42d0b2db97be40e156d1a3cde9c0f496326", async() => {
                WriteLiteral("Tạo bản tin");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <!--Table head-->
    <thead>
        <tr>
            <th>#</th>
            <th>Tên bài viết</th>
            <th>Nội dung</th>
            <th>Ngày đăng</th>
            <th>Lượt xem</th>
            <th>Ghi chú</th>
            <th>Tùy chọn</th>
        </tr>
    </thead>
    <!--Table head-->
    <!--Table body-->
    <tbody>
");
#nullable restore
#line 23 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Accounts\BaiVietCuaToi.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"table-info\">\r\n                <th scope=\"row\">");
#nullable restore
#line 26 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Accounts\BaiVietCuaToi.cshtml"
                           Write(item.IdBaiviet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 27 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Accounts\BaiVietCuaToi.cshtml"
               Write(item.Tieude);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>##########</td>\r\n                <td>");
#nullable restore
#line 29 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Accounts\BaiVietCuaToi.cshtml"
               Write(item.Ngaydang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Accounts\BaiVietCuaToi.cshtml"
               Write(item.Luotxem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Accounts\BaiVietCuaToi.cshtml"
               Write(item.Ghichu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7474a6efe42d0b2db97be40e156d1a3cde9c0f4910284", async() => {
                WriteLiteral(" Cập nhật <i class=\"mdi mdi-file-check btn-icon-append\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Accounts\BaiVietCuaToi.cshtml"
                                                                                                                            WriteLiteral(item.IdBaiviet);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n           \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7474a6efe42d0b2db97be40e156d1a3cde9c0f4912985", async() => {
                WriteLiteral("  <i class=\"mdi mdi-alert btn-icon-prepend\"></i> Xóa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Accounts\BaiVietCuaToi.cshtml"
                                                                                                                             WriteLiteral(item.IdBaiviet);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Accounts\BaiVietCuaToi.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <!--Table body-->\r\n\r\n\r\n</table>\r\n    <!--Table-->\r\n");
#nullable restore
#line 45 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Accounts\BaiVietCuaToi.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Chưa có bài viết</p>\r\n");
#nullable restore
#line 48 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\Accounts\BaiVietCuaToi.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Table-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TabBaiviet>> Html { get; private set; }
    }
}
#pragma warning restore 1591
