#pragma checksum "C:\Users\Shuaib\Desktop\J78642\MyRestaurant\Areas\Identity\Pages\_AuthorizationLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83d22ee5b68c22d1493fe749a22fc204ff9cdbfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__AuthorizationLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_AuthorizationLayout.cshtml")]
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
#line 1 "C:\Users\Shuaib\Desktop\J78642\MyRestaurant\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shuaib\Desktop\J78642\MyRestaurant\Areas\Identity\Pages\_ViewImports.cshtml"
using MyRestaurant.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shuaib\Desktop\J78642\MyRestaurant\Areas\Identity\Pages\_ViewImports.cshtml"
using MyRestaurant.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shuaib\Desktop\J78642\MyRestaurant\Areas\Identity\Pages\_ViewImports.cshtml"
using MyRestaurant.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83d22ee5b68c22d1493fe749a22fc204ff9cdbfa", @"/Areas/Identity/Pages/_AuthorizationLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f72453d203d9c75ba381525967e73a25023220", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__AuthorizationLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Shuaib\Desktop\J78642\MyRestaurant\Areas\Identity\Pages\_AuthorizationLayout.cshtml"
  
    Layout = "/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""middle-box"">
    <div class=""tab"" id=""tab"">
        <a class=""tablink button"" href=""/Identity/Account/Login""> Sign In</a>
        <a class=""tablink button"" href=""/Identity/Account/Register""> Sign Up</a>
    </div>
    <div class=""tabcontent"">
        ");
#nullable restore
#line 11 "C:\Users\Shuaib\Desktop\J78642\MyRestaurant\Areas\Identity\Pages\_AuthorizationLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n        ");
#nullable restore
#line 18 "C:\Users\Shuaib\Desktop\J78642\MyRestaurant\Areas\Identity\Pages\_AuthorizationLayout.cshtml"
   Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <script>
            $(function () {
                var current = location.pathname;
                $('.tab a').each(function () {
                    var $this = $(this);
                    console.log($this.current)
                    if (current.indexOf($this.attr('href')) !== -1) {
                        $this.addClass('activ');
                    }
                })
            })
        </script>
    ");
            }
            );
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