#pragma checksum "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df3189c940d6a8511df69b77285e5ecb7100d499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ProductCategories), @"mvc.1.0.view", @"/Views/Products/ProductCategories.cshtml")]
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
#line 1 "D:\DA\PhuKien\PhuKien\Views\_ViewImports.cshtml"
using PhuKien;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DA\PhuKien\PhuKien\Views\_ViewImports.cshtml"
using PhuKien.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df3189c940d6a8511df69b77285e5ecb7100d499", @"/Views/Products/ProductCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdae5b648276f2aeba37a008a47c34c89b500854", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ProductCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhuKien.Models.PaginationSet<PhuKien.Data.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/tim-kiem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
  
    ViewData["Title"] = "Danh mục sản phẩm";
    var ListCate = (List<PhuKien.Data.Category>)ViewBag.ListCate;
    var cate = (PhuKien.Data.Category)ViewBag.category;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Breadcrumb Section Begin -->
<section class=""breadcrumb-option"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb__text"">
                    <div class=""breadcrumb__links"">
                        <a href=""/"">Trang chủ</a>
                        <span>");
#nullable restore
#line 16 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                         Write(cate.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->
<!-- Shop Section Begin -->
<section class=""shop spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""shop__sidebar"">
                    <div class=""shop__sidebar__search"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df3189c940d6a8511df69b77285e5ecb7100d4994919", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" name=\"keyword\" placeholder=\"Tìm kiếm...\">\r\n                            <button type=\"submit\"><span class=\"icon_search\"></span></button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""shop__sidebar__accordion"">
                        <div class=""accordion"" id=""accordionExample"">
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseTwo"">Danh mục</a>
                                </div>
                                <div id=""collapseTwo"" class=""collapse show"" data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        <div class=""shop__sidebar__brand"">
                                            <ul>
");
#nullable restore
#line 46 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                                 if (ListCate.Count() > 0)
                                                {
                                                    foreach (var item in ListCate)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2304, "\"", 2339, 4);
            WriteAttributeValue("", 2311, "/danh-muc/", 2311, 10, true);
#nullable restore
#line 50 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 2321, item.Url, 2321, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2330, "/", 2330, 1, true);
#nullable restore
#line 50 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 2331, item.Id, 2331, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 51 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"

                                                    }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>


                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-9"">
                <div class=""row"">
");
#nullable restore
#line 67 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                     if (Model.Items.Count() > 0)
                    {
                        foreach (var item in Model.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-4 col-md-6 col-sm-6\">\r\n                                <div class=\"product__item\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3197, "\"", 3232, 4);
            WriteAttributeValue("", 3204, "/san-pham/", 3204, 10, true);
#nullable restore
#line 73 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 3214, item.Url, 3214, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3223, "/", 3223, 1, true);
#nullable restore
#line 73 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 3224, item.Id, 3224, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"product__item__pic set-bg\" data-setbg=\"");
#nullable restore
#line 74 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                                                                      Write(item.Logo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 75 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                             if (item.IsNew == true)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"label\">New</span>\r\n");
#nullable restore
#line 78 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </a>\r\n                                    <div class=\"product__item__text\">\r\n                                        <h6>");
#nullable restore
#line 83 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <a data-id=\"");
#nullable restore
#line 84 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""add-cart btn-add-cart-2"">+ Thêm giỏ hàng</a>
                                        <div class=""rating"">
                                            <i class=""fa fa-star""></i>
                                            <i class=""fa fa-star""></i>
                                            <i class=""fa fa-star""></i>
                                            <i class=""fa fa-star""></i>
                                            <i class=""fa fa-star-o""></i>
                                        </div>
");
#nullable restore
#line 92 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                         if (item.PriceDiscount > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h6>");
#nullable restore
#line 94 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                           Write(item.PriceDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <del>");
#nullable restore
#line 94 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del></h6>\r\n");
#nullable restore
#line 95 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h6>");
#nullable restore
#line 98 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 99 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 104 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-12\">\r\n");
#nullable restore
#line 109 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                         if (Model.TotalPages > 1)
                        {
                            var startPageIndex = Math.Max(1, Model.Page - Model.MaxPage / 2);
                            var endPageIndex = Math.Min(Model.TotalPages, Model.Page + Model.MaxPage / 2);


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <nav>\r\n                                <ul class=\"pagination\">\r\n");
#nullable restore
#line 116 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                     if (Model.Page > 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"page-item\">\r\n                                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5725, "\"", 5781, 5);
            WriteAttributeValue("", 5732, "?sort=", 5732, 6, true);
#nullable restore
#line 119 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 5738, Model.Sort, 5738, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5749, "&pageSize=", 5749, 10, true);
#nullable restore
#line 119 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 5759, Model.PageSize, 5759, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5774, "&page=1", 5774, 7, true);
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""First"">
                                                <i class=""fa fa-angle-double-left""></i>
                                            </a>
                                        </li>
                                        <li class=""page-item"">
                                            <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 6118, "\"", 6188, 6);
            WriteAttributeValue("", 6125, "?sort=", 6125, 6, true);
#nullable restore
#line 124 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 6131, Model.Sort, 6131, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6142, "&pageSize=", 6142, 10, true);
#nullable restore
#line 124 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 6152, Model.PageSize, 6152, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6167, "&page=", 6167, 6, true);
#nullable restore
#line 124 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 6173, Model.Page-1, 6173, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                                <i class=\"fa fa-angle-double-left\"></i>\r\n                                            </a>\r\n                                        </li>\r\n");
#nullable restore
#line 128 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                     for (int i = startPageIndex; i <= endPageIndex; i++)
                                    {
                                        if (Model.Page == i)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"active page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6767, "\"", 6824, 6);
            WriteAttributeValue("", 6774, "?sort=", 6774, 6, true);
#nullable restore
#line 133 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 6780, Model.Sort, 6780, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6791, "&pageSize=", 6791, 10, true);
#nullable restore
#line 133 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 6801, Model.PageSize, 6801, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6816, "&page=", 6816, 6, true);
#nullable restore
#line 133 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 6822, i, 6822, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 6825, "\"", 6841, 2);
            WriteAttributeValue("", 6833, "Trang", 6833, 5, true);
#nullable restore
#line 133 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue(" ", 6838, i, 6839, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 133 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                                                                                                                                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 134 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 7074, "\"", 7131, 6);
            WriteAttributeValue("", 7081, "?sort=", 7081, 6, true);
#nullable restore
#line 137 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 7087, Model.Sort, 7087, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7098, "&pageSize=", 7098, 10, true);
#nullable restore
#line 137 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 7108, Model.PageSize, 7108, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7123, "&page=", 7123, 6, true);
#nullable restore
#line 137 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 7129, i, 7129, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 7132, "\"", 7148, 2);
            WriteAttributeValue("", 7140, "Trang", 7140, 5, true);
#nullable restore
#line 137 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue(" ", 7145, i, 7146, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 137 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                                                                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 138 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                     if (Model.Page < Model.TotalPages)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"page-item\">\r\n                                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 7485, "\"", 7555, 6);
            WriteAttributeValue("", 7492, "?sort=", 7492, 6, true);
#nullable restore
#line 143 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 7498, Model.Sort, 7498, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7509, "&pageSize=", 7509, 10, true);
#nullable restore
#line 143 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 7519, Model.PageSize, 7519, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7534, "&page=", 7534, 6, true);
#nullable restore
#line 143 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 7540, Model.Page+1, 7540, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Next"">
                                                <i class=""fa fa-angle-double-right""></i>
                                            </a>
                                        </li>
                                        <li class=""page-item"">
                                            <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 7892, "\"", 7964, 6);
            WriteAttributeValue("", 7899, "?sort=", 7899, 6, true);
#nullable restore
#line 148 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 7905, Model.Sort, 7905, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7916, "&pageSize=", 7916, 10, true);
#nullable restore
#line 148 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 7926, Model.PageSize, 7926, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7941, "&page=", 7941, 6, true);
#nullable restore
#line 148 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
WriteAttributeValue("", 7947, Model.TotalPages, 7947, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Last\">\r\n                                                <i class=\"fa fa-angle-double-right\"></i>\r\n                                            </a>\r\n                                        </li>\r\n");
#nullable restore
#line 152 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n                            </nav>\r\n");
#nullable restore
#line 155 "D:\DA\PhuKien\PhuKien\Views\Products\ProductCategories.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhuKien.Models.PaginationSet<PhuKien.Data.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
