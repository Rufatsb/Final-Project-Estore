#pragma checksum "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c18ba9ce7e735f45989f03423cce6657323849a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 2 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.AboutViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.ProductViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.BlogViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.HomeViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.ContactViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.CategoryViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c18ba9ce7e735f45989f03423cce6657323849a", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d57143e42e39f1afd6f41845c7aac5eb46771252", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 5 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Product\Index.cshtml"
Write(await Component.InvokeAsync("Banner",new { Title = "Product List" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

   <!-- Product List area starts -->
    <section class=""product-list"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-4"">
                    <div class=""product-filter"">
                        <div class=""single-product-filter-div"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c18ba9ce7e735f45989f03423cce6657323849a5823", async() => {
                WriteLiteral("\r\n                                <input type=\"text\" name=\"#\" placeholder=\"Search keyword\">\r\n                                <i class=\"fas fa-search\"></i>\r\n                            ");
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


                        <div class=""single-product-filter-div"">
                            <div class=""product-categories"">
                                <div class=""category-list"">Category <i class=""right fas fa-caret-down""></i> </div>
                                <div class=""category-list-items"" style=""display: none;"">
                                    <p><a href=""#"">New</a></p>
                                    <p><a href=""#""> Featured</a></p>
                                    <p><a href=""#"">Offer</a></p>
                                </div>
                            </div>
                        </div>
                        <div class=""single-product-filter-div"">
                            <div class=""product-prices"">
                                <div class=""price-list"">Price <i class=""right fas fa-caret-down""></i> </div>
                                <div class=""price-list-items"" style=""display: none;"">
                         ");
            WriteLiteral(@"           <p><a href=""#"">$5-$20</a></p>
                                    <p><a href=""#""> $20-$100</a></p>
                                    <p><a href=""#"">$100-$500</a></p>
                                </div>
                            </div>
                        </div>



                    </div>
                </div>
                <div class=""col-md-8"">
                    <div class=""product-items"">
                        <div class=""row"">
                            <div class=""col-lg-6 col-sm-6"">
                                <div class=""single-product-item"">
                                    <img src=""images/filter6.webp""");
            BeginWriteAttribute("alt", " alt=\"", 2361, "\"", 2367, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <h3><a href=""single-product.html"">Cervical pillow for airplane car office nap pillow</a> </h3>
                                    <p>From $5</p>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-sm-6"">
                                <div class=""single-product-item"">
                                    <img src=""images/filter5.webp""");
            BeginWriteAttribute("alt", " alt=\"", 2825, "\"", 2831, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <h3><a href=""single-product.html"">Geometric striped flower home classy decor</a> </h3>
                                    <p>From $5</p>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-sm-6"">
                                <div class=""single-product-item"">
                                    <img src=""images/filter3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 3281, "\"", 3287, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <h3><a href=""single-product.html"">Foam filling cotton slow rebound pillows</a> </h3>
                                    <p>From $5</p>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-sm-6"">
                                <div class=""single-product-item"">
                                    <img src=""images/filter4.webp""");
            BeginWriteAttribute("alt", " alt=\"", 3735, "\"", 3741, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <h3><a href=""single-product.html"">Memory foam filling cotton Slow rebound pillows</a> </h3>
                                    <p>From $5</p>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-sm-6"">
                                <div class=""single-product-item"">
                                    <img src=""images/filter2.webp""");
            BeginWriteAttribute("alt", " alt=\"", 4196, "\"", 4202, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <h3><a href=""single-product.html"">Sleeping orthopedic sciatica Back Hip Joint Pain relief</a> </h3>
                                    <p>From $5</p>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-sm-6"">
                                <div class=""single-product-item"">
                                    <img src=""images/filter1.webp""");
            BeginWriteAttribute("alt", " alt=\"", 4665, "\"", 4671, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                                    <h3><a href=""single-product.html"">Memory foam filling cotton Slow rebound pillows</a> </h3>
                                    <p>From $5</p>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-sm-6"">
                                <div class=""single-product-item"">
                                    <img src=""images/filter3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 5128, "\"", 5134, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <h3><a href=""single-product.html"">Cervical pillow for airplane car office nap pillow</a> </h3>
                                    <p>From $5</p>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-sm-6"">
                                <div class=""single-product-item"">
                                    <img src=""images/filter5.webp""");
            BeginWriteAttribute("alt", " alt=\"", 5592, "\"", 5598, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <h3> <a href=""single-product.html"">Geometric striped flower home classy decor</a> </h3>
                                    <p>From $5</p>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-sm-6"">
                                <div class=""single-product-item"">
                                    <img src=""images/filter4.webp""");
            BeginWriteAttribute("alt", " alt=\"", 6049, "\"", 6055, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <h3>
                                        <a href=""single-product.html"">Sleeping orthopedic sciatica Back Hip Joint Pain relief</a></h3>
                                    <p>From $5</p>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-sm-6"">
                                <div class=""single-product-item"">
                                    <img src=""images/filter2.webp""");
            BeginWriteAttribute("alt", " alt=\"", 6559, "\"", 6565, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <h3>
                                        <a href=""single-product.html"">Memory foam filling cotton Slow rebound pillows</a></h3>
                                    <p>From $5</p>
                                </div>
                            </div>
                        </div>
                        <div class=""text-center"">
                            <button class=""load-more"">Load More</button>
                        </div>


                    </div>

                </div>
            </div>
        </div>
    </section>
    <!-- Product List area ends -->
    ");
#nullable restore
#line 135 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Product\Index.cshtml"
Write(await Component.InvokeAsync("Testimonial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 136 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Product\Index.cshtml"
Write(await Html.PartialAsync("_ShopMethodPartial",Model.ShopMethods));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 137 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Product\Index.cshtml"
Write(await Html.PartialAsync("_SubscribePartial", Model.Subscribe));

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
