#pragma checksum "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89cd8c3effabf1147f447615dcdbc480c685a4b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ListProduct), @"mvc.1.0.view", @"/Views/Products/ListProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89cd8c3effabf1147f447615dcdbc480c685a4b9", @"/Views/Products/ListProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdae5b648276f2aeba37a008a47c34c89b500854", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ListProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhuKien.Models.PaginationSet<PhuKien.Data.Product>>
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
#line 2 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
  
    ViewData["Title"] = "Danh m???c s???n ph???m";
    var ListCate = (List<PhuKien.Data.Category>)ViewBag.ListCate;

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
                        <a href=""/"">Trang ch???</a>
                        <span>Shop</span>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89cd8c3effabf1147f447615dcdbc480c685a4b94611", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" name=\"keyword\" placeholder=\"T??m ki???m...\">\r\n                            <button type=\"submit\"><span class=\"icon_search\"></span></button>\r\n                        ");
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
                                    <a data-toggle=""collapse"" data-target=""#collapseTwo"">Danh m???c</a>
                                </div>
                                <div id=""collapseTwo"" class=""collapse show"" data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        <div class=""shop__sidebar__brand"">
                                            <ul>
");
#nullable restore
#line 45 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                                 if (ListCate.Count() > 0)
                                                {
                                                    foreach (var item in ListCate)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2241, "\"", 2276, 4);
            WriteAttributeValue("", 2248, "/danh-muc/", 2248, 10, true);
#nullable restore
#line 49 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 2258, item.Url, 2258, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2267, "/", 2267, 1, true);
#nullable restore
#line 49 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 2268, item.Id, 2268, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 50 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"

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
#line 66 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                     if (Model.Items.Count() > 0)
                    {
                        foreach (var item in Model.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 col-sm-6\">\r\n                        <div class=\"product__item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3110, "\"", 3145, 4);
            WriteAttributeValue("", 3117, "/san-pham/", 3117, 10, true);
#nullable restore
#line 72 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 3127, item.Url, 3127, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3136, "/", 3136, 1, true);
#nullable restore
#line 72 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 3137, item.Id, 3137, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"product__item__pic set-bg\" data-setbg=\"");
#nullable restore
#line 73 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                                                              Write(item.Logo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 74 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                     if (item.IsNew == true)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"label\">New</span>\r\n");
#nullable restore
#line 77 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </a>\r\n                            <div class=\"product__item__text\">\r\n                                <h6>");
#nullable restore
#line 82 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <a data-id=\"");
#nullable restore
#line 83 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""add-cart btn-add-cart-2"">+ Th??m gi??? h??ng</a>
                                <div class=""rating"">
                                    <i class=""fa fa-star""></i>
                                    <i class=""fa fa-star""></i>
                                    <i class=""fa fa-star""></i>
                                    <i class=""fa fa-star""></i>
                                    <i class=""fa fa-star-o""></i>
                                </div>
");
#nullable restore
#line 91 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                 if (item.PriceDiscount > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h6>");
#nullable restore
#line 93 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                   Write(item.PriceDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <del>");
#nullable restore
#line 93 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                                             Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del></h6>\r\n");
#nullable restore
#line 94 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h6>");
#nullable restore
#line 97 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 98 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 103 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-12\">\r\n");
#nullable restore
#line 108 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                             if (Model.TotalPages > 1)
                            {
                                var startPageIndex = Math.Max(1, Model.Page - Model.MaxPage / 2);
                                var endPageIndex = Math.Min(Model.TotalPages, Model.Page + Model.MaxPage / 2);


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <nav>\r\n                                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 115 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                         if (Model.Page > 1)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"page-item\">\r\n                                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5462, "\"", 5518, 5);
            WriteAttributeValue("", 5469, "?sort=", 5469, 6, true);
#nullable restore
#line 118 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 5475, Model.Sort, 5475, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5486, "&pageSize=", 5486, 10, true);
#nullable restore
#line 118 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 5496, Model.PageSize, 5496, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5511, "&page=1", 5511, 7, true);
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""First"">
                                                    <i class=""fa fa-angle-double-left""></i>
                                                </a>
                                            </li>
                                            <li class=""page-item"">
                                                <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 5875, "\"", 5945, 6);
            WriteAttributeValue("", 5882, "?sort=", 5882, 6, true);
#nullable restore
#line 123 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 5888, Model.Sort, 5888, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5899, "&pageSize=", 5899, 10, true);
#nullable restore
#line 123 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 5909, Model.PageSize, 5909, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5924, "&page=", 5924, 6, true);
#nullable restore
#line 123 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 5930, Model.Page-1, 5930, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                                    <i class=\"fa fa-angle-double-left\"></i>\r\n                                                </a>\r\n                                            </li>\r\n");
#nullable restore
#line 127 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                         for (int i = startPageIndex; i <= endPageIndex; i++)
                                        {
                                            if (Model.Page == i)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"active page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6560, "\"", 6617, 6);
            WriteAttributeValue("", 6567, "?sort=", 6567, 6, true);
#nullable restore
#line 132 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 6573, Model.Sort, 6573, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6584, "&pageSize=", 6584, 10, true);
#nullable restore
#line 132 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 6594, Model.PageSize, 6594, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6609, "&page=", 6609, 6, true);
#nullable restore
#line 132 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 6615, i, 6615, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 6618, "\"", 6634, 2);
            WriteAttributeValue("", 6626, "Trang", 6626, 5, true);
#nullable restore
#line 132 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue(" ", 6631, i, 6632, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 132 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                                                                                                                                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 133 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6883, "\"", 6940, 6);
            WriteAttributeValue("", 6890, "?sort=", 6890, 6, true);
#nullable restore
#line 136 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 6896, Model.Sort, 6896, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6907, "&pageSize=", 6907, 10, true);
#nullable restore
#line 136 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 6917, Model.PageSize, 6917, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6932, "&page=", 6932, 6, true);
#nullable restore
#line 136 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 6938, i, 6938, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 6941, "\"", 6957, 2);
            WriteAttributeValue("", 6949, "Trang", 6949, 5, true);
#nullable restore
#line 136 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue(" ", 6954, i, 6955, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 136 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                                                                                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 137 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                         if (Model.Page < Model.TotalPages)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"page-item\">\r\n                                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 7318, "\"", 7388, 6);
            WriteAttributeValue("", 7325, "?sort=", 7325, 6, true);
#nullable restore
#line 142 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 7331, Model.Sort, 7331, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7342, "&pageSize=", 7342, 10, true);
#nullable restore
#line 142 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 7352, Model.PageSize, 7352, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7367, "&page=", 7367, 6, true);
#nullable restore
#line 142 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 7373, Model.Page+1, 7373, 15, false);

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
            BeginWriteAttribute("href", " href=\"", 7745, "\"", 7817, 6);
            WriteAttributeValue("", 7752, "?sort=", 7752, 6, true);
#nullable restore
#line 147 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 7758, Model.Sort, 7758, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7769, "&pageSize=", 7769, 10, true);
#nullable restore
#line 147 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 7779, Model.PageSize, 7779, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7794, "&page=", 7794, 6, true);
#nullable restore
#line 147 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 7800, Model.TotalPages, 7800, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Last\">\r\n                                                    <i class=\"fa fa-angle-double-right\"></i>\r\n                                                </a>\r\n                                            </li>\r\n");
#nullable restore
#line 151 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                </nav>\r\n");
#nullable restore
#line 154 "D:\DA\PhuKien\PhuKien\Views\Products\ListProduct.cshtml"
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
