#pragma checksum "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0d03901aa0657e5ed0433fcd1b134dd2d0c20ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Index), @"mvc.1.0.view", @"/Views/Recipes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipes/Index.cshtml", typeof(AspNetCore.Views_Recipes_Index))]
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
#line 1 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\Index.cshtml"
using RecipeBox.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0d03901aa0657e5ed0433fcd1b134dd2d0c20ee", @"/Views/Recipes/Index.cshtml")]
    public class Views_Recipes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RecipeBox.Models.Recipe>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(97, 29, true);
            WriteLiteral("\r\n<h1>Recipes</h1>\r\n<hr/>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(154, 41, true);
            WriteLiteral("  <p>No recipes have been added yet</p>\r\n");
            EndContext();
#line 14 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\Index.cshtml"
}

#line default
#line hidden
            BeginContext(198, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\Index.cshtml"
 foreach (Recipe recipe in Model)
{

#line default
#line hidden
            BeginContext(238, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(245, 82, false);
#line 18 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\Index.cshtml"
 Write(Html.ActionLink($"{ recipe.RecipeName }", "Details", new { id = recipe.RecipeId }));

#line default
#line hidden
            EndContext();
            BeginContext(327, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 19 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\Index.cshtml"
}

#line default
#line hidden
            BeginContext(337, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(343, 43, false);
#line 21 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\Index.cshtml"
Write(Html.ActionLink("Add New Recipe", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(386, 6, true);
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RecipeBox.Models.Recipe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
