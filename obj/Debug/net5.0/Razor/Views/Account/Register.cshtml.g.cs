#pragma checksum "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Account/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "979d591b026463ebcf531218cab19f451b0ab24c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
#line 5 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Account/Register.cshtml"
using Library.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"979d591b026463ebcf531218cab19f451b0ab24c", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Account/Register.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("<h2>Register a new user</h2>\n<hr />\n");
#nullable restore
#line 10 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Account/Register.cshtml"
 using (Html.BeginForm("Register", "Account", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Account/Register.cshtml"
Write(Html.LabelFor(user => user.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Account/Register.cshtml"
Write(Html.TextBoxFor(user=> user.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Account/Register.cshtml"
Write(Html.LabelFor(user=> user.Password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Account/Register.cshtml"
Write(Html.PasswordFor(user=> user.Password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Account/Register.cshtml"
Write(Html.LabelFor(user=> user.ConfirmPassword));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Account/Register.cshtml"
Write(Html.PasswordFor(user=> user.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Register\" />\n");
#nullable restore
#line 22 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Account/Register.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
