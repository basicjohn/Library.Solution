#pragma checksum "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d69fee40ac761494ad03a3507ec8be6a3e7a95d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_Index), @"mvc.1.0.view", @"/Views/Authors/Index.cshtml")]
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
#line 5 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Index.cshtml"
using Library.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d69fee40ac761494ad03a3507ec8be6a3e7a95d8", @"/Views/Authors/Index.cshtml")]
    public class Views_Authors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library.Models.Author>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("<main>\n  <h1>Items for ");
#nullable restore
#line 8 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Index.cshtml"
           Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n");
#nullable restore
#line 10 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Index.cshtml"
   if (Model.Any())
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\n");
#nullable restore
#line 13 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Index.cshtml"
       foreach (Author author in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 15 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Index.cshtml"
       Write(Html.ActionLink($"{author.AuthorName}", "Details", new { id = author.AuthorId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 16 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n");
#nullable restore
#line 18 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Index.cshtml"
  } 
  else
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>No authors have been added yet!</h3>\n");
#nullable restore
#line 22 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n  <p>");
#nullable restore
#line 24 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Index.cshtml"
Write(Html.ActionLink("Add new author", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n  <p>");
#nullable restore
#line 26 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library.Models.Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591
