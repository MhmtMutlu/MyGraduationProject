#pragma checksum "C:\Users\Public\BitirmeProjesi\bitirme\bitirme.webui\Views\Account\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7e69c990e62e2c754a08d893f286059ed16da24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Manage), @"mvc.1.0.view", @"/Views/Account/Manage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7e69c990e62e2c754a08d893f286059ed16da24", @"/Views/Account/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb46c882984e328fbb134caf58e27475dca00bac", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3 class=\"h1\">Hesap Ayrıntıları</h3>\r\n<hr>\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"list-group\">\r\n");
#nullable restore
#line 8 "C:\Users\Public\BitirmeProjesi\bitirme\bitirme.webui\Views\Account\Manage.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <a href=""/admin/notelist"" class=""list-group-item list-group-item-action list-group-item-secondary"">
                    Bütün Gönderiler
                </a>
                <a href=""/admin/articlecreate"" class=""list-group-item list-group-item-action list-group-item-secondary"">
                    Makale Ekle
                </a>
                <a href=""/admin/articlelist"" class=""list-group-item list-group-item-action list-group-item-secondary"">
                    Bütün Makaleler
                </a>
                <a href=""/admin/books"" class=""list-group-item list-group-item-action list-group-item-secondary"">
                    Kitap Listesi
                </a>
                <a href=""/admin/categories"" class=""list-group-item list-group-item-action list-group-item-secondary"">
                    Kategori Listesi
                </a>
                <a href=""/admin/role/list"" class=""list-group-item list-group-item-action list-group-item-secondary"">
                    Rol");
            WriteLiteral(" Listesi\r\n                </a>\r\n                <a href=\"/admin/user/list\" class=\"list-group-item list-group-item-action list-group-item-secondary\">\r\n                    Kullanıcı Listesi\r\n                </a>\r\n");
#nullable restore
#line 31 "C:\Users\Public\BitirmeProjesi\bitirme\bitirme.webui\Views\Account\Manage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <a href=""/account/forgotpassword"" class=""list-group-item list-group-item-action list-group-item-secondary"">Şifre Değişikliği</a>
            <a href=""/account/logout"" class=""list-group-item list-group-item-action list-group-item-danger"">Çıkış Yap</a>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
