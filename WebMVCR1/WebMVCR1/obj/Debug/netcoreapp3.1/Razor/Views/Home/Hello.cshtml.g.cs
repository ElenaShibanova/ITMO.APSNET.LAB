#pragma checksum "C:\Users\shibanovi\source\repos\WebMVCR1\WebMVCR1\Views\Home\Hello.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4783fbe1f8a5fdf3d28407bc2414ee5a8e876eff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Hello), @"mvc.1.0.view", @"/Views/Home/Hello.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4783fbe1f8a5fdf3d28407bc2414ee5a8e876eff", @"/Views/Home/Hello.cshtml")]
    #nullable restore
    public class Views_Home_Hello : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebMVCR1.Models.Person>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\shibanovi\source\repos\WebMVCR1\WebMVCR1\Views\Home\Hello.cshtml"
  
    ViewBag.Title = "Приветствие";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h1>Здравствуйте, ");
#nullable restore
#line 6 "C:\Users\shibanovi\source\repos\WebMVCR1\WebMVCR1\Views\Home\Hello.cshtml"
                 Write(Model.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\r\n    <p>\r\n        ");
#nullable restore
#line 8 "C:\Users\shibanovi\source\repos\WebMVCR1\WebMVCR1\Views\Home\Hello.cshtml"
   Write(Html.ActionLink("На главную", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebMVCR1.Models.Person> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591