#pragma checksum "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Author\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb59c36b0ae0d6e1c60b6ab6fa5d672bdf4d6e7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Details), @"mvc.1.0.view", @"/Views/Author/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Author/Details.cshtml", typeof(AspNetCore.Views_Author_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb59c36b0ae0d6e1c60b6ab6fa5d672bdf4d6e7c", @"/Views/Author/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a63fdb27d9850a2afc4067b7359d8b6b14ded4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Honeypot.ViewModels.Author.AuthorDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Quote", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(58, 17, true);
            WriteLiteral("\r\n<div>\r\n    <h1>");
            EndContext();
            BeginContext(76, 15, false);
#line 4 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Author\Details.cshtml"
   Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(91, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(93, 14, false);
#line 4 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Author\Details.cshtml"
                    Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(107, 50, true);
            WriteLiteral("</h1>\r\n</div>\r\n<div>\r\n    <h3>Biography</h3>\r\n    ");
            EndContext();
            BeginContext(158, 15, false);
#line 8 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Author\Details.cshtml"
Write(Model.Biography);

#line default
#line hidden
            EndContext();
            BeginContext(173, 37, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    <h3>Books</h3>\r\n");
            EndContext();
#line 12 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Author\Details.cshtml"
     foreach (var book in @Model.Books)
    {

#line default
#line hidden
            BeginContext(258, 27, true);
            WriteLiteral("        <div>\r\n            ");
            EndContext();
            BeginContext(285, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb59c36b0ae0d6e1c60b6ab6fa5d672bdf4d6e7c5751", async() => {
                BeginContext(356, 10, false);
#line 15 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Author\Details.cshtml"
                                                                             Write(book.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Author\Details.cshtml"
                                                            WriteLiteral(book.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(370, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 17 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Author\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(395, 36, true);
            WriteLiteral("</div>\r\n<div>\r\n    <h3>Quotes</h3>\r\n");
            EndContext();
#line 21 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Author\Details.cshtml"
     foreach (var quote in @Model.Quotes)
    {

#line default
#line hidden
            BeginContext(481, 27, true);
            WriteLiteral("        <div>\r\n            ");
            EndContext();
            BeginContext(508, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb59c36b0ae0d6e1c60b6ab6fa5d672bdf4d6e7c9205", async() => {
                BeginContext(581, 10, false);
#line 24 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Author\Details.cshtml"
                                                                               Write(quote.Text);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Author\Details.cshtml"
                                                             WriteLiteral(quote.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(595, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 26 "C:\Users\Lenovo Legion Y520\Documents\Visual Studio 2017\Projects\Honeypot\Honeypot\Views\Author\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(620, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Honeypot.ViewModels.Author.AuthorDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
