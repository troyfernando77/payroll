#pragma checksum "C:\Users\troy\source\repos\Version2\Version2\Views\DTR\CreateorEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c39eff8270d4a2183f4c054589c554bddbc84234"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DTR_CreateorEdit), @"mvc.1.0.view", @"/Views/DTR/CreateorEdit.cshtml")]
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
#line 1 "C:\Users\troy\source\repos\Version2\Version2\Views\DTR\CreateorEdit.cshtml"
using Version2.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c39eff8270d4a2183f4c054589c554bddbc84234", @"/Views/DTR/CreateorEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"203836d3ee4057032b34f6afdd46e8a84644c30c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DTR_CreateorEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateorEditDTRDto>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\troy\source\repos\Version2\Version2\Views\DTR\CreateorEdit.cshtml"
     using (Html.BeginForm("Save", "DTR", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\troy\source\repos\Version2\Version2\Views\DTR\CreateorEdit.cshtml"
   Write(Html.Hidden("Id", Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-2\">\r\n                Employee  Code:\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n            <input type=\"text\" name=\"EmployeeId\"");
            BeginWriteAttribute("value", " value=\"", 362, "\"", 387, 1);
#nullable restore
#line 11 "C:\Users\troy\source\repos\Version2\Version2\Views\DTR\CreateorEdit.cshtml"
WriteAttributeValue("", 370, Model.EmployeeId, 370, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required />\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\">\r\n                Employee Time In :\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n            <input type=\"datetime\" name=\"TimeIn\"");
            BeginWriteAttribute("value", " value=\"", 641, "\"", 662, 1);
#nullable restore
#line 19 "C:\Users\troy\source\repos\Version2\Version2\Views\DTR\CreateorEdit.cshtml"
WriteAttributeValue("", 649, Model.TimeIn, 649, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required />\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\">\r\n                Employee Time Out :\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n            <input type=\"datetime\" name=\"TimeOut\"");
            BeginWriteAttribute("value", " value=\"", 918, "\"", 940, 1);
#nullable restore
#line 27 "C:\Users\troy\source\repos\Version2\Version2\Views\DTR\CreateorEdit.cshtml"
WriteAttributeValue("", 926, Model.TimeOut, 926, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required />
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-2"">
               
            </div>
            <div class=""col-md-2"">
                <input class=""btn btn-primary"" type=""submit"" value=""Save"" />
                <a class=""btn btn-danger""");
            BeginWriteAttribute("href", " href=", 1246, "", 1285, 1);
#nullable restore
#line 36 "C:\Users\troy\source\repos\Version2\Version2\Views\DTR\CreateorEdit.cshtml"
WriteAttributeValue("", 1252, Url.ActionLink( "Index", "DTR" ), 1252, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cancel</a>    \r\n            </div>\r\n            \r\n        </div>\r\n");
#nullable restore
#line 40 "C:\Users\troy\source\repos\Version2\Version2\Views\DTR\CreateorEdit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateorEditDTRDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
