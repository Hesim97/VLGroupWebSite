#pragma checksum "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f6634b968c4d6f5960fc3890cfbd06ab0ccc1f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/List.cshtml", typeof(AspNetCore.Views_Product_List))]
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
#line 1 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\_ViewImports.cshtml"
using VLGroupWebSite;

#line default
#line hidden
#line 2 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\_ViewImports.cshtml"
using VLGroupWebSite.Models;

#line default
#line hidden
#line 1 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Product\List.cshtml"
using VLGroupWebSite.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f6634b968c4d6f5960fc3890cfbd06ab0ccc1f4", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8de31192c079fde012f083ad576e896997ebe0b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Product\List.cshtml"
  
    ViewData["Title"] = "Mehsul List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(242, 96, true);
            WriteLiteral("<div class=\"products-catagories-area clearfix\">\r\n    <div class=\"amado-pro-catagory clearfix\">\r\n");
            EndContext();
#line 16 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Product\List.cshtml"
         foreach (var product in Model.Products)
        {

#line default
#line hidden
            BeginContext(398, 37, false);
#line 17 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Product\List.cshtml"
    Write(Html.Partial("_ProductItem", product));

#line default
#line hidden
            EndContext();
#line 17 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Product\List.cshtml"
                                               }

#line default
#line hidden
            BeginContext(438, 26, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
