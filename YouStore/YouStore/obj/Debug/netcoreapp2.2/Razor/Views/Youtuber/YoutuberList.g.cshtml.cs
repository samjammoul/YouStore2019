#pragma checksum "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Youtuber\YoutuberList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2780b6bec3cfd433d147881adfc89d1b4d5f4e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Youtuber_YoutuberList), @"mvc.1.0.view", @"/Views/Youtuber/YoutuberList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Youtuber/YoutuberList.cshtml", typeof(AspNetCore.Views_Youtuber_YoutuberList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2780b6bec3cfd433d147881adfc89d1b4d5f4e8", @"/Views/Youtuber/YoutuberList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d9113c5516be5079b85800b0929919b1f970f4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Youtuber_YoutuberList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Youtuber>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Denim Jeans"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Youtuber\YoutuberList.cshtml"
  
    ViewData["Title"] = "YoutuberList";
    Layout = "~/Views/Shared/_LayoutClient.cshtml";

#line default
#line hidden
            BeginContext(140, 36, true);
            WriteLiteral("\r\n<h2>YoutuberList</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(176, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2780b6bec3cfd433d147881adfc89d1b4d5f4e84732", async() => {
                BeginContext(199, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(213, 607, true);
            WriteLiteral(@"
</p>
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
#line 44 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Youtuber\YoutuberList.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(853, 17, true);
            WriteLiteral("<div class=\"card\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 870, "\"", 955, 3);
            WriteAttributeValue("", 880, "location.href=\'/Youtuber/ShowYoutuberProducts/YoutuberId?=", 880, 58, true);
#line 46 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Youtuber\YoutuberList.cshtml"
WriteAttributeValue("", 938, item.YoutuberId, 938, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 954, "\'", 954, 1, true);
            EndWriteAttribute();
            BeginContext(956, 7, true);
            WriteLiteral(">\r\n    ");
            EndContext();
            BeginContext(963, 193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d2780b6bec3cfd433d147881adfc89d1b4d5f4e87568", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 973, "~/images/", 973, 9, true);
#line 47 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Youtuber\YoutuberList.cshtml"
AddHtmlAttributeValue("", 982, Html.DisplayFor(modelItem => item.YoutuberImage), 982, 49, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1079, "location.href=\'/Youtuber/ShowYoutuberProducts/YoutuberId?=", 1079, 58, true);
#line 47 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Youtuber\YoutuberList.cshtml"
AddHtmlAttributeValue("", 1137, item.YoutuberId, 1137, 16, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1153, "\'", 1153, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1156, 10, true);
            WriteLiteral("\r\n    <h1>");
            EndContext();
            BeginContext(1167, 47, false);
#line 48 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Youtuber\YoutuberList.cshtml"
   Write(Html.DisplayFor(modelItem => item.YoutuberName));

#line default
#line hidden
            EndContext();
            BeginContext(1214, 13, true);
            WriteLiteral("</h1>\r\n    \r\n");
            EndContext();
            BeginContext(1375, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 52 "C:\Users\Sam\Desktop\YouStore\YouStore\Views\Youtuber\YoutuberList.cshtml"

}

#line default
#line hidden
            BeginContext(1388, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Youtuber>> Html { get; private set; }
    }
}
#pragma warning restore 1591