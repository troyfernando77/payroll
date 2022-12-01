#pragma checksum "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f9ac9ee63b8df6185144bad4c218c023640b243"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f9ac9ee63b8df6185144bad4c218c023640b243", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"203836d3ee4057032b34f6afdd46e8a84644c30c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<a href=\"Employee/CreateorEdit\">Create</a>\r\n\r\n<table class=\"table table-bordered table-sm small\">\r\n        <thead>\r\n            <tr>\r\n");
            WriteLiteral(@"                <th scope=""col"">Number</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Company</th>
                <th scope=""col"">Department</th>

                <th scope=""col"">Rate</th>
                <th scope=""col""></th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>
   
");
#nullable restore
#line 22 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
         foreach (var employee in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
            WriteLiteral("                    <td class=\"col-md-1 col-1\">\r\n                        ");
#nullable restore
#line 29 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
                   Write(employee.EmployeeNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
                   Write(employee.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 35 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
                   Write(employee.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 38 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
                   Write(employee.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-md-1\" align=\"right\">\r\n                        ");
#nullable restore
#line 41 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
                   Write(employee.Rate.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                    </td>\r\n                    <td class=\"col-md-1\" align=\"center\">\r\n                        <a");
            BeginWriteAttribute("href", " href=", 1501, "", 1572, 1);
#nullable restore
#line 44 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1507, Url.ActionLink("CreateorEdit", "Employee", new { employee.Id } ), 1507, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fa fa-pencil\" aria-hidden=\"true\"></i>\r\n                        </a>  \r\n                        </td>\r\n                    <td class =\"col-md-1\" align=\"center\">\r\n                        <a");
            BeginWriteAttribute("href", " href=", 1800, "", 1864, 1);
#nullable restore
#line 49 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1806, Url.ActionLink("Delete", "Employee", new { employee.Id }), 1806, 58, false);

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
#line 55 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Employee\Index.cshtml"
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
