#pragma checksum "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "644fd9d45bef1ce4c59de698e4a50faa771dc7be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patrons_Edit), @"mvc.1.0.view", @"/Views/Patrons/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644fd9d45bef1ce4c59de698e4a50faa771dc7be", @"/Views/Patrons/Edit.cshtml")]
    public class Views_Patrons_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("<main>\n\n<h2>Edit</h2>\n\n<h4>Edit this task: ");
#nullable restore
#line 10 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Edit.cshtml"
               Write(Html.DisplayFor(model => model.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 12 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Edit.cshtml"
Write(Html.HiddenFor(model => model.AuthorId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Edit.cshtml"
Write(Html.LabelFor(model => model.AuthorName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Edit.cshtml"
Write(Html.EditorFor(model => model.AuthorName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Edit.cshtml"
Write(Html.Label("Select book"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Edit.cshtml"
Write(Html.DropDownList("BookId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
#nullable restore
#line 23 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 25 "/Users/isaacmoreno/Desktop/epicodus/Library.Solution/Library.Solution/Library/Views/Patrons/Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

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
