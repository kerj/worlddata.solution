#pragma checksum "/Users/Guest/Desktop/WorldData.Solution/WorldData/Views/Cities/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ad3e86a3bca12bcb4a688eff1ac43136f07ee2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cities_Index), @"mvc.1.0.view", @"/Views/Cities/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cities/Index.cshtml", typeof(AspNetCore.Views_Cities_Index))]
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
#line 1 "/Users/Guest/Desktop/WorldData.Solution/WorldData/Views/Cities/Index.cshtml"
using WorldData.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4ad3e86a3bca12bcb4a688eff1ac43136f07ee2", @"/Views/Cities/Index.cshtml")]
    public class Views_Cities_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(48, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4ad3e86a3bca12bcb4a688eff1ac43136f07ee24191", async() => {
                BeginContext(54, 162, true);
                WriteLiteral("\n  <meta charset=\'utf-8\'>\n  <title>To Do List</title>\n  <link rel=\'stylesheet\' href=\'https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\'>\n  ");
                EndContext();
                BeginContext(216, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4ad3e86a3bca12bcb4a688eff1ac43136f07ee24736", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(279, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(287, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(288, 447, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4ad3e86a3bca12bcb4a688eff1ac43136f07ee26913", async() => {
                BeginContext(294, 101, true);
                WriteLiteral("\n  <div class=\"container\">\n    <div class=\"jumbotron\">\n      <h1>To Do List</h1>\n    </div>\n    <ul>\n");
                EndContext();
#line 16 "/Users/Guest/Desktop/WorldData.Solution/WorldData/Views/Cities/Index.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
                BeginContext(428, 52, true);
                WriteLiteral("      <p>You have no cities in your to do list!</p>\n");
                EndContext();
#line 19 "/Users/Guest/Desktop/WorldData.Solution/WorldData/Views/Cities/Index.cshtml"
    }

#line default
#line hidden
                BeginContext(486, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 20 "/Users/Guest/Desktop/WorldData.Solution/WorldData/Views/Cities/Index.cshtml"
     if(Model.Count != 0)
    {

#line default
#line hidden
                BeginContext(518, 31, true);
                WriteLiteral("      <h4>Names of cities</h4>\n");
                EndContext();
#line 23 "/Users/Guest/Desktop/WorldData.Solution/WorldData/Views/Cities/Index.cshtml"
       foreach (City city in Model)
      {

#line default
#line hidden
                BeginContext(593, 18, true);
                WriteLiteral("        <li>Name: ");
                EndContext();
                BeginContext(612, 18, false);
#line 25 "/Users/Guest/Desktop/WorldData.Solution/WorldData/Views/Cities/Index.cshtml"
             Write(city.GetCityName());

#line default
#line hidden
                EndContext();
                BeginContext(630, 30, true);
                WriteLiteral("</li>\n        <li>Population: ");
                EndContext();
                BeginContext(661, 24, false);
#line 26 "/Users/Guest/Desktop/WorldData.Solution/WorldData/Views/Cities/Index.cshtml"
                   Write(city.GetCityPopulation());

#line default
#line hidden
                EndContext();
                BeginContext(685, 10, true);
                WriteLiteral("</li><br>\n");
                EndContext();
#line 27 "/Users/Guest/Desktop/WorldData.Solution/WorldData/Views/Cities/Index.cshtml"
      }

#line default
#line hidden
#line 27 "/Users/Guest/Desktop/WorldData.Solution/WorldData/Views/Cities/Index.cshtml"
       
    }

#line default
#line hidden
                BeginContext(709, 19, true);
                WriteLiteral("    </ul>\n  </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(735, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
