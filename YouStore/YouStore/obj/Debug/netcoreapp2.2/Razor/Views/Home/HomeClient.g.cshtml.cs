#pragma checksum "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Home\HomeClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f11744c658bd4803ae5d37c10f9470a1ef4843b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HomeClient), @"mvc.1.0.view", @"/Views/Home/HomeClient.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/HomeClient.cshtml", typeof(AspNetCore.Views_Home_HomeClient))]
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
#line 1 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\_ViewImports.cshtml"
using YouStore;

#line default
#line hidden
#line 2 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\_ViewImports.cshtml"
using YouStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f11744c658bd4803ae5d37c10f9470a1ef4843b", @"/Views/Home/HomeClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d9113c5516be5079b85800b0929919b1f970f4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HomeClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Denim Jeans"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Home\HomeClient.cshtml"
  
    ViewData["Title"] = "HomeClient";
    Layout = "~/Views/Shared/_LayoutClient.cshtml";

#line default
#line hidden
            BeginContext(137, 608, true);
            WriteLiteral(@"
<
<style>
    .card {
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
        max-width: 300px;
        margin: auto;
        text-align: center;
        font-family: arial;
    }

    .price {
        color: grey;
        font-size: 22px;
    }

    .card button {
        border: none;
        outline: 0;
        padding: 12px;
        color: white;
        background-color: #000;
        text-align: center;
        cursor: pointer;
        width: 100%;
        font-size: 18px;
    }

        .card button:hover {
            opacity: 0.7;
        }
</style>



");
            EndContext();
#line 42 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Home\HomeClient.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(778, 24, true);
            WriteLiteral("<div class=\"card\">\r\n    ");
            EndContext();
            BeginContext(802, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f11744c658bd4803ae5d37c10f9470a1ef4843b5087", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 812, "~/images/", 812, 9, true);
#line 45 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Home\HomeClient.cshtml"
AddHtmlAttributeValue("", 821, Html.DisplayFor(modelItem => item.Productimagelink), 821, 52, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(912, 10, true);
            WriteLiteral("\r\n    <h1>");
            EndContext();
            BeginContext(923, 46, false);
#line 46 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Home\HomeClient.cshtml"
   Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(969, 29, true);
            WriteLiteral("</h1>\r\n    <p class=\"price\">$");
            EndContext();
            BeginContext(999, 47, false);
#line 47 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Home\HomeClient.cshtml"
                 Write(Html.DisplayFor(modelItem => item.ProductPrijs));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(1060, 53, false);
#line 48 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Home\HomeClient.cshtml"
  Write(Html.DisplayFor(modelItem => item.ProductDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(1634, 73, true);
            WriteLiteral("    <button type=\"button\" class=\"btn btn-danger glyphicon glyphicon-plus\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1707, "\"", 1796, 3);
            WriteAttributeValue("", 1717, "location.href=\'/ShoppingBasket/AddProductsToShoppingBasket/id?=", 1717, 63, true);
#line 55 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Home\HomeClient.cshtml"
WriteAttributeValue("", 1780, item.ProductId, 1780, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1795, "\'", 1795, 1, true);
            EndWriteAttribute();
            BeginContext(1797, 20, true);
            WriteLiteral("></button>\r\n</div>\r\n");
            EndContext();
#line 57 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Home\HomeClient.cshtml"
}

#line default
#line hidden
            BeginContext(1820, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
