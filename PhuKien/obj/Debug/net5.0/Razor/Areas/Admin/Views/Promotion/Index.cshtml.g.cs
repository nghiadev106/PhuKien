#pragma checksum "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00507edc27f76703ddbd03a56a97d6d87530b8e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Promotion_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Promotion/Index.cshtml")]
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
#line 1 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\_ViewImports.cshtml"
using MayTinh;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\_ViewImports.cshtml"
using MayTinh.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00507edc27f76703ddbd03a56a97d6d87530b8e4", @"/Areas/Admin/Views/Promotion/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d4151a611409731679fded9ecf380ce1af8a10", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Promotion_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Promotion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    var lstPromotion = (List<MayTinh.Models.PromotionViewModel>)ViewBag.lstPromotion;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input type=\"hidden\" id=\"success\"");
            BeginWriteAttribute("value", " value=\"", 159, "\"", 187, 1);
#nullable restore
#line 6 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 167, TempData["success"], 167, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"warning\"");
            BeginWriteAttribute("value", " value=\"", 226, "\"", 254, 1);
#nullable restore
#line 7 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 234, TempData["warning"], 234, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"error\"");
            BeginWriteAttribute("value", " value=\"", 291, "\"", 317, 1);
#nullable restore
#line 8 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 299, TempData["error"], 299, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

<div class=""container-fluid"">
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách khuyến mãi</li>
    </ol>
    <div class=""card mb-12"">
        <div class=""card-header"">
            <div class=""row"">
                <div class=""col-md-6 col-xs-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00507edc27f76703ddbd03a56a97d6d87530b8e46375", async() => {
                WriteLiteral("Tạo mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"card-body\">\r\n            <div class=\"table-responsive\">\r\n");
#nullable restore
#line 26 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
                 if (lstPromotion.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>STT</th>
                                <th>Hình ảnh</th>
                                <th>Tên</th>
                                <th>Link</th>
                                <th>Thứ tự</th>
                                <th>Trạng thái</th>
                                <th>#</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 41 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
                              
                                var stt = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
                                 foreach (var item in lstPromotion)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 46 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
                                       Write(Html.Raw(stt = stt + 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><img");
            BeginWriteAttribute("src", " src=\"", 1969, "\"", 1985, 1);
#nullable restore
#line 47 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 1975, item.Logo, 1975, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:60px;\" /></td>\r\n                                        <td>");
#nullable restore
#line 48 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 49 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
                                       Write(item.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 50 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
                                       Write(item.DisplayOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 51 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
                                         if (item.Status == 1)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><span class=\"btn-success\">Hiển thị</span></td>\r\n");
#nullable restore
#line 54 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><span class=\"btn-danger\">Ẩn</span></td>\r\n");
#nullable restore
#line 58 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2766, "\"", 2803, 2);
            WriteAttributeValue("", 2773, "/Admin/Promotion/Edit/", 2773, 22, true);
#nullable restore
#line 60 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 2795, item.Id, 2795, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary glyphicon glyphicon-pencilt\">Sửa</a>\r\n                                            <a class=\"btn btn-danger glyphicon glyphicon-trash\" onclick=\"return confirm(\'Bạn có muốn xóa không?\');\"");
            BeginWriteAttribute("href", " href=\"", 3013, "\"", 3062, 3);
#nullable restore
#line 61 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 3020, Url.Action("Delete","Promotion"), 3020, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3053, "/", 3053, 1, true);
#nullable restore
#line 61 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 3054, item.Id, 3054, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 64 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 68 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Không có khuyến mãi nào nào</span>\r\n");
#nullable restore
#line 72 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Areas\Admin\Views\Promotion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
