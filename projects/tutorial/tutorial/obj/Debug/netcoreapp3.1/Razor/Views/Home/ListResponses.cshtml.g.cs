#pragma checksum "C:\Users\Gille\Desktop\school\2deJaar\Web development\projects\tutorial\tutorial\Views\Home\ListResponses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a8618538b6d4362fd6729f1e4ed7766de39066e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListResponses), @"mvc.1.0.view", @"/Views/Home/ListResponses.cshtml")]
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
#line 1 "C:\Users\Gille\Desktop\school\2deJaar\Web development\projects\tutorial\tutorial\Views\_ViewImports.cshtml"
using tutorial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gille\Desktop\school\2deJaar\Web development\projects\tutorial\tutorial\Views\_ViewImports.cshtml"
using tutorial.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a8618538b6d4362fd6729f1e4ed7766de39066e", @"/Views/Home/ListResponses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdbf6704702fe03c5f5d2b0f0afb1049aed94e47", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListResponses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<tutorial.Models.GeustResponse>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Gille\Desktop\school\2deJaar\Web development\projects\tutorial\tutorial\Views\Home\ListResponses.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a8618538b6d4362fd6729f1e4ed7766de39066e3646", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ListResponses</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a8618538b6d4362fd6729f1e4ed7766de39066e4713", async() => {
                WriteLiteral("\r\n    <div>\r\n        <table>\r\n            <thead>\r\n                <tr>\r\n                    <th>name</th>\r\n                    <th>email</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 24 "C:\Users\Gille\Desktop\school\2deJaar\Web development\projects\tutorial\tutorial\Views\Home\ListResponses.cshtml"
                 foreach (tutorial.Models.GeustResponse r in Model) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <th>");
#nullable restore
#line 26 "C:\Users\Gille\Desktop\school\2deJaar\Web development\projects\tutorial\tutorial\Views\Home\ListResponses.cshtml"
                       Write(r.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 27 "C:\Users\Gille\Desktop\school\2deJaar\Web development\projects\tutorial\tutorial\Views\Home\ListResponses.cshtml"
                       Write(r.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Gille\Desktop\school\2deJaar\Web development\projects\tutorial\tutorial\Views\Home\ListResponses.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<tutorial.Models.GeustResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591