#pragma checksum "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2a6ead2fa58f6036d9991b474a362df564cb058"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2a6ead2fa58f6036d9991b474a362df564cb058", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Home\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 28, true);
            WriteLiteral("\r\n<h1>Recipe Box</h1>\r\n\r\n<p>");
            EndContext();
            BeginContext(59, 54, false);
#line 7 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Home\Index.cshtml"
Write(Html.ActionLink("See all Recipes", "Index", "Recipes"));

#line default
#line hidden
            EndContext();
            BeginContext(113, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(123, 48, false);
#line 8 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Home\Index.cshtml"
Write(Html.ActionLink("See all Tags", "Index", "Tags"));

#line default
#line hidden
            EndContext();
            BeginContext(171, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
