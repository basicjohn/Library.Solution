#pragma checksum "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36b4cf3d2eb648d2c6d280ad377a67f8c82f599f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_Create), @"mvc.1.0.view", @"/Views/Authors/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b4cf3d2eb648d2c6d280ad377a67f8c82f599f", @"/Views/Authors/Create.cshtml")]
    public class Views_Authors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"offset-md-3 col-md-6\">\n");
#nullable restore
#line 2 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Create.cshtml"
    
    Layout = "_Layout";
  

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("  <h4>Add a new Author</h4>\n\n");
#nullable restore
#line 9 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Create.cshtml"
   using (Html.BeginForm())
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Create.cshtml"
Write(Html.TextBoxFor(model => model.AuthorName, new { @class = "form-control", placeholder =
  @Html.DisplayNameFor(m=>m.AuthorName), required="required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\n");
#nullable restore
#line 15 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Create.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>");
#nullable restore
#line 16 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Authors/Create.cshtml"
Write(Html.ActionLink("Show all Authors", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>");
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
