#pragma checksum "C:\Users\Ali Aliyev\Desktop\Estore-back\Estore\Estore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb743bdcb3a9767fa7db7c49324573c1d5683e5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb743bdcb3a9767fa7db7c49324573c1d5683e5e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30da32e692647e729158d82bb7f9ab4a708bc393", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("javascript:void(0);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Ali Aliyev\Desktop\Estore-back\Estore\Estore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"   

      <!-- Hero Area starts  -->
    <section class=""slider-area"">
        <div class=""single-slider slider-height"" style=""background-image: url(&quot;images/h1_hero.jpg.webp&quot;);"">
            <div class=""container"">
                <div class=""row d-flex align-items-center justify-content-between"">
                    <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6 d-none d-md-block"">
                        <div class=""hero__img animate__animated animate__bounceIn"">
                            <img src=""images/herohomeslider.webp""");
            BeginWriteAttribute("alt", " alt=\"", 599, "\"", 605, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""col-xl-5 col-lg-5 col-md-5 col-sm-8"">
                        <div class=""hero__caption"">
                            <span class=""animate__animated animate__fadeInRight"">60% Discount</span>
                            <h1 class=""animate__animated animate__fadeInRight"">Winter <br> Collection</h1>
                            <p class=""animate__animated animate__fadeInRight"">Best Cloth Collection By 2020!</p>

                            <div class=""hero__btn animate__animated animate__fadeInRight"">
                                <a href=""industries.html"" class=""btn custom-btn hero-btn"">Shop Now</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""single-slider slider-height"" style=""background-image: url(&quot;images/h1_hero.jpg.webp&quot;);"">
            <div class=""container"">
   ");
            WriteLiteral(@"             <div class=""row d-flex align-items-center justify-content-between"">
                    <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6 d-none d-md-block"">
                        <div class=""hero__img animate__animated animate__bounceIn"">
                            <img src=""images/herohomeslider.webp "" alt="" "">
                        </div>
                    </div>
                    <div class=""col-xl-5 col-lg-5 col-md-5 col-sm-8 "">
                        <div class=""hero__caption "">
                            <span class=""animate__animated animate__fadeInRight"">60% Discount</span>
                            <h1 class=""animate__animated animate__fadeInRight"">Winter <br> Collection</h1>
                            <p class=""animate__animated animate__fadeInRight"">Best Cloth Collection By 2020!</p>


                            <div class=""hero__btn animate__animated animate__fadeInRight"">
                                <a href=""industries.html "" class=""btn custom-btn hero");
            WriteLiteral(@"-btn "">Shop Now</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


        </div>


    </section>
    <!-- Hero area ends -->
    <!-- Category area starts -->
    <section id=""category-area"" class=""section-padding30"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""section-title text-center mb-85"">
                        <h2>
                            Shop by Category
                        </h2>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-xl-4 col-lg-6"">
                    <div class=""single-category mb-30"">
                        <div class=""category-img"">
                            <img src=""images/homecategory1.webp"" alt=""homecategoryimg"">
                            <div class=""category-caption"">
    ");
            WriteLiteral(@"                            <h2>Owmen`s</h2>
                                <span class=""best""><a href=""#"">Best New Deals</a></span>
                                <span class=""collection"">New Collection</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-4 col-lg-6"">
                    <div class=""single-category mb-30"">
                        <div class=""category-img"">
                            <img src=""images/homecategory2.webp"" alt=""homecategoryimg"">
                            <div class=""category-caption text-center"">
                                <span class=""collection"">Discount!</span>
                                <h2>Winter Cloth</h2>
                                <p>New Collection</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-4 col-lg-6"">
               ");
            WriteLiteral(@"     <div class=""single-category mb-30"">
                        <div class=""category-img"">
                            <img src=""images/homecategory3.webp"" alt=""homecategoryimg"">
                            <div class=""category-caption"">
                                <h2>Man`s Cloth</h2>
                                <span class=""best""><a href=""#"">Best New Deals</a></span>
                                <span class=""collection"">New Collection</span>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>
    <!-- Category area ends  -->

    <!-- Latest products area starts -->
    <section id=""latest-products"" class=""padding-bottom"">
        <div class=""container"">
            <div class=""row product-btn d-flex justify-content-end align-items-end"">
                <div class=""col-xl-4 col-lg-5 col-md-5"">
                    <div class=""section-title mb-30"">
              ");
            WriteLiteral(@"          <h2>
                            Latest Products
                        </h2>
                    </div>

                </div>
                <div class=""col-xl-8 col-lg-7 col-md-7"">
                    <ul id=""filter-group"" class=""filter-group float-end"">
                        <li class=""filter-item""><a class=""filter-item-btn active"" onclick=""filterSelection('all')"" href=""javascript:void(0);"">All</a></li>
                        <li class=""filter-item""><a class=""filter-item-btn"" onclick=""filterSelection('new')"" href=""javascript:void(0);"">New</a></li>
                        <li class=""filter-item""><a class=""filter-item-btn"" onclick=""filterSelection('featured')"" href=""javascript:void(0);"">Featured</a> </li>
                        <li class=""filter-item""><a class=""filter-item-btn"" onclick=""filterSelection('offer')"" href=""javascript:void(0);"">Offer</a></li>
                    </ul>
                </div>
            </div>
            <div class=""row"">


                <div ");
            WriteLiteral("class=\"col-xl-4 col-lg-4 col-md-6 filterDiv new offer\">\r\n\r\n                    <div class=\"single-product mb-60\">\r\n                        <div class=\"product-img\">\r\n                            <img src=\"images/filter1.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 6974, "\"", 6980, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 8302, "\"", 8308, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 9497, "\"", 9503, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 10839, "\"", 10845, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 12030, "\"", 12036, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 13227, "\"", 13233, 0);
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
            WriteLiteral(@"  </div>
                    </div>
                </div>



            </div>
        </div>

    </section>
    <!-- Latest products area ends -->
    <!-- Best product area starts -->
    <section class=""best-product-area plr-60"">
        <div class=""product-wrapper bg-height"" style=""background-image:url(images/bestproduct.webp)"">
            <div class=""container position-relative"">
                <div class=""row justify-content-between align-items-end"">
                    <div class=""product-man position-absolute  d-none d-lg-block"">
                        <img src=""images/bestproduct2.webp""");
            BeginWriteAttribute("alt", " alt=\"", 14883, "\"", 14889, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""col-xl-2 col-lg-2 col-md-2 d-none d-lg-block"">
                        <div class=""vertical-text"">
                            <span>Manz</span>
                        </div>
                    </div>
                    <div class=""col-xl-8 col-lg-8"">
                        <div class=""best-product-caption"">
                            <h2>Find The Best Product<br> from Our Shop</h2>
                            <p>Designers who are interesten creating state ofthe.</p>
                            <a href=""#"" class=""black-btn"">Shop Now</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""shape animate__animated animate__bounce d-none d-md-block"">
            <img src=""images/bestproduct3.webp"">
        </div>
    </section>
    <!-- Best product area ends -->
    <!-- Best collection area starts -->
    <section class=""best-collection-are");
            WriteLiteral(@"a section-padding2"">
        <div class=""container"">
            <div class=""row d-flex justify-content-between align-items-end"">

                <div class=""col-xl-4 col-lg-4 col-md-6"">
                    <div class=""best-left-cap"">
                        <h2>Best Collection of This Month</h2>
                        <p>Designers who are interesten crea.</p>
                        <a href=""#"" class=""btn shop1-btn"">Shop Now</a>
                    </div>
                    <div class=""best-left-img mb-30 d-none d-sm-block"">
                        <img src=""images/bestcollectionarea1.webp""");
            BeginWriteAttribute("alt", " alt=\"", 16526, "\"", 16532, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"col-xl-2 col-lg-2 d-none d-lg-block\">\r\n                    <div class=\"best-mid-img mb-30 \">\r\n                        <img src=\"images/bestcollectionarea2.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 16778, "\"", 16784, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>

                <div class=""col-xl-4 col-lg-6 col-md-6"">
                    <div class=""best-right-cap float-end"">
                        <div class=""best-single mb-30"">
                            <div class=""single-cap"">
                                <h4>Menz Winter<br> Jacket</h4>
                            </div>
                            <div class=""single-img"">
                                <img src=""images/bestcollectionarea3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 17300, "\"", 17306, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                    <div class=""best-right-cap float-end"">
                        <div class=""best-single mb-30"">
                            <div class=""single-cap active"">
                                <h4>Menz Winter<br>Jacket</h4>
                            </div>
                            <div class=""single-img"">
                                <img src=""images/bestcollectionarea4.webp""");
            BeginWriteAttribute("alt", " alt=\"", 17812, "\"", 17818, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                    <div class=""best-right-cap float-end"">
                        <div class=""best-single mb-30"">
                            <div class=""single-cap"">
                                <h4>Menz Winter<br> Jacket</h4>
                            </div>
                            <div class=""single-img"">
                                <img src=""images/bestcollectionarea5.webp""");
            BeginWriteAttribute("alt", " alt=\"", 18318, "\"", 18324, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Best collection area ends -->
    <!-- Latest subscribe area starts -->
    <section class=""latest-wrapper plr-60"">
        <div class=""latest-area latest-height d-flex align-items-center"" style=""background-image: url(&quot;images/latest1.webp&quot;);"">
            <div class=""container"">
                <div class=""row d-flex align-items-center"">
                    <div class=""col-xl-5 col-lg-5 col-md-6 offset-xl-1 offset-lg-1"">
                        <div class=""latest-caption"">
                            <h2>Get Our<br>Latest Offers News</h2>
                            <p>Subscribe news latter</p>
                        </div>
                    </div>
                    <div class=""col-xl-5 col-lg-5 col-md-6 "">
                        <div class=""latest-subscribe"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb743bdcb3a9767fa7db7c49324573c1d5683e5e25545", async() => {
                WriteLiteral("\r\n                                <input type=\"email\" placeholder=\"Your email here\">\r\n                                <button>Shop Now</button>\r\n                            ");
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
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"latest-man\">\r\n                <img src=\"images/latest2.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 19743, "\"", 19749, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
        </div>
    </section>
    <!-- Latest subscribe area ends -->
    <!-- Shop method area starts -->
    <section class=""shop-method-area section-padding30"">
        <div class=""container"">
            <div class=""row justify-content-between"">
                <div class=""col-xl-3 col-lg-3 col-md-6"">
                    <div class=""shopping-method mb-40"">
                        <i class=""fab fa-dropbox""></i>
                        <h6>Free Shipping Method</h6>
                        <p>aorem ixpsacdolor sit ameasecur adipisicing elitsf edasd.</p>
                    </div>
                </div>
                <div class=""col-xl-3 col-lg-3 col-md-6"">
                    <div class=""shopping-method mb-40"">
                        <i class=""fas fa-unlock""></i>
                        <h6>Secure Payment System</h6>
                        <p>aorem ixpsacdolor sit ameasecur adipisicing elitsf edasd.</p>
                    </div>
                </div>
        ");
            WriteLiteral(@"        <div class=""col-xl-3 col-lg-3 col-md-6"">
                    <div class=""shopping-method mb-40"">
                        <i class=""fas fa-sync""></i>
                        <h6>Secure Payment System</h6>
                        <p>aorem ixpsacdolor sit ameasecur adipisicing elitsf edasd.</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Shop method area ends -->

    <!-- Gallery area starts -->
    <section class=""gallery-wrapper plr-60"">
        <div class=""gallery-area"">
            <div class=""container-fluid"">
                <div class=""row justify-content-between"">
                    <div class=""gallery-image"">
                        <img src=""images/gallery.webp""");
            BeginWriteAttribute("alt", " alt=\"", 21543, "\"", 21549, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"gallery-image\">\r\n                        <img src=\"images/gallery1.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 21685, "\"", 21691, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"gallery-image\">\r\n                        <img src=\"images/gallery2.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 21827, "\"", 21833, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"gallery-image\">\r\n                        <img src=\"images/gallery3.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 21969, "\"", 21975, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"gallery-image\">\r\n                        <img src=\"images/gallery4.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 22111, "\"", 22117, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </section>\r\n    <!-- Gallery area ends -->");
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
