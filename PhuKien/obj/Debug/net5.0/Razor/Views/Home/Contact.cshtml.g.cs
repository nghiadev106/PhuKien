#pragma checksum "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "996d68a80e336fddb175bb3d0f45f9cff94ba07e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Views\_ViewImports.cshtml"
using MayTinh;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nghia\DoAnTotNghiep2022\Hoàng\PhuKien\PhuKien\Views\_ViewImports.cshtml"
using MayTinh.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"996d68a80e336fddb175bb3d0f45f9cff94ba07e", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ccc0fe1c0961240b5ee8476c8dce1d3a42796aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("frm-contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!--main area-->
<main id=""main"" class=""main-site left-sidebar"">

    <div class=""container"">

        <div class=""wrap-breadcrumb"">
            <ul>
                <li class=""item-link""><a href=""#"" class=""link"">home</a></li>
                <li class=""item-link""><span>Contact us</span></li>
            </ul>
        </div>
        <div class=""row"">
            <div class="" main-content-area"">
                <div class=""wrap-contacts "">
                    <div class=""col-lg-6 col-sm-6 col-md-6 col-xs-12"">
                        <div class=""contact-box contact-form"">
                            <h2 class=""box-title"">Leave a Message</h2>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "996d68a80e336fddb175bb3d0f45f9cff94ba07e4887", async() => {
                WriteLiteral("\n\n                                <label for=\"name\">Name<span>*</span></label>\n                                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 854, "\"", 862, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"name\" name=\"name\">\n\n                                <label for=\"email\">Email<span>*</span></label>\n                                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1017, "\"", 1025, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"email\" name=\"email\">\n\n                                <label for=\"phone\">Number Phone</label>\n                                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1175, "\"", 1183, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""phone"" name=""phone"">

                                <label for=""comment"">Comment</label>
                                <textarea name=""comment"" id=""comment""></textarea>

                                <input type=""submit"" name=""ok"" value=""Submit"">

                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
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
                    </div>
                    <div class=""col-lg-6 col-sm-6 col-md-6 col-xs-12"">
                        <div class=""contact-box contact-info"">
                            <div class=""wrap-map"">
                                <div class=""mercado-google-maps""
                                     id=""az-google-maps57341d9e51968""
                                     data-hue=""""
                                     data-lightness=""1""
                                     data-map-style=""2""
                                     data-saturation=""-100""
                                     data-modify-coloring=""false""
                                     data-title_maps=""Kute themes""
                                     data-phone=""088-465 9965 02""
                                     data-email=""kutethemes@gmail.com""
                                     data-address=""Z115 TP. Thai Nguyen""
                                     data-longitude=""-0.120850""
                 ");
            WriteLiteral(@"                    data-latitude=""51.508742""
                                     data-pin-icon=""""
                                     data-zoom=""16""
                                     data-map-type=""ROADMAP""
                                     data-map-height=""263"">
                                </div>
                            </div>
                            <h2 class=""box-title"">Contact Detail</h2>
                            <div class=""wrap-icon-box"">

                                <div class=""icon-box-item"">
                                    <i class=""fa fa-envelope"" aria-hidden=""true""></i>
                                    <div class=""right-info"">
                                        <b>Email</b>
                                        <p>Support1@Mercado.com</p>
                                    </div>
                                </div>

                                <div class=""icon-box-item"">
                                    <i class=""fa fa-phone"" aria-hidden=""true""><");
            WriteLiteral(@"/i>
                                    <div class=""right-info"">
                                        <b>Phone</b>
                                        <p>0123-465-789-111</p>
                                    </div>
                                </div>

                                <div class=""icon-box-item"">
                                    <i class=""fa fa-map-marker"" aria-hidden=""true""></i>
                                    <div class=""right-info"">
                                        <b>Mail Office</b>
                                        <p>Sed ut perspiciatis unde omnis<br />Street Name, Los Angeles</p>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div><!--end main products area-->

        </div><!--end row-->

    </div><!--end container-->

</main>
<!--main area-->");
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
