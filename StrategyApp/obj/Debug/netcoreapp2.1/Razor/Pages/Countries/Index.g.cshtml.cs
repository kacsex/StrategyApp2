#pragma checksum "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bedffb417d7a36bdc161baa6ee4c112acf309c89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StrategyApp.Pages.Countries.Pages_Countries_Index), @"mvc.1.0.razor-page", @"/Pages/Countries/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Countries/Index.cshtml", typeof(StrategyApp.Pages.Countries.Pages_Countries_Index), null)]
namespace StrategyApp.Pages.Countries
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\_ViewImports.cshtml"
using StrategyApp;

#line default
#line hidden
#line 3 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\_ViewImports.cshtml"
using StrategyApp.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bedffb417d7a36bdc161baa6ee4c112acf309c89", @"/Pages/Countries/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"774a63971d71efd83b029db64506f3884016195e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Countries_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(126, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3faa680f636042d7a7b2edd58f39c3c3", async() => {
                BeginContext(147, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(161, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(254, 49, false);
#line 17 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Units[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(303, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(359, 56, false);
#line 20 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Units[0].AttackPower));

#line default
#line hidden
            EndContext();
            BeginContext(415, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(471, 57, false);
#line 23 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Units[0].DefensePower));

#line default
#line hidden
            EndContext();
            BeginContext(528, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(584, 50, false);
#line 26 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Units[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(634, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(690, 51, false);
#line 29 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Units[0].Salary));

#line default
#line hidden
            EndContext();
            BeginContext(741, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(797, 62, false);
#line 32 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Units[0].PotatoRequirement));

#line default
#line hidden
            EndContext();
            BeginContext(859, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml"
 foreach (var item in Model.Units) {

#line default
#line hidden
            BeginContext(983, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1032, 39, false);
#line 41 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1127, 46, false);
#line 44 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AttackPower));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1229, 47, false);
#line 47 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DefensePower));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1332, 40, false);
#line 50 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1372, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1428, 41, false);
#line 53 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1525, 52, false);
#line 56 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PotatoRequirement));

#line default
#line hidden
            EndContext();
            BeginContext(1577, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 62 "C:\Users\maschek.zsolt\source\repos\StrategyApp\StrategyApp\Pages\Countries\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1655, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StrategyApp.Pages.Countries.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StrategyApp.Pages.Countries.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StrategyApp.Pages.Countries.IndexModel>)PageContext?.ViewData;
        public StrategyApp.Pages.Countries.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
