#pragma checksum "C:\Users\Gille\Desktop\school\2deJaar\Web development\projects\PeopleManager\PeopleManager\Views\People\PersonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c19221fab0fa02fc13215387d51af9c41c3a2c78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_PersonPartial), @"mvc.1.0.view", @"/Views/People/PersonPartial.cshtml")]
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
#line 1 "C:\Users\Gille\Desktop\school\2deJaar\Web development\projects\PeopleManager\PeopleManager\Views\_ViewImports.cshtml"
using PeopleManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gille\Desktop\school\2deJaar\Web development\projects\PeopleManager\PeopleManager\Views\_ViewImports.cshtml"
using PeopleManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c19221fab0fa02fc13215387d51af9c41c3a2c78", @"/Views/People/PersonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa94ac7364544dbcae203b92edaace12b08e03a3", @"/Views/_ViewImports.cshtml")]
    public class Views_People_PersonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PeopleManager.Models.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<tr>\r\n    <td>");
#nullable restore
#line 4 "C:\Users\Gille\Desktop\school\2deJaar\Web development\projects\PeopleManager\PeopleManager\Views\People\PersonPartial.cshtml"
   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 5 "C:\Users\Gille\Desktop\school\2deJaar\Web development\projects\PeopleManager\PeopleManager\Views\People\PersonPartial.cshtml"
   Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PeopleManager.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591