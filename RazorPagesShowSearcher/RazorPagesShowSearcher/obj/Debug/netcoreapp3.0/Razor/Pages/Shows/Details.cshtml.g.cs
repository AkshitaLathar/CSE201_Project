#pragma checksum "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a22a481c8154020dd412c02aafc7afc14a938b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesShowSearcher.Pages.Shows.Pages_Shows_Details), @"mvc.1.0.razor-page", @"/Pages/Shows/Details.cshtml")]
namespace RazorPagesShowSearcher.Pages.Shows
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
#line 1 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\_ViewImports.cshtml"
using RazorPagesShowSearcher;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\_ViewImports.cshtml"
using RazorPagesShowSearcher.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a22a481c8154020dd412c02aafc7afc14a938b2", @"/Pages/Shows/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d080d60d30924cf71539c604c2bbfae86fcdd4c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shows_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Show</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Show.ShowName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayFor(model => model.Show.ShowName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Show.ShowDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayFor(model => model.Show.ShowDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Show.ShowRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayFor(model => model.Show.ShowRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Show.NumOfSeasons));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayFor(model => model.Show.NumOfSeasons));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Show.YearShowBegan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayFor(model => model.Show.YearShowBegan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Show.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayFor(model => model.Show.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Show.OriginalNetwork));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayFor(model => model.Show.OriginalNetwork));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Show.numOfLike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayFor(model => model.Show.numOfLike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Show.numOfDislike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
       Write(Html.DisplayFor(model => model.Show.numOfDislike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a22a481c8154020dd412c02aafc7afc14a938b211066", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\LOL\Documents\GitHub\CSE201_Project\RazorPagesShowSearcher\RazorPagesShowSearcher\Pages\Shows\Details.cshtml"
                           WriteLiteral(Model.Show.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a22a481c8154020dd412c02aafc7afc14a938b213250", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesShowSearcher.Pages.Shows.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesShowSearcher.Pages.Shows.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesShowSearcher.Pages.Shows.DetailsModel>)PageContext?.ViewData;
        public RazorPagesShowSearcher.Pages.Shows.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
