#pragma checksum "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\AddTag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71598150bf15b76339ea5fced71433e56d7eb474"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_AddTag), @"mvc.1.0.view", @"/Views/Recipes/AddTag.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipes/AddTag.cshtml", typeof(AspNetCore.Views_Recipes_AddTag))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71598150bf15b76339ea5fced71433e56d7eb474", @"/Views/Recipes/AddTag.cshtml")]
    public class Views_Recipes_AddTag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 54, true);
            WriteLiteral("\r\n<h2>Add a Tag</h2>\r\n\r\n<h3>Add a tag to this recipe: ");
            EndContext();
            BeginContext(87, 41, false);
#line 5 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\AddTag.cshtml"
                         Write(Html.DisplayFor(model =>model.RecipeName));

#line default
#line hidden
            EndContext();
            BeginContext(128, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 7 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\AddTag.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(170, 39, false);
#line 9 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\AddTag.cshtml"
Write(Html.HiddenFor(model => model.RecipeId));

#line default
#line hidden
            EndContext();
            BeginContext(216, 24, false);
#line 11 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\AddTag.cshtml"
Write(Html.Label("Select Tag"));

#line default
#line hidden
            EndContext();
            BeginContext(245, 26, false);
#line 12 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\AddTag.cshtml"
Write(Html.DropDownList("TagId"));

#line default
#line hidden
            EndContext();
            BeginContext(275, 42, true);
            WriteLiteral("  <input type=\"submit\" value = \"Save\" />\r\n");
            EndContext();
#line 15 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\AddTag.cshtml"
}

#line default
#line hidden
            BeginContext(320, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(326, 47, false);
#line 17 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Recipes\AddTag.cshtml"
Write(Html.ActionLink("Back to Recipe List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(373, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
