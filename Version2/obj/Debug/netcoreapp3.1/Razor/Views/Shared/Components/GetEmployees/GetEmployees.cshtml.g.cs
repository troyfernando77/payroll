#pragma checksum "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Shared\Components\GetEmployees\GetEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afa130649793c5a5b031a0352abb990449240fd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GetEmployees_GetEmployees), @"mvc.1.0.view", @"/Views/Shared/Components/GetEmployees/GetEmployees.cshtml")]
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
#line 1 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Shared\Components\GetEmployees\GetEmployees.cshtml"
using Version2.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afa130649793c5a5b031a0352abb990449240fd0", @"/Views/Shared/Components/GetEmployees/GetEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"203836d3ee4057032b34f6afdd46e8a84644c30c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_GetEmployees_GetEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDto[]>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" id=""Modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Select</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <table class=""table table-bordered"" style=""font-size:small"">
                    <thead>
                        <tr>
                            <th scope=""col"">Employee</th>
                            <th scope=""col""></th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 22 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Shared\Components\GetEmployees\GetEmployees.cshtml"
                         for (var i = 0; i < Model.Count(); i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"col-md-6 \">\r\n                                        ");
#nullable restore
#line 26 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Shared\Components\GetEmployees\GetEmployees.cshtml"
                                   Write(Model[i].EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                <td class=\"col-md-1\"><input type=\"button\"");
            BeginWriteAttribute("onclick", "\r\n                                       onclick=\"", 1322, "\"", 1579, 10);
            WriteAttributeValue("", 1372, "OnSuccessSelect(", 1372, 16, true);
            WriteAttributeValue("\r\n                                        ", 1388, "\'", 1430, 43, true);
#nullable restore
#line 30 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Shared\Components\GetEmployees\GetEmployees.cshtml"
WriteAttributeValue("", 1431, Model[i].EmployeeId, 1431, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1451, "\',", 1451, 2, true);
            WriteAttributeValue("\r\n                                        ", 1453, "\'", 1495, 43, true);
#nullable restore
#line 31 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Shared\Components\GetEmployees\GetEmployees.cshtml"
WriteAttributeValue("", 1496, Model[i].EmployeeName, 1496, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1518, "\',", 1518, 2, true);
            WriteAttributeValue("\r\n                                        ", 1520, "\'", 1562, 43, true);
#nullable restore
#line 32 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Shared\Components\GetEmployees\GetEmployees.cshtml"
WriteAttributeValue("", 1563, Model[i].Rate, 1563, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1577, "\')", 1577, 2, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                       value=\"Select\">\r\n                                </td>\r\n                                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Shared\Components\GetEmployees\GetEmployees.cshtml"
                                 
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>

                </table>
            </div>
           
        </div>
    </div>
</div>


<script type=""text/javascript"">
  
    function OnSuccessSelect(empid, empname, rate) 
    {   
        document.getElementById('EmployeeName').value=empname;
        document.getElementById('EmployeeId').value = empid;
        document.getElementById('Rate').value = rate;
        Hide();
    }
    function Hide()
    {
        $(""#Modal"").modal(""hide"");
    }
</script>
 ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDto[]> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
