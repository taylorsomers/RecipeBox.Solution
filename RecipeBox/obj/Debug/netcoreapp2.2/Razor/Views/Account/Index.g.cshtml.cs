#pragma checksum "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab114a7e2601bc863e401e2793f2e66f76df5e21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
#line 5 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab114a7e2601bc863e401e2793f2e66f76df5e21", @"/Views/Account/Index.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(63, 51, true);
            WriteLiteral("\r\n<h2>Authentication with Identity</h2>\r\n<hr />\r\n\r\n");
            EndContext();
#line 10 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(154, 11, true);
            WriteLiteral("  <p>Hello ");
            EndContext();
            BeginContext(166, 18, false);
#line 12 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Index.cshtml"
      Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(184, 7, true);
            WriteLiteral("!</p>\r\n");
            EndContext();
#line 13 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Index.cshtml"
   using (Html.BeginForm("LogOff", "Account"))
  {

#line default
#line hidden
            BeginContext(244, 69, true);
            WriteLiteral("    <input type=\"submit\" class=\"btn btn-default\" value=\"Log out\" />\r\n");
            EndContext();
#line 16 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Index.cshtml"
  }

#line default
#line hidden
#line 16 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Index.cshtml"
   
}
else
{

#line default
#line hidden
            BeginContext(330, 5, true);
            WriteLiteral("  <p>");
            EndContext();
            BeginContext(336, 39, false);
#line 20 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Index.cshtml"
Write(Html.ActionLink("Register", "Register"));

#line default
#line hidden
            EndContext();
            BeginContext(375, 11, true);
            WriteLiteral("</p>\r\n  <p>");
            EndContext();
            BeginContext(387, 34, false);
#line 21 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Index.cshtml"
Write(Html.ActionLink("Log In", "Login"));

#line default
#line hidden
            EndContext();
            BeginContext(421, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 22 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Index.cshtml"
}

#line default
#line hidden
            BeginContext(430, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(436, 40, false);
#line 24 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(476, 4, true);
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
