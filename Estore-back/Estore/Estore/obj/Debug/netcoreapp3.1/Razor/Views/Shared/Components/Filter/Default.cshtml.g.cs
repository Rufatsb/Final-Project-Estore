#pragma checksum "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e930ba4a42dd5e35f779781425f49f46f5d105a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Filter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Filter/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e930ba4a42dd5e35f779781425f49f46f5d105a6", @"/Views/Shared/Components/Filter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d57143e42e39f1afd6f41845c7aac5eb46771252", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Filter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FilterCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n                <div class=\"col-xl-8 col-lg-7 col-md-7\">\r\n                    <ul id=\"filter-group\"");
            BeginWriteAttribute("class", " class=\"", 137, "\"", 187, 2);
            WriteAttributeValue("", 145, "filter-group", 145, 12, true);
#nullable restore
#line 4 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
WriteAttributeValue(" ", 157, Model.FirstOrDefault().Float, 158, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <li class=\"filter-item\"><a style=\"cursor:pointer\" class=\"filter-item-btn active\" onclick=\"filterSelection(\'all\')\">All</a></li>\r\n");
#nullable restore
#line 6 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
                         foreach (FilterCategory item in Model)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"filter-item\"><a style=\"cursor:pointer\" class=\"filter-item-btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 535, "\"", 578, 3);
            WriteAttributeValue("", 545, "filterSelection(\'", 545, 17, true);
#nullable restore
#line 8 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
WriteAttributeValue("", 562, item.Category, 562, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 576, "\')", 576, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
                                                                                                                                             Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 9 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       \r\n                     \r\n                    </ul>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 17 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
                 foreach (FilterCategory category in Model)
               {
                   foreach (FilterItems item in category.FilterItems)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 983, "\"", 1046, 5);
            WriteAttributeValue("", 991, "col-xl-4", 991, 8, true);
            WriteAttributeValue(" ", 999, "col-lg-4", 1000, 9, true);
            WriteAttributeValue(" ", 1008, "col-md-6", 1009, 9, true);
            WriteAttributeValue(" ", 1017, "filterDiv", 1018, 10, true);
#nullable restore
#line 21 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
WriteAttributeValue(" ", 1027, item.Filterselect, 1028, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    <div class=\"single-product mb-60\">\r\n                        <div class=\"product-img\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1191, "\"", 1220, 2);
            WriteAttributeValue("", 1197, "images/", 1197, 7, true);
#nullable restore
#line 25 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
WriteAttributeValue("", 1204, item.Productimg, 1204, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1221, "\"", 1227, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 26 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
                            if (@item.Filterselect=="new")
                          {

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <div class=\"new-product\">\r\n                                <span>New</span>\r\n                            </div>\r\n");
#nullable restore
#line 31 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <div class=""product-caption"">
                            <div class=""product-ratting"">
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star low-star""></i>
                                <i class=""far fa-star low-star""></i>
                            </div>
                            <h4><a href=""#"">");
#nullable restore
#line 41 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            <div class=\"price\">\r\n                                <ul>\r\n");
#nullable restore
#line 44 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
                                         if (item.IsDiscount)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                         <li>$");
#nullable restore
#line 46 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"discount\">$");
#nullable restore
#line 47 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
                                                             Write(item.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 48 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"

                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                         <li>$");
#nullable restore
#line 52 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 53 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
                                    

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   \r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 62 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Filter\Default.cshtml"
                   }
                 
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FilterCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
