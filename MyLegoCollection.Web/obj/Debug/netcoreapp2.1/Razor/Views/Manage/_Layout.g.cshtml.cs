#pragma checksum "C:\Users\Shenaida\source\repos\MyLegoCollection\MyLegoCollection.Web\Views\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0362a0f063ee223f0412d842137fa1926c600983"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__Layout), @"mvc.1.0.view", @"/Views/Manage/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/_Layout.cshtml", typeof(AspNetCore.Views_Manage__Layout))]
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
#line 1 "C:\Users\Shenaida\source\repos\MyLegoCollection\MyLegoCollection.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Shenaida\source\repos\MyLegoCollection\MyLegoCollection.Web\Views\_ViewImports.cshtml"
using MyLegoCollection.Web;

#line default
#line hidden
#line 3 "C:\Users\Shenaida\source\repos\MyLegoCollection\MyLegoCollection.Web\Views\_ViewImports.cshtml"
using MyLegoCollection.Web.Models;

#line default
#line hidden
#line 4 "C:\Users\Shenaida\source\repos\MyLegoCollection\MyLegoCollection.Web\Views\_ViewImports.cshtml"
using MyLegoCollection.Web.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\Shenaida\source\repos\MyLegoCollection\MyLegoCollection.Web\Views\_ViewImports.cshtml"
using MyLegoCollection.Web.Models.ManageViewModels;

#line default
#line hidden
#line 1 "C:\Users\Shenaida\source\repos\MyLegoCollection\MyLegoCollection.Web\Views\Manage\_ViewImports.cshtml"
using MyLegoCollection.Web.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0362a0f063ee223f0412d842137fa1926c600983", @"/Views/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c448b0219b35dfeb51b3d92f576cba99db0b730", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"669ed6b5203119526174aa1ab771659c1ca49401", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Shenaida\source\repos\MyLegoCollection\MyLegoCollection.Web\Views\Manage\_Layout.cshtml"
   
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(54, 163, true);
            WriteLiteral("\r\n<h2>Manage your account</h2>\r\n\r\n<div>\r\n    <h4>Change your account settings</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(218, 37, false);
#line 12 "C:\Users\Shenaida\source\repos\MyLegoCollection\MyLegoCollection.Web\Views\Manage\_Layout.cshtml"
       Write(await Html.PartialAsync("_ManageNav"));

#line default
#line hidden
            EndContext();
            BeginContext(255, 62, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            ");
            EndContext();
            BeginContext(318, 12, false);
#line 15 "C:\Users\Shenaida\source\repos\MyLegoCollection\MyLegoCollection.Web\Views\Manage\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(330, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(388, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(395, 41, false);
#line 21 "C:\Users\Shenaida\source\repos\MyLegoCollection\MyLegoCollection.Web\Views\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(436, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(441, 10, true);
            WriteLiteral("        \r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
