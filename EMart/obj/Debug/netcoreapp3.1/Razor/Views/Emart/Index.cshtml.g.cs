#pragma checksum "D:\ramya\ASP.net\EMart\Views\Emart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97b3838e365b13a9456cdd2fe58539dd1e9cc58c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emart_Index), @"mvc.1.0.view", @"/Views/Emart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97b3838e365b13a9456cdd2fe58539dd1e9cc58c", @"/Views/Emart/Index.cshtml")]
    public class Views_Emart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Emart.Model.Seller>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ramya\ASP.net\EMart\Views\Emart\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"    <table border=""1"">
        <tr>
            <td>     s_id     </td>
            <td>     s_name     </td>
            <td>     s_pwd    </td>
            <td>     s_emailid     </td>
            <td>     gstin    </td>
            <td>     bank_details     </td>
            <td>     postal_address   </td>
        </tr>
");
#nullable restore
#line 24 "D:\ramya\ASP.net\EMart\Views\Emart\Index.cshtml"
         foreach (var slr in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 27 "D:\ramya\ASP.net\EMart\Views\Emart\Index.cshtml"
           Write(slr.s_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "D:\ramya\ASP.net\EMart\Views\Emart\Index.cshtml"
           Write(slr.s_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "D:\ramya\ASP.net\EMart\Views\Emart\Index.cshtml"
           Write(slr.s_pwd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "D:\ramya\ASP.net\EMart\Views\Emart\Index.cshtml"
           Write(slr.s_emailid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "D:\ramya\ASP.net\EMart\Views\Emart\Index.cshtml"
           Write(slr.gstin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "D:\ramya\ASP.net\EMart\Views\Emart\Index.cshtml"
           Write(slr.bank_details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "D:\ramya\ASP.net\EMart\Views\Emart\Index.cshtml"
           Write(slr.postal_address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "D:\ramya\ASP.net\EMart\Views\Emart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Emart.Model.Seller>> Html { get; private set; }
    }
}
#pragma warning restore 1591