#pragma checksum "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc69db6455e18332e05554740105d752c5de7ae4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Details), @"mvc.1.0.view", @"/Views/Book/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Details.cshtml", typeof(AspNetCore.Views_Book_Details))]
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
#line 1 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\_ViewImports.cshtml"
using Honeypot;

#line default
#line hidden
#line 2 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\_ViewImports.cshtml"
using Honeypot.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc69db6455e18332e05554740105d752c5de7ae4", @"/Views/Book/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a63fdb27d9850a2afc4067b7359d8b6b14ded4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Honeypot.ViewModels.Book.BookDetailsViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 7, true);
            WriteLiteral("\r\n<h2>\"");
            EndContext();
            BeginContext(62, 11, false);
#line 3 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(73, 19, true);
            WriteLiteral("\"</h2>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(92, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc69db6455e18332e05554740105d752c5de7ae43673", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 5 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Author);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(124, 11, true);
            WriteLiteral("\r\n    <div>");
            EndContext();
            BeginContext(136, 12, false);
#line 6 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml"
    Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(148, 12, true);
            WriteLiteral("</div>\r\n    ");
            EndContext();
            BeginContext(160, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc69db6455e18332e05554740105d752c5de7ae45609", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 7 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Summary);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(193, 11, true);
            WriteLiteral("\r\n    <div>");
            EndContext();
            BeginContext(205, 13, false);
#line 8 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml"
    Write(Model.Summary);

#line default
#line hidden
            EndContext();
            BeginContext(218, 12, true);
            WriteLiteral("</div>\r\n    ");
            EndContext();
            BeginContext(230, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc69db6455e18332e05554740105d752c5de7ae47547", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 9 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Rating);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(262, 11, true);
            WriteLiteral("\r\n    <div>");
            EndContext();
            BeginContext(274, 12, false);
#line 10 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml"
    Write(Model.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(286, 12, true);
            WriteLiteral("</div>\r\n    ");
            EndContext();
            BeginContext(298, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc69db6455e18332e05554740105d752c5de7ae49484", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 11 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReviewsCount);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(336, 11, true);
            WriteLiteral("\r\n    <div>");
            EndContext();
            BeginContext(348, 18, false);
#line 12 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml"
    Write(Model.ReviewsCount);

#line default
#line hidden
            EndContext();
            BeginContext(366, 14, true);
            WriteLiteral("</div>\r\n\r\n    ");
            EndContext();
            BeginContext(380, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc69db6455e18332e05554740105d752c5de7ae411438", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 14 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Reviews);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(413, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml"
     foreach (var review  in @Model.Reviews)
    {

#line default
#line hidden
            BeginContext(468, 13, true);
            WriteLiteral("        <div>");
            EndContext();
            BeginContext(482, 21, false);
#line 17 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml"
        Write(review.Owner.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(503, 21, true);
            WriteLiteral("</div>\r\n        <div>");
            EndContext();
            BeginContext(525, 13, false);
#line 18 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml"
        Write(review.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(538, 21, true);
            WriteLiteral("</div>\r\n        <div>");
            EndContext();
            BeginContext(560, 11, false);
#line 19 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml"
        Write(review.Text);

#line default
#line hidden
            EndContext();
            BeginContext(571, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 20 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Book\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(586, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Honeypot.ViewModels.Book.BookDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591