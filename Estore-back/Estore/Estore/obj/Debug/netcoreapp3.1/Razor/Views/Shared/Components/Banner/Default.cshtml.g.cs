#pragma checksum "C:\Users\Ali Aliyev\Desktop\Final project\Estore-back\Estore\Estore\Views\Shared\Components\Banner\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca5b5b1322d84f496d671f3d7569160511739ecf"
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
#nullable restore
#line 5 "C:\Users\Ali Aliyev\Desktop\Final project\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.BlogViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b5b1322d84f496d671f3d7569160511739ecf", @"/Views/Shared/Components/Banner/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5320407c15a027863ea3b5d01cdbad822486983c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Banner_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Banner>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <!-- Banner area starts -->\r\n    <section class=\"banner-area d-flex align-items-center\"");
            BeginWriteAttribute("style", " style=\"", 108, "\"", 171, 4);
            WriteAttributeValue("", 116, "background-image:", 116, 17, true);
            WriteAttributeValue(" ", 133, "url(&quot;~/images/", 134, 20, true);
#nullable restore
#line 4 "C:\Users\Ali Aliyev\Desktop\Final project\Estore-back\Estore\Estore\Views\Shared\Components\Banner\Default.cshtml"
WriteAttributeValue("", 153, Model.Img, 153, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 163, "&quot;);", 163, 8, true);
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
