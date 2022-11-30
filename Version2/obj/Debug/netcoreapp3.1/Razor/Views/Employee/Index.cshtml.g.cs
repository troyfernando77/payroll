#pragma checksum "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ed9117d1ba010e32ab8ebc653d3c20d13327d28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\_ViewImports.cshtml"
using Version2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
using Version2.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ed9117d1ba010e32ab8ebc653d3c20d13327d28", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"203836d3ee4057032b34f6afdd46e8a84644c30c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<a href=\"Employee/CreateorEdit\">Create</a>\r\n\r\n<table class=\"table table-bordered table-sm small\">\r\n        <thead>\r\n            <tr>\r\n");
            WriteLiteral(@"                <th scope=""col"">Code</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Company</th>
                <th scope=""col"">Rate</th>
                <th scope=""col""></th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>
   
");
#nullable restore
#line 20 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
         foreach (var employee in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
            WriteLiteral("                    <td class=\"col-md-1 col-1\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
                   Write(employee.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 30 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
                   Write(employee.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
                   Write(employee.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 36 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
                   Write(employee.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <td class=\"col-md-1\" align=\"right\">\r\n                        ");
#nullable restore
#line 38 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
                   Write(employee.Rate.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                    </td>\r\n                    <td class=\"col-md-1\" align=\"center\">\r\n                        <a");
            BeginWriteAttribute("href", " href=", 1417, "", 1488, 1);
#nullable restore
#line 41 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1423, Url.ActionLink("CreateorEdit", "Employee", new { employee.Id } ), 1423, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fa fa-pencil\" aria-hidden=\"true\"></i>\r\n                        </a>  \r\n                        </td>\r\n                    <td class =\"col-md-1\" align=\"center\">\r\n                        <a");
            BeginWriteAttribute("href", " href=", 1716, "", 1780, 1);
#nullable restore
#line 46 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1722, Url.ActionLink("Delete", "Employee", new { employee.Id }), 1722, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                           onclick=""return confirm('Are you sure you want to delete this Message?')"">
                            <i class=""fa fa-trash"" style=""color:red"" aria-hidden=""true""></i>
                        </a>
                    </td>
                </tr>
");
#nullable restore
#line 52 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
