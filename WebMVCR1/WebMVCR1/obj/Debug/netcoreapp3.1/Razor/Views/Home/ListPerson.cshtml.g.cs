#pragma checksum "C:\Users\shibanovi\source\repos\WebMVCR1\WebMVCR1\Views\Home\ListPerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1065e12853120da63aea4112574c2fefec15a41e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListPerson), @"mvc.1.0.view", @"/Views/Home/ListPerson.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1065e12853120da63aea4112574c2fefec15a41e", @"/Views/Home/ListPerson.cshtml")]
    #nullable restore
    public class Views_Home_ListPerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebMVCR1.Models.PersonRepository>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\shibanovi\source\repos\WebMVCR1\WebMVCR1\Views\Home\ListPerson.cshtml"
      
    ViewBag.Title = "Список пользователей";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h3>Список участников</h3>\r\n    <p>Персон всего ");
#nullable restore
#line 8 "C:\Users\shibanovi\source\repos\WebMVCR1\WebMVCR1\Views\Home\ListPerson.cshtml"
               Write(ViewBag.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <ul>\r\n");
#nullable restore
#line 10 "C:\Users\shibanovi\source\repos\WebMVCR1\WebMVCR1\Views\Home\ListPerson.cshtml"
         foreach (var c in ViewBag.pers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 12 "C:\Users\shibanovi\source\repos\WebMVCR1\WebMVCR1\Views\Home\ListPerson.cshtml"
           Write(c.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n");
#nullable restore
#line 13 "C:\Users\shibanovi\source\repos\WebMVCR1\WebMVCR1\Views\Home\ListPerson.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <p>\r\n        ");
#nullable restore
#line 16 "C:\Users\shibanovi\source\repos\WebMVCR1\WebMVCR1\Views\Home\ListPerson.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebMVCR1.Models.PersonRepository> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
