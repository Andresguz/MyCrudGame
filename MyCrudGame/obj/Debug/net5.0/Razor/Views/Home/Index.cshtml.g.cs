#pragma checksum "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3132eb392dbe00de0155a36000057cbfa97e6139"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\_ViewImports.cshtml"
using MyCrudGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\_ViewImports.cshtml"
using MyCrudGame.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3132eb392dbe00de0155a36000057cbfa97e6139", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b60fd15ce2a535a5b62e5c0fd8231e7dba8d4eb6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataTable>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Information</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

    <table class=""table table-striped table-dark"" style=""border:1px solid black;margin: auto;width:700px  "">
        <tr table table-striped table-dark>
            <td style=""width:14%;"">ID</td>
            <td style=""width:14%;"">Nickname</td>
            <td style=""width:14%;"">icon</td>
            <td style=""width:14%;"">Max Experience</td>
            <td style=""width:14%;"">Min Experience</td>
            <td style=""width:14%;"">Name</td>
        </tr>
");
#nullable restore
#line 21 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
         foreach (DataRow ra in Model.Rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr table table-striped table-dark>\r\n                <td style=\"width:14%;\">");
#nullable restore
#line 24 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
                                  Write(Convert.ToString(ra["Id"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"width:14%;\">");
#nullable restore
#line 25 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
                                  Write(Convert.ToString(ra["NickName"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"width:14%;\">");
#nullable restore
#line 26 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
                                  Write(Convert.ToString(ra["icon"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"width:14%;\">");
#nullable restore
#line 27 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
                                  Write(Convert.ToString(ra["MaxExperience"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"width:14%;\">");
#nullable restore
#line 28 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
                                  Write(Convert.ToString(ra["MinExperience"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"width:14%;\">");
#nullable restore
#line 29 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
                                  Write(Convert.ToString(ra["Name"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          \r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n    <table style=\"border:1px solid black;margin: auto;width:700px\">\r\n        <tr>\r\n            <td style=\"width:14%;\">\r\n");
#nullable restore
#line 38 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
                 if (TempData["ERROR"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <hr />\r\n                    <span style=\"color:red; font-size:14px\" ;>\r\n                        ");
#nullable restore
#line 42 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
                   Write(TempData["ERROR"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </span>\r\n");
#nullable restore
#line 44 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
                 if (TempData["MSG"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <hr />\r\n                    <span style=\"color:navy; font-size:14px\" ;>\r\n                        ");
#nullable restore
#line 49 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
                   Write(TempData["MSG"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n");
#nullable restore
#line 51 "C:\Users\andre\source\repos\inge\MyCrudGame\MyCrudGame\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </td>\r\n\r\n        </tr>\r\n    </table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataTable> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
