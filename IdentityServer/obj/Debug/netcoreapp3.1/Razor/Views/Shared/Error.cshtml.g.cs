#pragma checksum "/home/matheus/Projects/EClothing/IdentityServer/Views/Shared/Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6cfd2b761b5b8c3aff6efe2609cfe1f11b2c581"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6cfd2b761b5b8c3aff6efe2609cfe1f11b2c581", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityServer.Quickstart.Home.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/matheus/Projects/EClothing/IdentityServer/Views/Shared/Error.cshtml"
  
    var error = Model?.Error?.Error;
    var errorDescription = Model?.Error?.ErrorDescription;
    var request_id = Model?.Error?.RequestId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"error-page\">\n    <div class=\"page-header\">\n        <h1>Error</h1>\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col-sm-6\">\n            <div class=\"alert alert-danger\">\n                Sorry, there was an error\n\n");
#nullable restore
#line 19 "/home/matheus/Projects/EClothing/IdentityServer/Views/Shared/Error.cshtml"
                 if (error != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <strong>\n                        <em>\n                            : ");
#nullable restore
#line 23 "/home/matheus/Projects/EClothing/IdentityServer/Views/Shared/Error.cshtml"
                         Write(error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </em>\n                    </strong>\n");
#nullable restore
#line 26 "/home/matheus/Projects/EClothing/IdentityServer/Views/Shared/Error.cshtml"

                    if (errorDescription != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>");
#nullable restore
#line 29 "/home/matheus/Projects/EClothing/IdentityServer/Views/Shared/Error.cshtml"
                        Write(errorDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 30 "/home/matheus/Projects/EClothing/IdentityServer/Views/Shared/Error.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n\n");
#nullable restore
#line 34 "/home/matheus/Projects/EClothing/IdentityServer/Views/Shared/Error.cshtml"
             if (request_id != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"request-id\">Request Id: ");
#nullable restore
#line 36 "/home/matheus/Projects/EClothing/IdentityServer/Views/Shared/Error.cshtml"
                                               Write(request_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 37 "/home/matheus/Projects/EClothing/IdentityServer/Views/Shared/Error.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityServer.Quickstart.Home.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
