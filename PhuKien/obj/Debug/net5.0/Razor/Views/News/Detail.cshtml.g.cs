#pragma checksum "D:\DA\PhuKien\PhuKien\Views\News\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4391ec94730b802970e49e832f7191d5517005db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Detail), @"mvc.1.0.view", @"/Views/News/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4391ec94730b802970e49e832f7191d5517005db", @"/Views/News/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdae5b648276f2aeba37a008a47c34c89b500854", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhuKien.Data.News>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DA\PhuKien\PhuKien\Views\News\Detail.cshtml"
  
    ViewData["Title"] = "Chi tiết tin";
    var categories = (List<PhuKien.Data.CategoriesNew>)ViewBag.categories;
    var relatedNews = (List<PhuKien.Data.News>)ViewBag.relatedNews;
    var ListNews = (List<PhuKien.Data.News>)ViewBag.ListNews;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"blog-hero spad\">\r\n    <div class=\"container\">\r\n        <div class=\"row d-flex justify-content-center\">\r\n            <div class=\"col-lg-9 text-center\">\r\n                <div class=\"blog__hero__text\">\r\n                    <h2>");
#nullable restore
#line 14 "D:\DA\PhuKien\PhuKien\Views\News\Detail.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <ul>\r\n                        <li>By Huy Hoàng</li>\r\n                        <li>");
#nullable restore
#line 17 "D:\DA\PhuKien\PhuKien\Views\News\Detail.cshtml"
                       Write(Model.CreateDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<section class=\"blog-details spad\">\r\n    <div class=\"container\">\r\n        <div class=\"row d-flex justify-content-center\">\r\n");
            WriteLiteral("            <div class=\"col-lg-12\">\r\n                <div class=\"blog__details__content\">       \r\n                    <div class=\"blog__details__text\">\r\n                        ");
#nullable restore
#line 35 "D:\DA\PhuKien\PhuKien\Views\News\Detail.cshtml"
                   Write(Html.Raw(Model.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhuKien.Data.News> Html { get; private set; }
    }
}
#pragma warning restore 1591