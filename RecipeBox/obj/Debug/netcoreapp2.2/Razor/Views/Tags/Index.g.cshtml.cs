#pragma checksum "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da75a36148b6c383442a31469f055ee18eeb69b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tags_Index), @"mvc.1.0.view", @"/Views/Tags/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tags/Index.cshtml", typeof(AspNetCore.Views_Tags_Index))]
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
#line 1 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Index.cshtml"
using RecipeBox.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da75a36148b6c383442a31469f055ee18eeb69b0", @"/Views/Tags/Index.cshtml")]
    public class Views_Tags_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RecipeBox.Models.Tag>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(94, 26, true);
            WriteLiteral("\r\n<h1>Tags</h1>\r\n<hr/>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(148, 38, true);
            WriteLiteral("  <p>No tags have been added yet</p>\r\n");
            EndContext();
#line 14 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Index.cshtml"
}

#line default
#line hidden
            BeginContext(189, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Index.cshtml"
 foreach (Tag tag in Model)
{

#line default
#line hidden
            BeginContext(223, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(230, 70, false);
#line 18 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Index.cshtml"
 Write(Html.ActionLink($"{ tag.TagName }", "Details", new { id = tag.TagId }));

#line default
#line hidden
            EndContext();
            BeginContext(300, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 19 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Index.cshtml"
}

#line default
#line hidden
            BeginContext(310, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(316, 40, false);
#line 21 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Index.cshtml"
Write(Html.ActionLink("Add New Tag", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(356, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RecipeBox.Models.Tag>> Html { get; private set; }
    }
}
#pragma warning restore 1591
