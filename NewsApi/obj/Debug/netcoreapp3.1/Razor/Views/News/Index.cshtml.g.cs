#pragma checksum "C:\Users\4A Labs\source\repos\NewsApi\NewsApi\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2d851eadc39de10f2eedc123c8e4842ac5a1660"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\4A Labs\source\repos\NewsApi\NewsApi\Views\News\Index.cshtml"
using NewsApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d851eadc39de10f2eedc123c8e4842ac5a1660", @"/Views/News/Index.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsResponseModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2d851eadc39de10f2eedc123c8e4842ac5a16602744", async() => {
                WriteLiteral("\r\n\r\n    <h2>Text input fields</h2>\r\n\r\n    <form>\r\n");
#nullable restore
#line 11 "C:\Users\4A Labs\source\repos\NewsApi\NewsApi\Views\News\Index.cshtml"
         foreach (Article item in Model.Articles)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label>Author : </label>\r\n            <br>\r\n            <label>");
#nullable restore
#line 15 "C:\Users\4A Labs\source\repos\NewsApi\NewsApi\Views\News\Index.cshtml"
              Write(item.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <hr />\r\n");
                WriteLiteral("            <label>Title : </label>\r\n            <br>\r\n            <label>");
#nullable restore
#line 20 "C:\Users\4A Labs\source\repos\NewsApi\NewsApi\Views\News\Index.cshtml"
              Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <hr />\r\n");
                WriteLiteral("            <label>Url : </label>\r\n            <br>\r\n            <label>");
#nullable restore
#line 25 "C:\Users\4A Labs\source\repos\NewsApi\NewsApi\Views\News\Index.cshtml"
              Write(item.Url);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <hr />\r\n");
                WriteLiteral("            <label>Source : </label>\r\n            <br>\r\n            <label>");
#nullable restore
#line 30 "C:\Users\4A Labs\source\repos\NewsApi\NewsApi\Views\News\Index.cshtml"
              Write(item.Source.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <hr>\r\n");
                WriteLiteral("            <br />\r\n            <label>*****************************************************************************************</label>\r\n            <br />\r\n");
#nullable restore
#line 36 "C:\Users\4A Labs\source\repos\NewsApi\NewsApi\Views\News\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </form>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
