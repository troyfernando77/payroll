#pragma checksum "C:\Users\troy\source\repos\Version2\Version2\Views\DTRHead\CreateorEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31db24f55dc0f57d3463cf21f239225e8ad3eb68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DTRHead_CreateorEdit), @"mvc.1.0.view", @"/Views/DTRHead/CreateorEdit.cshtml")]
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
#line 1 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRHead\CreateorEdit.cshtml"
using Version2.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31db24f55dc0f57d3463cf21f239225e8ad3eb68", @"/Views/DTRHead/CreateorEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"203836d3ee4057032b34f6afdd46e8a84644c30c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DTRHead_CreateorEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateorEditDTRHeadDTO>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRHead\CreateorEdit.cshtml"
     using (Html.BeginForm("Save", "DTRHead", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRHead\CreateorEdit.cshtml"
   Write(Html.Hidden("Id", Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-2\">\r\n                Employee  Code:\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n            <input type=\"datetime\" name=\"Startdate\"");
            BeginWriteAttribute("value", " value=\"", 373, "\"", 397, 1);
#nullable restore
#line 11 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRHead\CreateorEdit.cshtml"
WriteAttributeValue("", 381, Model.Startdate, 381, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required />
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-2"">
                Employee Time In :
            </div>
            <div class=""col-md-6"">
            <input type=""datetime"" name=""Cutoffdate""");
            BeginWriteAttribute("value", " value=\"", 655, "\"", 680, 1);
#nullable restore
#line 19 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRHead\CreateorEdit.cshtml"
WriteAttributeValue("", 663, Model.Cutoffdate, 663, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required />\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-2\">\r\n               \r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                <input class=\"btn btn-primary\" type=\"submit\" value=\"Save\" />\r\n                <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=", 995, "", 1038, 1);
#nullable restore
#line 29 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRHead\CreateorEdit.cshtml"
WriteAttributeValue("", 1001, Url.ActionLink( "Index", "DTRHead" ), 1001, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cancel</a>    \r\n            </div>\r\n            \r\n        </div>\r\n");
#nullable restore
#line 33 "C:\Users\troy\source\repos\Version2\Version2\Views\DTRHead\CreateorEdit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateorEditDTRHeadDTO> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
