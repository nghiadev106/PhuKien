#pragma checksum "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9af7c85663514872a935fcef0309bfabcc9414c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_ListNews), @"mvc.1.0.view", @"/Views/News/ListNews.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9af7c85663514872a935fcef0309bfabcc9414c9", @"/Views/News/ListNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdae5b648276f2aeba37a008a47c34c89b500854", @"/Views/_ViewImports.cshtml")]
    public class Views_News_ListNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhuKien.Models.PaginationSet<PhuKien.Data.News>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
  
    ViewData["Title"] = "Danh mục sản phẩm";
    var ListCate = (List<PhuKien.Data.CategoriesNew>)ViewBag.ListCate;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Breadcrumb Section Begin -->
<section class=""breadcrumb-blog set-bg"" data-setbg=""/assets/img/blog/banner.png"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h2>Tin tức</h2>
            </div>
        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->
<!-- Blog Section Begin -->
<section class=""blog spad"">
    <div class=""container"">
        <div class=""row"">
");
#nullable restore
#line 22 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
             if (Model.Items.Count() > 0)
            {
                foreach (var item in Model.Items)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 col-sm-6\">\r\n                        <div class=\"blog__item\">\r\n                            <div class=\"blog__item__pic set-bg\" data-setbg=\"");
#nullable restore
#line 28 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
                                                                       Write(item.Logo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></div>\r\n                            <div class=\"blog__item__text\">\r\n                                <span><img src=\"img/icon/calendar.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1101, "\"", 1107, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
                                                                         Write(item.CreateDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <h5>");
#nullable restore
#line 31 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1250, "\"", 1284, 4);
            WriteAttributeValue("", 1257, "/tin-tuc/", 1257, 9, true);
#nullable restore
#line 32 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 1266, item.Url, 1266, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1275, "/", 1275, 1, true);
#nullable restore
#line 32 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 1276, item.Id, 1276, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xem thêm</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 36 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 40 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
             if (Model.TotalPages > 1)
            {
                // Create numeric links
                var startPageIndex = Math.Max(1, Model.Page - Model.MaxPage / 2);
                var endPageIndex = Math.Min(Model.TotalPages, Model.Page + Model.MaxPage / 2);


#line default
#line hidden
#nullable disable
            WriteLiteral("                <nav>\r\n                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 48 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
                         if (Model.Page > 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\">\r\n                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1995, "\"", 2051, 5);
            WriteAttributeValue("", 2002, "?sort=", 2002, 6, true);
#nullable restore
#line 51 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 2008, Model.Sort, 2008, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2019, "&pageSize=", 2019, 10, true);
#nullable restore
#line 51 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 2029, Model.PageSize, 2029, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2044, "&page=1", 2044, 7, true);
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""First"">
                                    <i class=""fa fa-angle-double-left""></i>
                                </a>
                            </li>
                            <li class=""page-item"">
                                <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 2328, "\"", 2398, 6);
            WriteAttributeValue("", 2335, "?sort=", 2335, 6, true);
#nullable restore
#line 56 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 2341, Model.Sort, 2341, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2352, "&pageSize=", 2352, 10, true);
#nullable restore
#line 56 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 2362, Model.PageSize, 2362, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2377, "&page=", 2377, 6, true);
#nullable restore
#line 56 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 2383, Model.Page-1, 2383, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                    <i class=\"fa fa-angle-double-left\"></i>\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 60 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
                         for (int i = startPageIndex; i <= endPageIndex; i++)
                        {
                            if (Model.Page == i)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"active page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2869, "\"", 2926, 6);
            WriteAttributeValue("", 2876, "?sort=", 2876, 6, true);
#nullable restore
#line 65 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 2882, Model.Sort, 2882, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2893, "&pageSize=", 2893, 10, true);
#nullable restore
#line 65 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 2903, Model.PageSize, 2903, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2918, "&page=", 2918, 6, true);
#nullable restore
#line 65 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 2924, i, 2924, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2927, "\"", 2943, 2);
            WriteAttributeValue("", 2935, "Trang", 2935, 5, true);
#nullable restore
#line 65 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue(" ", 2940, i, 2941, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 65 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
                                                                                                                                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 66 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3128, "\"", 3185, 6);
            WriteAttributeValue("", 3135, "?sort=", 3135, 6, true);
#nullable restore
#line 69 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 3141, Model.Sort, 3141, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3152, "&pageSize=", 3152, 10, true);
#nullable restore
#line 69 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 3162, Model.PageSize, 3162, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3177, "&page=", 3177, 6, true);
#nullable restore
#line 69 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 3183, i, 3183, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3186, "\"", 3202, 2);
            WriteAttributeValue("", 3194, "Trang", 3194, 5, true);
#nullable restore
#line 69 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue(" ", 3199, i, 3200, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 69 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
                                                                                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 70 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
                         if (Model.Page < Model.TotalPages)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\">\r\n                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3467, "\"", 3537, 6);
            WriteAttributeValue("", 3474, "?sort=", 3474, 6, true);
#nullable restore
#line 75 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 3480, Model.Sort, 3480, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3491, "&pageSize=", 3491, 10, true);
#nullable restore
#line 75 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 3501, Model.PageSize, 3501, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3516, "&page=", 3516, 6, true);
#nullable restore
#line 75 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 3522, Model.Page+1, 3522, 15, false);

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
            BeginWriteAttribute("href", " href=\"", 3814, "\"", 3886, 6);
            WriteAttributeValue("", 3821, "?sort=", 3821, 6, true);
#nullable restore
#line 80 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 3827, Model.Sort, 3827, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3838, "&pageSize=", 3838, 10, true);
#nullable restore
#line 80 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 3848, Model.PageSize, 3848, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3863, "&page=", 3863, 6, true);
#nullable restore
#line 80 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
WriteAttributeValue("", 3869, Model.TotalPages, 3869, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Last\">\r\n                                    <i class=\"fa fa-angle-double-right\"></i>\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 84 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </nav>\r\n");
#nullable restore
#line 87 "D:\DA\PhuKien\PhuKien\Views\News\ListNews.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        </div>\r\n</section>\r\n<!-- Blog Section End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhuKien.Models.PaginationSet<PhuKien.Data.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
