#pragma checksum "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d4400329f89ba62263816d5f899f5ee0dda1379"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patrons_Create), @"mvc.1.0.view", @"/Views/Patrons/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d4400329f89ba62263816d5f899f5ee0dda1379", @"/Views/Patrons/Create.cshtml")]
    public class Views_Patrons_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("<main>\n  <h4>Add a new Author</h4>\n\n");
#nullable restore
#line 9 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Create.cshtml"
   using (Html.BeginForm())
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Create.cshtml"
Write(Html.LabelFor(model => model.AuthorName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Create.cshtml"
Write(Html.TextBoxFor(model => model.AuthorName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Create.cshtml"
Write(Html.Label("Select Book"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Create.cshtml"
Write(Html.DropDownList("BookId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Add new Author\" class=\"btn btn-default\" />\n");
#nullable restore
#line 18 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Create.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>");
#nullable restore
#line 19 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Create.cshtml"
Write(Html.ActionLink("Show all Authors", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Author> Html { get; private set; }
    }
}
#pragma warning restore 1591
