#pragma checksum "C:\Users\Ali Aliyev\Desktop\Estore-back\Estore\Estore\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5f66ec8b3c08b89877c3e806eb16237a5f19aaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 2 "C:\Users\Ali Aliyev\Desktop\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f66ec8b3c08b89877c3e806eb16237a5f19aaa", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30da32e692647e729158d82bb7f9ab4a708bc393", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ali Aliyev\Desktop\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  ");
#nullable restore
#line 6 "C:\Users\Ali Aliyev\Desktop\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
Write(await Component.InvokeAsync("Banner",new { Title = "Contact Us" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    <!-- Contact area starts -->
    <section class=""contact-area"">
        <div class=""container"">
            <div class=""google-map  d-flex justify-content-center align-items-center mb-5"">
                <iframe src=""https://www.google.com/maps/embed?pb=!1m16!1m12!1m3!1d3039.4951384087035!2d49.85334576563304!3d40.375717516056376!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!2m1!1zMjcgw5x6ZXlpciBIYWPEsWLJmXlvdiwgQmFrw7w!5e0!3m2!1str!2s!4v1639429052219!5m2!1str!2s""
                    width=""100%"" height=""450px"" style=""border:0;"" allowfullscreen=""true"" loading=""lazy""></iframe>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <h2 class=""contact-title"">Get in Touch</h2>
                </div>
                <div class=""col-lg-8"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5f66ec8b3c08b89877c3e806eb16237a5f19aaa5393", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-12"">
                                <div class=""form-group"">
                                    <textarea class=""form-control w-100 h-100"" name=""message"" id=""message"" cols=""30"" rows=""9"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter Message'"" placeholder=""Enter Message"" style=""margin-top: 0px; margin-bottom: 0px; height: 87px;""></textarea>
                                </div>
                            </div>
                            <div style=""right:8px;"" class=""col-sm-6 position-relative"">
                                <div class=""form-group"">
                                    <input class=""form-control"" name=""name"" id=""name"" type=""text"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter your name'"" placeholder=""Enter your name"">
                                </div>
                            </div>
                            <div style=""left:8px"" class=""col-s");
                WriteLiteral(@"m-6 position-relative"">
                                <div class=""form-group"">
                                    <input class=""form-control"" name=""email"" id=""email"" type=""email"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter email address'"" placeholder=""Email"">
                                </div>
                            </div>
                            <div class=""col-12"">
                                <div class=""form-group"">
                                    <input class=""form-control"" name=""subject"" id=""subject"" type=""text"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter Subject'"" placeholder=""Enter Subject"">
                                </div>
                            </div>
                        </div>
                        <div class=""form-group mt-3"">
                            <button type=""submit"" class=""btn"">Send</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""col-lg-3 offset-lg-1"">
                    <div class=""contact-info"">
                        <span class=""contact-info-icon""><i class=""fas fa-home""></i></span>
                        <div class=""contact-info-body"">
                            <h3>Buttonwood, California.</h3>
                            <p>Rosemead, CA 91770</p>
                        </div>
                    </div>
                    <div class=""contact-info"">
                        <span class=""contact-info-icon""><i class=""fas fa-mobile-alt""></i></span>
                        <div class=""contact-info-body"">
                            <h3>+1 253 565 2365</h3>
                            <p>Mon to Fri 9am to 6pm</p>
                        </div>
                    </div>
                    <div class=""contact-info"">
                        <span class=""contact-info-icon""><i class=""far fa-envelope""></i></span>
                        <div class=""contact-info-body");
            WriteLiteral(@""">
                            <h3>support@colorlib.com</h3>
                            <p>Send us your query anytime!</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- Contact area ends -->

    <!-- Gallery area starts -->
    <section class=""gallery-wrapper plr-60"">
        <div class=""gallery-area"">
            <div class=""container-fluid"">
                <div class=""row justify-content-between"">
                    <div class=""gallery-image"">
                        <img src=""images/gallery.webp""");
            BeginWriteAttribute("alt", " alt=\"", 4645, "\"", 4651, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"gallery-image\">\r\n                        <img src=\"images/gallery1.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 4787, "\"", 4793, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"gallery-image\">\r\n                        <img src=\"images/gallery2.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 4929, "\"", 4935, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"gallery-image\">\r\n                        <img src=\"images/gallery3.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 5071, "\"", 5077, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"gallery-image\">\r\n                        <img src=\"images/gallery4.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 5213, "\"", 5219, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </section>\r\n    <!-- Gallery area ends -->\r\n");
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
