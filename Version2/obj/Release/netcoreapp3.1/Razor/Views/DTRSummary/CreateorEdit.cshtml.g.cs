#pragma checksum "C:\Users\troy\repos\Payroll\payroll\Version2\Views\DTRSummary\CreateorEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eed5208be7a9e24f246390dbb11e3c4a3beb5ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DTRSummary_CreateorEdit), @"mvc.1.0.view", @"/Views/DTRSummary/CreateorEdit.cshtml")]
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
#line 1 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\DTRSummary\CreateorEdit.cshtml"
using Version2.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eed5208be7a9e24f246390dbb11e3c4a3beb5ef", @"/Views/DTRSummary/CreateorEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"203836d3ee4057032b34f6afdd46e8a84644c30c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DTRSummary_CreateorEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateorEditDTRSummaryDto>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\DTRSummary\CreateorEdit.cshtml"
     using (Html.BeginForm("Save", "DTRSummary", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\DTRSummary\CreateorEdit.cshtml"
   Write(Html.Hidden("Id", Model.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\DTRSummary\CreateorEdit.cshtml"
   Write(Html.Hidden("DTRHeadId", Model.DTRHeadId));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-2\">\r\n                Employee  Code:\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n            <input type=\"text\" name=\"EmployeeId\"");
            BeginWriteAttribute("value", " value=\"", 430, "\"", 455, 1);
#nullable restore
#line 13 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\DTRSummary\CreateorEdit.cshtml"
WriteAttributeValue("", 438, Model.EmployeeId, 438, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required />\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\">\r\n                Amounr :\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n            <input type=\"datetime\" name=\"Amount\"");
            BeginWriteAttribute("value", " value=\"", 699, "\"", 720, 1);
#nullable restore
#line 21 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\DTRSummary\CreateorEdit.cshtml"
WriteAttributeValue("", 707, Model.Amount, 707, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required />\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-2\">\r\n               \r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                <input class=\"btn btn-primary\" type=\"submit\" value=\"Save\" />\r\n                <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=", 1031, "", 1070, 1);
#nullable restore
#line 31 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\DTRSummary\CreateorEdit.cshtml"
WriteAttributeValue("", 1037, Url.ActionLink( "Index", "DTR" ), 1037, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cancel</a>    \r\n            </div>\r\n            \r\n        </div>\r\n");
#nullable restore
#line 35 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\DTRSummary\CreateorEdit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateorEditDTRSummaryDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591