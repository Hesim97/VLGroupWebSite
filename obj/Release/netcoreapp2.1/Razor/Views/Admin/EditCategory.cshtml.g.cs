#pragma checksum "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4e16a9fc84b9eb5ae5b96b3409dd1faa871f512"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditCategory), @"mvc.1.0.view", @"/Views/Admin/EditCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/EditCategory.cshtml", typeof(AspNetCore.Views_Admin_EditCategory))]
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
#line 3 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\_ViewImports.cshtml"
using VLGroupWebSite.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e16a9fc84b9eb5ae5b96b3409dd1faa871f512", @"/Views/Admin/EditCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8de31192c079fde012f083ad576e896997ebe0b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminEditCategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
  
    ViewData["Title"] = "EditCategory";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(131, 100, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n       Kategoriyanı dəyiş\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(231, 594, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03d0c895f9414b08820832fa7790a588", async() => {
                BeginContext(330, 39, true);
                WriteLiteral("\r\n    <div class=\"card-body\">\r\n        ");
                EndContext();
                BeginContext(370, 23, false);
#line 14 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(393, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(403, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75b68e222ea3444ebea8920e468f34fa", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 15 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(463, 158, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"CategoryId\" value=\"CategoryId\" />\r\n        <div class=\"form-group\">\r\n            <label >Kategoriya</label>\r\n            ");
                EndContext();
                BeginContext(621, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a211011032494a6bb213dc287c70d3d4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 19 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(674, 144, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"card-footer\">\r\n        <button type=\"submit\" class=\"btn btn-success\">Yenilə</button>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(825, 91, true);
            WriteLiteral("\r\n<hr />\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        Products\r\n    </div>\r\n");
            EndContext();
#line 31 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
     if (Model.Products.Count()== 0)
    {

#line default
#line hidden
            BeginContext(961, 99, true);
            WriteLiteral("        <div class=\"alert alert-primary\" role=\"alert\">\r\n            Mehsul yoxdur\r\n        </div>\r\n");
            EndContext();
#line 36 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1084, 416, true);
            WriteLiteral(@"    <table class=""table table-bordered"">
        <thead class=""thead-dark"">
            <tr>
                <th>#</th>
                <th scope=""col"">Image</th>
                <th scope=""col"">ProductName</th>

                <th scope=""col"">Aktiv</th>
                <th scope=""col"">Ana Sehife</th>
                <th style=""width:135px""></th>

            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 53 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
             foreach (var item in Model.Products)
            {

#line default
#line hidden
            BeginContext(1566, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1613, 14, false);
#line 56 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
                   Write(item.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(1627, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1684, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c98b84f9d20c4207b946adc01b7044f9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1694, "~/img/", 1694, 6, true);
#line 58 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
AddHtmlAttributeValue("", 1700, item.Image, 1700, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1726, 53, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(1780, 16, false);
#line 60 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
                   Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1796, 35, true);
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n");
            EndContext();
#line 63 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
                         if (item.IsActiv)
                        {

#line default
#line hidden
            BeginContext(1902, 71, true);
            WriteLiteral("                            <span data-feather=\"check-square\"></span>\r\n");
            EndContext();
#line 66 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2057, 67, true);
            WriteLiteral("                            <span data-feather=\"x-square\"></span>\r\n");
            EndContext();
#line 70 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
                        }

#line default
#line hidden
            BeginContext(2151, 53, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 73 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
                         if (item.IsHome)
                        {

#line default
#line hidden
            BeginContext(2274, 71, true);
            WriteLiteral("                            <span data-feather=\"check-square\"></span>\r\n");
            EndContext();
#line 76 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2429, 67, true);
            WriteLiteral("                            <span data-feather=\"x-square\"></span>\r\n");
            EndContext();
#line 80 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
                        }

#line default
#line hidden
            BeginContext(2523, 97, true);
            WriteLiteral("                    </td>\r\n                    <td style=\"width:155px\">\r\n                        ");
            EndContext();
            BeginContext(2620, 434, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b356b0bbcbef46b79f2e20609de4ba79", async() => {
                BeginContext(2695, 84, true);
                WriteLiteral("\r\n                            <input id=\"CategoryID\" type=\"hidden\" name=\"CategoryId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2779, "\"", 2804, 1);
#line 84 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 2787, Model.CategoryId, 2787, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2805, 85, true);
                WriteLiteral(" />\r\n                            <input id=\"ProductId\" type=\"hidden\" name=\"ProductId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2890, "\"", 2913, 1);
#line 85 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 2898, item.ProductId, 2898, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2914, 133, true);
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"btn btn-danger btn sm delete\">Remove</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3054, 212, true);
            WriteLiteral("\r\n                        <button class=\"btn btn-success btn-sm\">Edit</button>\r\n                        <button class=\"btn btn-danger btn-sm \">Delete</button>\r\n                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 93 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"

            }

#line default
#line hidden
            BeginContext(3283, 34, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 98 "E:\VLGroup WebSiteSolution\VLGroupWebSite\Views\Admin\EditCategory.cshtml"
    }

#line default
#line hidden
            BeginContext(3324, 39, true);
            WriteLiteral("    <div class=\"card-footer\">\r\n        ");
            EndContext();
            BeginContext(3363, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a4f2cba1737403099e684ec12936af7", async() => {
                BeginContext(3437, 11, true);
                WriteLiteral("Yeni Məhsul");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3452, 28, true);
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3497, 968, true);
                WriteLiteral(@"
<script>
    $("".delete"").click(function (event) {
        event.preventDefault();
        var form = $(this).parent();
        var row = form.parent(""td"").parent(""tr"");
        var token = $('input[name=""_RequestVerificationToken""]', form).val();
        var data = { categoryId: $(""#CategoryId"", form).val(), productId: $(""#ProductId"", form).val() };
        var dataWithToken = $.extend(data, { '_RequestVerificationToken': token });
        //console.log(dataWithToken)

        $.ajax({
            url: form.attr(""action""),
            data: dataWithToken,
            type: ""POST"",
            beforeSend: function () {
                $(""#ajax-loader"").show();
            },
            complete: function () {
                $(""#ajax-loader"").hide();
            },
            success: function () {
                row.remove();
            },
            error: function () {

            }
        })
    });

</script>
 ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminEditCategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
