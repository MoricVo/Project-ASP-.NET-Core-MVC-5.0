#pragma checksum "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9152e85dd989e0a421a2850174856b2e0971208f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9152e85dd989e0a421a2850174856b2e0971208f", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f19b86e94451f9a78409722bdd97b207cd0a72", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Website_DatPhong_TrucTuyen.ModelViews.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Blue Jeans Jacket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\ShoppingCart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/Logi_View.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .gradient-custom {
        /* fallback for old browsers */
        background: #6a11cb;
        /* Chrome 10-25, Safari 5.1-6 */
        background: -webkit-linear-gradient(to right, rgba(106, 17, 203, 1), rgba(37, 117, 252, 1));
        /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
        background: linear-gradient(to right, rgba(106, 17, 203, 1), rgba(37, 117, 252, 1))
    }
</style>
<section style=""padding-top:55px;"" class=""h-100 gradient-custom"">
   
    <div class=""container py-5"">
");
#nullable restore
#line 20 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\ShoppingCart\Index.cshtml"
         if (Model != null && Model.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row d-flex justify-content-center my-4\">\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"card mb-4\">\r\n                        <div class=\"card-header py-3\">\r\n                            <h5 class=\"mb-0\">");
#nullable restore
#line 26 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\ShoppingCart\Index.cshtml"
                                        Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                        </div>\r\n                        <div class=\"card-body\">\r\n                            <!-- Single item -->\r\n");
#nullable restore
#line 30 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\ShoppingCart\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""row"">
                                    <div class=""col-lg-3 col-md-12 mb-4 mb-lg-0"">
                                        <!-- Image -->
                                        <div class=""bg-image hover-overlay hover-zoom ripple rounded"" data-mdb-ripple-color=""light"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9152e85dd989e0a421a2850174856b2e0971208f7035", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1626, "~/Image2/", 1626, 9, true);
#nullable restore
#line 36 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 1635, Html.DisplayFor(modelItem => item.homestay.Hinhanh), 1635, 52, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            <a href=""#!"">
                                                <div class=""mask"" style=""background-color: rgba(251, 251, 251, 0.2)""></div>
                                            </a>
                                        </div>
                                        <!-- Image -->
                                    </div>

                                    <div class=""col-lg-5 col-md-6 mb-4 mb-lg-0"">
                                        <!-- Data -->
                                        <p><strong>");
#nullable restore
#line 47 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\ShoppingCart\Index.cshtml"
                                              Write(item.homestay.Tenhomestay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                                        <p>Địa chỉ ");
#nullable restore
#line 48 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\ShoppingCart\Index.cshtml"
                                              Write(item.homestay.Diachicuthe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Số ngày ở ");
#nullable restore
#line 49 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\ShoppingCart\Index.cshtml"
                                                Write(item.homestay.Slngayo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        <button type=""button"" class=""btn btn-primary btn-sm me-1 mb-2"" data-mdb-toggle=""tooltip""
                                                title=""Remove item"">
                                            <i class=""fas fa-trash""></i>
                                        </button>
                                        <button type=""button"" class=""btn btn-danger btn-sm mb-2"" data-mdb-toggle=""tooltip""
                                                title=""Move to the wish list"">
                                            <i class=""fas fa-heart""></i>
                                        </button>
                                        <!-- Data -->
                                    </div>

                                    <div class=""col-lg-4 col-md-6 mb-4 mb-lg-0"">
                                        <!-- Quantity -->
                                        <div class=""d-flex mb-4"" style=""max-width: 300px"">
                              ");
            WriteLiteral(@"              <button class=""btn btn-primary px-3 me-2""
                                                    onclick=""this.parentNode.querySelector('input[type=number]').stepDown()"">
                                                <i class=""fas fa-minus""></i>
                                            </button>

                                            <div class=""form-outline"">
                                                <input id=""form1"" min=""0"" name=""quantity"" value=""1"" type=""number"" class=""form-control"" />
                                                <label class=""form-label"" for=""form1"">Quantity</label>
                                            </div>

                                            <button class=""btn btn-primary px-3 ms-2""
                                                    onclick=""this.parentNode.querySelector('input[type=number]').stepUp()"">
                                                <i class=""fas fa-plus""></i>
                                            </b");
            WriteLiteral(@"utton>
                                        </div>
                                        <!-- Quantity -->
                                        <!-- Price -->
                                        <p class=""text-start text-md-center"">
                                            <strong>");
#nullable restore
#line 82 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\ShoppingCart\Index.cshtml"
                                               Write(item.homestay.Giatien.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("VNĐ</strong>\r\n                                        </p>\r\n                                        <!-- Price -->\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 87 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\ShoppingCart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <hr class=""my-4"" />


                        </div>
                    </div>
                    <div class=""card mb-4"">
                        <div class=""card-body"">
                            <p><strong>Expected shipping delivery</strong></p>
                            <p class=""mb-0"">12.10.2020 - 14.10.2020</p>
                        </div>
                    </div>
                    <div class=""card mb-4 mb-lg-0"">
                        <div class=""card-body"">
                            <p><strong>We accept</strong></p>
                            <img class=""me-2"" width=""45px""
                                 src=""https://mdbcdn.b-cdn.net/wp-content/plugins/woocommerce-gateway-stripe/assets/images/visa.svg""
                                 alt=""Visa"" />
                            <img class=""me-2"" width=""45px""
                                 src=""https://mdbcdn.b-cdn.net/wp-content/plugins/woocommerce-gateway-stripe/assets/images/amex.svg""
 ");
            WriteLiteral(@"                                alt=""American Express"" />
                            <img class=""me-2"" width=""45px""
                                 src=""https://mdbcdn.b-cdn.net/wp-content/plugins/woocommerce-gateway-stripe/assets/images/mastercard.svg""
                                 alt=""Mastercard"" />

                        </div>
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""card mb-4"">
                        <div class=""card-header py-3"">
                            <h5 class=""mb-0"">Summary</h5>
                        </div>
                        <div class=""card-body"">
                            <ul class=""list-group list-group-flush"">
                                <li class=""list-group-item d-flex justify-content-between align-items-center border-0 px-0 pb-0"">
                                    Thành tiền
");
            WriteLiteral(@"                                </li>
                                <li class=""list-group-item d-flex justify-content-between align-items-center px-0"">
                                    Phí vận chuyển
                                    <span>Gratis</span>
                                </li>
                                <li class=""list-group-item d-flex justify-content-between align-items-center border-0 px-0 mb-3"">
                                    <div>
                                        <strong>Total amount</strong>
                                        <strong>
                                            <p class=""mb-0"">(including VAT)</p>
                                        </strong>
                                    </div>
                                    <span><strong>$53.98</strong></span>
                                </li>
                            </ul>

                            <button type=""button"" class=""btn btn-primary btn-lg btn-block"">
      ");
            WriteLiteral("                          Thanh toán\r\n                            </button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 149 "E:\TAILIEUHOCTAP\HK1_Nam4\Cong Nghe Web ASP\DoAn\Project_ChinhThuc\Website_DatPhong_TrucTuyen\Website_DatPhong_TrucTuyen\Views\ShoppingCart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <h3  style=""font-family:'Times New Roman', Times, serif;font-weight:900;color:aliceblue;padding-top:100px"">Thật đáng tiết!</h3>
        <h3 style=""font-family:'Times New Roman', Times, serif;font-weight:900;color:aliceblue"">Bạn chưa chọn được phòng yêu thích!</h3>
        <button type=""button"" class=""btn btn-danger"">Đi đến trang homestays</button>
    </div>

   
    </section>

");
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
