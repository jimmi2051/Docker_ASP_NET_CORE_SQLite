#pragma checksum "/home/deftnt/QL_Sach/Views/Book/DeleteBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64618262a852f509e9f13ce164a0500f1f658b24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_DeleteBook), @"mvc.1.0.view", @"/Views/Book/DeleteBook.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/DeleteBook.cshtml", typeof(AspNetCore.Views_Book_DeleteBook))]
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
#line 1 "/home/deftnt/QL_Sach/Views/_ViewImports.cshtml"
using QL_Sach;

#line default
#line hidden
#line 2 "/home/deftnt/QL_Sach/Views/_ViewImports.cshtml"
using QL_Sach.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64618262a852f509e9f13ce164a0500f1f658b24", @"/Views/Book/DeleteBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c64d3f300bc488dbb353a64b96a1c43f7d048205", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_DeleteBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QL_Sach.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("CreateBook"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-lg-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/deftnt/QL_Sach/Views/Book/DeleteBook.cshtml"
  
    ViewData["Title"] = "View Books";

#line default
#line hidden
            BeginContext(70, 201, true);
            WriteLiteral("<h2>Delete Book</h2>\n<div class=\"container\">\n    <div class=\"row\">\n                <div class=\"col-lg-6\">\n                    <a href=\"/Book/ViewBook\" class=\"btn btn-default col-md-2\">Back to list</a>\n");
            EndContext();
#line 10 "/home/deftnt/QL_Sach/Views/Book/DeleteBook.cshtml"
                     using (Html.BeginForm())
                    {

#line default
#line hidden
            BeginContext(339, 94, true);
            WriteLiteral("                        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger col-md2\" />\n");
            EndContext();
#line 13 "/home/deftnt/QL_Sach/Views/Book/DeleteBook.cshtml"
                    }

#line default
#line hidden
            BeginContext(455, 68, true);
            WriteLiteral("                </div>\n        <div class=\"clearfix\"></div>\n        ");
            EndContext();
            BeginContext(523, 1444, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a24b8340a7c342c2b92fc3e62b63b037", async() => {
                BeginContext(580, 121, true);
                WriteLiteral("\n             <div class=\"form-group\">\n                <label>Id Book</label>\n                <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 701, "\"", 722, 1);
#line 19 "/home/deftnt/QL_Sach/Views/Book/DeleteBook.cshtml"
WriteAttributeValue("", 709, Model.IdBook, 709, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(723, 168, true);
                WriteLiteral(" name=\"IdBook\" type=\"text\">\n            </div>\n            <div class=\"form-group\">\n                <label>Name Book</label>\n                <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 891, "\"", 914, 1);
#line 23 "/home/deftnt/QL_Sach/Views/Book/DeleteBook.cshtml"
WriteAttributeValue("", 899, Model.NameBook, 899, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(915, 168, true);
                WriteLiteral(" name=\"NameBook\" type=\"text\">\n            </div>\n             <div class=\"form-group\">\n                <label>Author</label>\n                <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1083, "\"", 1104, 1);
#line 27 "/home/deftnt/QL_Sach/Views/Book/DeleteBook.cshtml"
WriteAttributeValue("", 1091, Model.Author, 1091, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1105, 169, true);
                WriteLiteral("  name=\"Author\" type=\"text\">\n            </div>\n            <div class=\"form-group\">\n                <label>Num Pages</label>\n                <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", "value=\"", 1274, "\"", 1295, 1);
#line 31 "/home/deftnt/QL_Sach/Views/Book/DeleteBook.cshtml"
WriteAttributeValue("", 1281, Model.NumPage, 1281, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1296, 170, true);
                WriteLiteral("  name=\"NumPage\" type=\"text\">\n            </div>\n            <div class=\"form-group\">\n                <label>Type Book</label>\n                <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1466, "\"", 1489, 1);
#line 35 "/home/deftnt/QL_Sach/Views/Book/DeleteBook.cshtml"
WriteAttributeValue("", 1474, Model.TypeBook, 1474, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1490, 182, true);
                WriteLiteral("  name=\"TypeBook\" type=\"text\">\n            </div>\n               <div class=\"form-group\">\n                <label>PublishingCompany</label>\n                <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1672, "\"", 1704, 1);
#line 39 "/home/deftnt/QL_Sach/Views/Book/DeleteBook.cshtml"
WriteAttributeValue("", 1680, Model.PublishingCompany, 1680, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1705, 179, true);
                WriteLiteral("  name=\"PublishingCompany\" type=\"text\">\n            </div>\n               <div class=\"form-group\">\n                <label>Price</label>\n                <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1884, "\"", 1904, 1);
#line 43 "/home/deftnt/QL_Sach/Views/Book/DeleteBook.cshtml"
WriteAttributeValue("", 1892, Model.Price, 1892, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1905, 55, true);
                WriteLiteral("  name=\"Price\" type=\"text\">\n            </div>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1967, 18, true);
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QL_Sach.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591