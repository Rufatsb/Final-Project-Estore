#pragma checksum "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "401888732e4578156c3268d45b79fea54764c243"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"401888732e4578156c3268d45b79fea54764c243", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d57143e42e39f1afd6f41845c7aac5eb46771252", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 5 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Category\Index.cshtml"
Write(await Component.InvokeAsync("Banner",new { Title = "Category" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

   <!-- Latest products area starts -->
    <section id=""latest-products"" class=""category-filter-pading"">
        <div class=""container"">
            <div class=""row product-btn d-flex justify-content-start align-items-start"">
                <div class=""col-xl-8 col-lg-7 col-md-7"">
                    <ul id=""filter-group"" class=""filter-group float-start"">
                        <li class=""filter-item""><a class=""filter-item-btn active"" onclick=""filterSelection('all')"" href=""javascript:void(0);"">All</a></li>
                        <li class=""filter-item""><a class=""filter-item-btn"" onclick=""filterSelection('new')"" href=""javascript:void(0);"">New</a></li>
                        <li class=""filter-item""><a class=""filter-item-btn"" onclick=""filterSelection('featured')"" href=""javascript:void(0);"">Featured</a> </li>
                        <li class=""filter-item""><a class=""filter-item-btn"" onclick=""filterSelection('offer')"" href=""javascript:void(0);"">Offer</a></li>
                    </ul>
         ");
            WriteLiteral(@"       </div>
            </div>
            <div class=""row"">


                <div class=""col-xl-4 col-lg-4 col-md-6 filterDiv new offer"">

                    <div class=""single-product mb-60"">
                        <div class=""product-img"">
                            <img src=""images/filter1.webp""");
            BeginWriteAttribute("alt", " alt=\"", 1466, "\"", 1472, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""new-product"">
                                <span>New</span>
                            </div>
                        </div>
                        <div class=""product-caption"">
                            <div class=""product-ratting"">
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star low-star""></i>
                                <i class=""far fa-star low-star""></i>
                            </div>
                            <h4><a href=""#"">Shorts</a></h4>
                            <div class=""price"">
                                <ul>
                                    <li>$10.00</li>
                                    <li class=""discount"">$20.00</li>
                                </ul>
                            </div>
                        </div");
            WriteLiteral(@">
                    </div>
                </div>
                <div class=""col-xl-4 col-lg-4 col-md-6 filterDiv featured"">
                    <div class=""single-product mb-60"">
                        <div class=""product-img"">
                            <img src=""images/filter2.webp""");
            BeginWriteAttribute("alt", " alt=\"", 2794, "\"", 2800, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""product-caption"">
                            <div class=""product-ratting"">
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star low-star""></i>
                                <i class=""far fa-star low-star""></i>
                            </div>
                            <h4><a href=""#"">Green sweater</a></h4>
                            <div class=""price"">
                                <ul>
                                    <li>$20.00</li>
                                    <li class=""discount"">$40.00</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-4 col-lg-4 col-md-6 filterDiv new offer"">
 ");
            WriteLiteral("                   <div class=\"single-product mb-60\">\r\n                        <div class=\"product-img\">\r\n                            <img src=\"images/filter3.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 3989, "\"", 3995, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""new-product"">
                                <span>New</span>
                            </div>
                        </div>
                        <div class=""product-caption"">
                            <div class=""product-ratting"">
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star low-star""></i>
                                <i class=""far fa-star low-star""></i>
                            </div>
                            <h4><a href=""#"">Yellow sweater</a></h4>
                            <div class=""price"">
                                <ul>
                                    <li>$25.00</li>
                                    <li class=""discount"">$50.00</li>
                                </ul>
                            </div>
                     ");
            WriteLiteral(@"   </div>
                    </div>
                </div>
                <div class=""col-xl-4 col-lg-4 col-md-6 filterDiv featured offer"">
                    <div class=""single-product mb-60"">
                        <div class=""product-img"">
                            <img src=""images/filter4.webp""");
            BeginWriteAttribute("alt", " alt=\"", 5331, "\"", 5337, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                        </div>
                        <div class=""product-caption"">
                            <div class=""product-ratting"">
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star low-star""></i>
                                <i class=""far fa-star low-star""></i>
                            </div>
                            <h4><a href=""#"">Gray shirt</a></h4>
                            <div class=""price"">
                                <ul>
                                    <li>$10.00</li>
                                    <li class=""discount"">$25.00</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-4 col-lg-4 col-md-6 filterDiv offer"">
      ");
            WriteLiteral("              <div class=\" single-product mb-60\">\r\n                        <div class=\"product-img\">\r\n                            <img src=\"images/filter5.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 6522, "\"", 6528, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                        </div>
                        <div class=""product-caption"">
                            <div class=""product-ratting"">
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star low-star""></i>
                                <i class=""far fa-star low-star""></i>
                            </div>
                            <h4><a href=""#"">Sweatpants</a></h4>
                            <div class=""price"">
                                <ul>
                                    <li>$20.00</li>
                                    <li class=""discount"">$30.00</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-4 col-lg-4 col-md-6 filterDiv new featured"">");
            WriteLiteral("\n                    <div class=\"single-product mb-60\">\r\n                        <div class=\"product-img\">\r\n                            <img src=\"images/filter6.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 7719, "\"", 7725, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""new-product"">
                                <span>New</span>
                            </div>
                        </div>
                        <div class=""product-caption"">
                            <div class=""product-ratting"">
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star low-star""></i>
                                <i class=""far fa-star low-star""></i>
                            </div>
                            <h4><a href=""#"">Jeans jacket</a></h4>
                            <div class=""price"">
                                <ul>
                                    <li>$60.00</li>
                                    <li class=""discount"">$100.00</li>
                                </ul>
                            </div>
                      ");
            WriteLiteral("  </div>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </section>\r\n    <!-- Latest products area ends -->\r\n ");
#nullable restore
#line 181 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Category\Index.cshtml"
Write(await Html.PartialAsync("_LatestSubscribePartial",Model.LatestSubscribe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 182 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Category\Index.cshtml"
Write(await Html.PartialAsync("_ShopMethodPartial",Model.ShopMethods));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 183 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Category\Index.cshtml"
Write(await Html.PartialAsync("_GalleryPartial",Model.Galleries));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
