#pragma checksum "C:\Users\Harun ASLAN\source\repos\FinalProject\FinalProject.MvcWebUI\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a1590a3b3356786df338a80e18b0f1d97fc6bf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1590a3b3356786df338a80e18b0f1d97fc6bf0", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"731377cd3b9183cf286bff047b339c2013937084", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProject.MvcWebUI.Models.ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::FinalProject.MvcWebUI.TagHelpers.PagingTagHelper __FinalProject_MvcWebUI_TagHelpers_PagingTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Harun ASLAN\source\repos\FinalProject\FinalProject.MvcWebUI\Views\Product\Index.cshtml"
  
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(109, 389, true);
            WriteLiteral(@"


<div>
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col""></th>
                <th scope=""col"">Product Name</th>
                <th scope=""col"">Unit Price</th>
                <th scope=""col"">Unit In Stock</th>
                <th scope=""col"">Add To Cart</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 22 "C:\Users\Harun ASLAN\source\repos\FinalProject\FinalProject.MvcWebUI\Views\Product\Index.cshtml"
              int counter = 0; 

#line default
#line hidden
            BeginContext(532, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 23 "C:\Users\Harun ASLAN\source\repos\FinalProject\FinalProject.MvcWebUI\Views\Product\Index.cshtml"
             foreach (var product in Model.Products)
            {
                counter++;

#line default
#line hidden
            BeginContext(629, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(680, 7, false);
#line 27 "C:\Users\Harun ASLAN\source\repos\FinalProject\FinalProject.MvcWebUI\Views\Product\Index.cshtml"
                           Write(counter);

#line default
#line hidden
            EndContext();
            BeginContext(687, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(715, 19, false);
#line 28 "C:\Users\Harun ASLAN\source\repos\FinalProject\FinalProject.MvcWebUI\Views\Product\Index.cshtml"
               Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(734, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(762, 17, false);
#line 29 "C:\Users\Harun ASLAN\source\repos\FinalProject\FinalProject.MvcWebUI\Views\Product\Index.cshtml"
               Write(product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(779, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(807, 19, false);
#line 30 "C:\Users\Harun ASLAN\source\repos\FinalProject\FinalProject.MvcWebUI\Views\Product\Index.cshtml"
               Write(product.UnitInStock);

#line default
#line hidden
            EndContext();
            BeginContext(826, 28, true);
            WriteLiteral("</td>\r\n                <td> ");
            EndContext();
            BeginContext(854, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7888bcb871984f96a982c9e84a0ffeca", async() => {
                BeginContext(967, 11, true);
                WriteLiteral("Add To Cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\Harun ASLAN\source\repos\FinalProject\FinalProject.MvcWebUI\Views\Product\Index.cshtml"
                                                                                                             WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(982, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 33 "C:\Users\Harun ASLAN\source\repos\FinalProject\FinalProject.MvcWebUI\Views\Product\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1023, 54, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n\r\n  \r\n\r\n\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(1077, 290, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("product-list-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4db9cf34cf384c438a8c303cf503fe4e", async() => {
                BeginContext(1338, 8, true);
                WriteLiteral("        ");
                EndContext();
            }
            );
            __FinalProject_MvcWebUI_TagHelpers_PagingTagHelper = CreateTagHelper<global::FinalProject.MvcWebUI.TagHelpers.PagingTagHelper>();
            __tagHelperExecutionContext.Add(__FinalProject_MvcWebUI_TagHelpers_PagingTagHelper);
#line 45 "C:\Users\Harun ASLAN\source\repos\FinalProject\FinalProject.MvcWebUI\Views\Product\Index.cshtml"
__FinalProject_MvcWebUI_TagHelpers_PagingTagHelper.CurrentCategory = Model.CurrentCategory;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-category", __FinalProject_MvcWebUI_TagHelpers_PagingTagHelper.CurrentCategory, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 46 "C:\Users\Harun ASLAN\source\repos\FinalProject\FinalProject.MvcWebUI\Views\Product\Index.cshtml"
__FinalProject_MvcWebUI_TagHelpers_PagingTagHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __FinalProject_MvcWebUI_TagHelpers_PagingTagHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 47 "C:\Users\Harun ASLAN\source\repos\FinalProject\FinalProject.MvcWebUI\Views\Product\Index.cshtml"
__FinalProject_MvcWebUI_TagHelpers_PagingTagHelper.PageCount = Model.PageCount;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __FinalProject_MvcWebUI_TagHelpers_PagingTagHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "C:\Users\Harun ASLAN\source\repos\FinalProject\FinalProject.MvcWebUI\Views\Product\Index.cshtml"
__FinalProject_MvcWebUI_TagHelpers_PagingTagHelper.PageSize = Model.PageSize;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __FinalProject_MvcWebUI_TagHelpers_PagingTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1367, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProject.MvcWebUI.Models.ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
