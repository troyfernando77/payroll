#pragma checksum "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Rules\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fab0d395090a8307874c82e7172dcf9b38427baf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rules_Index), @"mvc.1.0.view", @"/Views/Rules/Index.cshtml")]
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
#line 1 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Rules\Index.cshtml"
using Version2.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fab0d395090a8307874c82e7172dcf9b38427baf", @"/Views/Rules/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"203836d3ee4057032b34f6afdd46e8a84644c30c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Rules_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RulesDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    ");
#nullable restore
#line 4 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Rules\Index.cshtml"
Write(Html.ActionLink("Create", "CreateorEdit", "Rules", new { id=0,category= ViewBag.category }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Rules\Index.cshtml"
      

        foreach (var message in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-1\">\r\n                    ");
#nullable restore
#line 12 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Rules\Index.cshtml"
               Write(message.ItemNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-1\">\r\n                    ");
#nullable restore
#line 15 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Rules\Index.cshtml"
               Write(message.RuleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-1\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Rules\Index.cshtml"
               Write(message.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 20 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Rules\Index.cshtml"
                 if (@message.Category!="Main")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-1\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Rules\Index.cshtml"
               Write(message.Priority);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Rules\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-1\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Rules\Index.cshtml"
               Write(message.RuleTarget);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-1\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Rules\Index.cshtml"
               Write(message.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-2\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Rules\Index.cshtml"
               Write(Html.ActionLink("Edit", "CreateorEdit", "Rules", new { message.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 34 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Rules\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", "Rules", new { id=message.Id,category=message.Category }, new { onclick = "return confirm('Are you sure you want to delete this Message?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 38 "C:\Users\troy\repos\Payroll\payroll\Version2\Views\Rules\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RulesDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
