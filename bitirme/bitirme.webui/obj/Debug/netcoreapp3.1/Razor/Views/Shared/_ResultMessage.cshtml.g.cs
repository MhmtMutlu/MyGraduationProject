#pragma checksum "C:\Users\Public\BitirmeProjesi\bitirme\bitirme.webui\Views\Shared\_ResultMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c31566ebd358135435d57d70271dbb3dfb6e3c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ResultMessage), @"mvc.1.0.view", @"/Views/Shared/_ResultMessage.cshtml")]
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
#line 2 "C:\Users\Public\BitirmeProjesi\bitirme\bitirme.webui\Views\_ViewImports.cshtml"
using bitirme.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Public\BitirmeProjesi\bitirme\bitirme.webui\Views\_ViewImports.cshtml"
using bitirme.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Public\BitirmeProjesi\bitirme\bitirme.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Public\BitirmeProjesi\bitirme\bitirme.webui\Views\_ViewImports.cshtml"
using bitirme.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Public\BitirmeProjesi\bitirme\bitirme.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Public\BitirmeProjesi\bitirme\bitirme.webui\Views\_ViewImports.cshtml"
using bitirme.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c31566ebd358135435d57d70271dbb3dfb6e3c2", @"/Views/Shared/_ResultMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb46c882984e328fbb134caf58e27475dca00bac", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ResultMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlertMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 85, "\"", 121, 3);
            WriteAttributeValue("", 93, "alert", 93, 5, true);
            WriteAttributeValue(" ", 98, "alert-", 99, 7, true);
#nullable restore
#line 6 "C:\Users\Public\BitirmeProjesi\bitirme\bitirme.webui\Views\Shared\_ResultMessage.cshtml"
WriteAttributeValue("", 105, Model.AlertType, 105, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <h4 class=\"alert-title\">");
#nullable restore
#line 7 "C:\Users\Public\BitirmeProjesi\bitirme\bitirme.webui\Views\Shared\_ResultMessage.cshtml"
                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <p>");
#nullable restore
#line 8 "C:\Users\Public\BitirmeProjesi\bitirme\bitirme.webui\Views\Shared\_ResultMessage.cshtml"
          Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlertMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
