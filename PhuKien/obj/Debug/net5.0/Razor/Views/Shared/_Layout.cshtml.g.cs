#pragma checksum "D:\DA\PhuKien\PhuKien\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b84753a6b569ba7e03cca38021f79a73c1913d30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b84753a6b569ba7e03cca38021f79a73c1913d30", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdae5b648276f2aeba37a008a47c34c89b500854", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/Toastr/build/toastr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/tim-kiem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-model-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/Toastr/build/toastr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84753a6b569ba7e03cca38021f79a73c1913d306105", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""description"" content=""Male_Fashion Template"">
    <meta name=""keywords"" content=""Male_Fashion, unica, creative, html"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Male-Fashion | Template</title>

    <!-- Google Font -->
    <link href=""https://fonts.googleapis.com/css2?family=Nunito+Sans:wght@300;400;600;700;800;900&display=swap""
          rel=""stylesheet"">

    <!-- Css Styles -->
    <link rel=""stylesheet"" href=""/assets/css/bootstrap.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/assets/css/font-awesome.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/assets/css/elegant-icons.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/assets/css/magnific-popup.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/assets/css/nice-select.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/assets/css/owl.carousel.min.css"" ty");
                WriteLiteral("pe=\"text/css\">\r\n    <link rel=\"stylesheet\" href=\"/assets/css/slicknav.min.css\" type=\"text/css\">\r\n    <link rel=\"stylesheet\" href=\"/assets/css/style.css\" type=\"text/css\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b84753a6b569ba7e03cca38021f79a73c1913d307670", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84753a6b569ba7e03cca38021f79a73c1913d309556", async() => {
                WriteLiteral(@"
    <!-- Page Preloder -->
    <div id=""preloder"">
        <div class=""loader""></div>
    </div>

    <!-- Offcanvas Menu Begin -->
    <div class=""offcanvas-menu-overlay""></div>
    <div class=""offcanvas-menu-wrapper"">
        <div class=""offcanvas__option"">
            <div class=""offcanvas__links"">
                <a href=""#"">Sign in</a>
                <a href=""#"">FAQs</a>
            </div>
            <div class=""offcanvas__top__hover"">
                <span>Usd <i class=""arrow_carrot-down""></i></span>
                <ul>
                    <li>USD</li>
                    <li>EUR</li>
                    <li>USD</li>
                </ul>
            </div>
        </div>
        <div class=""offcanvas__nav__option"">
            <a href=""#"" class=""search-switch""><img src=""/assets/img/icon/search.png""");
                BeginWriteAttribute("alt", " alt=\"", 2173, "\"", 2179, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n            <a href=\"#\"><img src=\"/assets/img/icon/heart.png\"");
                BeginWriteAttribute("alt", " alt=\"", 2248, "\"", 2254, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n            <a href=\"#\"><img src=\"/assets/img/icon/cart.png\"");
                BeginWriteAttribute("alt", " alt=\"", 2322, "\"", 2328, 0);
                EndWriteAttribute();
                WriteLiteral(@"> <span>0</span></a>
            <div class=""price"">$0.00</div>
        </div>
        <div id=""mobile-menu-wrap""></div>
        <div class=""offcanvas__text"">
            <p>Mi???n ph?? ship, ?????i tr??? sau 30 ng??y</p>
        </div>
    </div>
    <!-- Offcanvas Menu End -->
    <!-- Header Section Begin -->
    <header class=""header"">
        <div class=""header__top"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-6 col-md-7"">
                        <div class=""header__top__left"">
                            <p>Mi???n ph?? ship, ?????i tr??? sau 30 ng??y</p>
                        </div>
                    </div>
                    <div class=""col-lg-6 col-md-5"">
                        <div class=""header__top__right"">
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""container"">
            <div class=""row"">
       ");
                WriteLiteral("         <div class=\"col-lg-3 col-md-3\">\r\n                    <div class=\"header__logo\" style=\"padding:0;\">\r\n                        <a href=\"/\"><img src=\"/assets/img/logo.png\"");
                BeginWriteAttribute("alt", " alt=\"", 3529, "\"", 3535, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                    </div>
                </div>
                <div class=""col-lg-6 col-md-6"">
                    <nav class=""header__menu mobile-menu"">
                        <ul>
                            <li class=""active""><a href=""/"">Trang ch???</a></li>
                            <li><a href=""/shop"">Shop</a></li>
                            <li><a href=""/gio-hang"">Gi??? h??ng</a></li>
                            <li><a href=""/tin-tuc"">Tin t???c</a></li>
                            <li><a href=""/lien-he"">Li??n h???</a></li>
                        </ul>
                    </nav>
                </div>
                <div class=""col-lg-3 col-md-3"">
                    <div class=""header__nav__option"">
                        <a href=""#"" class=""search-switch""><img src=""/assets/img/icon/search.png""");
                BeginWriteAttribute("alt", " alt=\"", 4368, "\"", 4374, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                        <a href=\"/gio-hang\"><img src=\"/assets/img/icon/cart.png\"");
                BeginWriteAttribute("alt", " alt=\"", 4462, "\"", 4468, 0);
                EndWriteAttribute();
                WriteLiteral(@"> <span class=""lbl_number_items_header"">0</span></a>
                    </div>
                </div>
            </div>
            <div class=""canvas__open""><i class=""fa fa-bars""></i></div>
        </div>
    </header>
    <!-- Header Section End -->

    ");
#nullable restore
#line 111 "D:\DA\PhuKien\PhuKien\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- Footer Section Begin -->
    <footer class=""footer"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 col-md-6 col-sm-6"">
                    <div class=""footer__about"">
                        <div class=""footer__logo"" style=""padding;0;"">
                            <a href=""#""><img src=""/assets/img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 5129, "\"", 5135, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                        </div>\r\n                        <p>Kh??ch h??ng l?? tr???ng t??m c???a m?? h??nh kinh doanh ?????c ????o c???a ch??ng t??i</p>\r\n                        <a href=\"#\"><img src=\"/assets/img/payment.png\"");
                BeginWriteAttribute("alt", " alt=\"", 5346, "\"", 5352, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                    </div>
                </div>
                <div class=""col-lg-2 offset-lg-1 col-md-3 col-sm-6"">
                    <div class=""footer__widget"">
                        <h6>C???a h??ng</h6>
                        <ul>
                            <li><a href=""#"">Trang ch???</a></li>
                            <li><a href=""#"">Shop</a></li>
                            <li><a href=""#"">Gi??? h??ng</a></li>
                            <li><a href=""#"">Li??n h???</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-2 col-md-3 col-sm-6"">
                    <div class=""footer__widget"">
                        <h6>Shopping</h6>
                        <ul>
                            <li><a href=""#"">Trang ch???</a></li>
                            <li><a href=""#"">Shop</a></li>
                            <li><a href=""#"">Gi??? h??ng</a></li>
                            <li><a href=""#"">Li??n h???</a></li>
            ");
                WriteLiteral(@"            </ul>
                    </div>
                </div>
                <div class=""col-lg-3 offset-lg-1 col-md-6 col-sm-6"">
                    <div class=""footer__widget"">
                        <h6>NewLetter</h6>
                        <div class=""footer__newslatter"">
                            <p>G???i th?? v??? cho ch??ng t??i</p>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84753a6b569ba7e03cca38021f79a73c1913d3016813", async() => {
                    WriteLiteral("\r\n                                <input type=\"text\" placeholder=\"Your email\">\r\n                                <button type=\"submit\"><span class=\"icon_mail_alt\"></span></button>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-12 text-center"">
                    <div class=""footer__copyright__text"">
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        <p>
                            Copyright ??
                            <script>
                                document.write(new Date().getFullYear());
                            </script>
                            All rights reserved | This template is made with <i class=""fa fa-heart-o""
                                                                                aria-hidden=""true""></i> by <a href=""https://colorlib.com"" target=""_blank"">Colorlib</a>
                        </p>
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                    </div>
");
                WriteLiteral(@"                </div>
            </div>
        </div>
    </footer>
    <!-- Footer Section End -->
    <!-- Search Begin -->
    <div class=""search-model"">
        <div class=""h-100 d-flex align-items-center justify-content-center"">
            <div class=""search-close-switch"">+</div>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84753a6b569ba7e03cca38021f79a73c1913d3019802", async() => {
                    WriteLiteral("\r\n                <input type=\"text\" name=\"keyword\" id=\"search-input\" placeholder=\"T??m ki???m.....\">\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
    </div>
    <!-- Search End -->
    <!-- Js Plugins -->
    <script src=""/assets/js/jquery-3.3.1.min.js""></script>
    <script src=""/assets/js/bootstrap.min.js""></script>
    <script src=""/assets/js/jquery.nice-select.min.js""></script>
    <script src=""/assets/js/jquery.nicescroll.min.js""></script>
    <script src=""/assets/js/jquery.magnific-popup.min.js""></script>
    <script src=""/assets/js/jquery.countdown.min.js""></script>
    <script src=""/assets/js/jquery.slicknav.js""></script>
    <script src=""/assets/js/mixitup.min.js""></script>
    <script src=""/assets/js/owl.carousel.min.js""></script>
    <script src=""/assets/js/main.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84753a6b569ba7e03cca38021f79a73c1913d3022096", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84753a6b569ba7e03cca38021f79a73c1913d3023196", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<!-- Template Javascript -->\r\n    <script>\r\n        var site = new SiteController();\r\n        site.initialize();\r\n    </script>\r\n    ");
#nullable restore
#line 206 "D:\DA\PhuKien\PhuKien\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
