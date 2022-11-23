#pragma checksum "C:\Users\troy\source\repos\Version2\Version2\Views\DTRSummary\Select.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fac5b113b284d066ec98ed8eaed6d1fb2bd64ed9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DTRSummary_Select), @"mvc.1.0.view", @"/Views/DTRSummary/Select.cshtml")]
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
#line 1 "C:\Users\troy\source\repos\Version2\Version2\Views\_ViewImports.cshtml"
using Version2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRSummary\Select.cshtml"
using Version2.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fac5b113b284d066ec98ed8eaed6d1fb2bd64ed9", @"/Views/DTRSummary/Select.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"203836d3ee4057032b34f6afdd46e8a84644c30c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DTRSummary_Select : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DTRDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"        <table class=""table table-bordered table-sm"" style=""font-size:small"">
            <thead>
                <tr>
                    <th scope=""col"">TimeIn</th>
                    <th scope=""col"">TimeOut</th>
                    <th scope=""col"">Hours</th>
                    <th scope=""col"">Rate</th>
                    <th scope=""col"">Amount</th>
                    <th scope=""col"">OT</th>
                    <th scope=""col"">Total</th>
                    <th scope=""col""></th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 20 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRSummary\Select.cshtml"
                 foreach (var employee in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        \r\n                        <td class=\"col-md-2\">\r\n                            ");
#nullable restore
#line 25 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRSummary\Select.cshtml"
                       Write(employee.TimeIn.ToString("MM/dd/yyyy hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-md-2\">\r\n                            ");
#nullable restore
#line 28 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRSummary\Select.cshtml"
                       Write(employee.TimeOut.ToString("MM/dd/yyyy hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-md-1\" align=\"right\">\r\n                            ");
#nullable restore
#line 31 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRSummary\Select.cshtml"
                       Write(employee.TotalHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-md-1\" align=\"right\">\r\n                            ");
#nullable restore
#line 34 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRSummary\Select.cshtml"
                       Write(employee.Rate.RateHr.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-md-1\" align=\"right\">\r\n                            ");
#nullable restore
#line 37 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRSummary\Select.cshtml"
                       Write(employee.Amount.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-md-1\" align=\"right\">\r\n                            ");
#nullable restore
#line 40 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRSummary\Select.cshtml"
                       Write(employee.OTAmount.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-md-1\" align=\"right\">\r\n                            ");
#nullable restore
#line 43 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRSummary\Select.cshtml"
                       Write(employee.NetPay.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-md-1\" align=\"center\">\r\n                            <a");
            BeginWriteAttribute("href", " href=", 1954, "", 2020, 1);
#nullable restore
#line 46 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRSummary\Select.cshtml"
WriteAttributeValue("", 1960, Url.ActionLink("CreateorEdit", "DTR", new { employee.Id } ), 1960, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <i class=""fa fa-pencil"" aria-hidden=""true""></i>
                            </a>
                        </td>
                        <td class=""col-md-1"" align=""center"">
                            <a href=""#"", new { employee.Id })");
            BeginWriteAttribute("onclick", "\r\n                                onclick=\"", 2292, "\"", 2436, 13);
            WriteAttributeValue("", 2335, "if(", 2335, 3, true);
            WriteAttributeValue(" ", 2338, "confirm(\'Are", 2339, 13, true);
            WriteAttributeValue(" ", 2351, "you", 2352, 4, true);
            WriteAttributeValue(" ", 2355, "sure", 2356, 5, true);
            WriteAttributeValue(" ", 2360, "you", 2361, 4, true);
            WriteAttributeValue(" ", 2364, "want", 2365, 5, true);
            WriteAttributeValue(" ", 2369, "to", 2370, 3, true);
            WriteAttributeValue(" ", 2372, "delete?\'))", 2373, 11, true);
            WriteAttributeValue(" ", 2383, "deleteEmployee(", 2384, 16, true);
#nullable restore
#line 52 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRSummary\Select.cshtml"
WriteAttributeValue("", 2399, employee.Id, 2399, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2411, ",", 2411, 1, true);
#nullable restore
#line 52 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRSummary\Select.cshtml"
WriteAttributeValue(" ", 2412, employee.DTRSummaryId, 2413, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2435, ")", 2435, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fa fa-trash\" style=\"color:red\" aria-hidden=\"true\"></i>\r\n                            </a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRSummary\Select.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DTRDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
