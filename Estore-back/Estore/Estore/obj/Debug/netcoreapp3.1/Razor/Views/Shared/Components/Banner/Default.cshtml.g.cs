#pragma checksum "C:\Users\Ali Aliyev\Desktop\Final project\Estore-back\Estore\Estore\Views\Shared\Components\Banner\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3c173920fb171eae409afe2fa0748c51b6c586c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Banner_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Banner/Default.cshtml")]
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
#line 2 "C:\Users\Ali Aliyev\Desktop\Final project\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ali Aliyev\Desktop\Final project\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.AboutViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ali Aliyev\Desktop\Final project\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.ProductViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3c173920fb171eae409afe2fa0748c51b6c586c", @"/Views/Shared/Components/Banner/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea771ba66532a6b95f34b40883d5a0982c970837", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Banner_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Banner>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <!-- Banner area starts -->\r\n    <section class=\"banner-area d-flex align-items-center\"");
            BeginWriteAttribute("style", " style=\"", 108, "\"", 169, 4);
            WriteAttributeValue("", 116, "background-image:", 116, 17, true);
            WriteAttributeValue(" ", 133, "url(&quot;images/", 134, 18, true);
#nullable restore
#line 4 "C:\Users\Ali Aliyev\Desktop\Final project\Estore-back\Estore\Estore\Views\Shared\Components\Banner\Default.cshtml"
WriteAttributeValue("", 151, Model.Img, 151, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 161, "&quot;);", 161, 8, true);
            EndWriteAttribute();
            WriteLiteral(" )>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-xl-12\">\r\n                    <div class=\"text-class text-center\">\r\n                     \r\n                        <h2> ");
#nullable restore
#line 10 "C:\Users\Ali Aliyev\Desktop\Final project\Estore-back\Estore\Estore\Views\Shared\Components\Banner\Default.cshtml"
                        Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                  \r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <!-- Banner area ends -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Banner> Html { get; private set; }
    }
}
#pragma warning restore 1591
