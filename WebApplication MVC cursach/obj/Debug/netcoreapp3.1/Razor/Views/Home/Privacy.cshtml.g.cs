#pragma checksum "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "689f03d2eeaf0f0fb0852f816189e3380352abb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#nullable restore
#line 1 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\_ViewImports.cshtml"
using WebApplication_MVC_cursach;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\_ViewImports.cshtml"
using WebApplication_MVC_cursach.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"689f03d2eeaf0f0fb0852f816189e3380352abb5", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e41db46591b793943de7b158d49876ecfc50b510", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Завантажені файли";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\Privacy.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" name=\"action\" style=\"height: 40px; \" class=\"btn btn-link\">Назад</button>\r\n");
#nullable restore
#line 9 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\Privacy.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\Privacy.cshtml"
 using (Html.BeginForm("ShowCash", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <br />
    <button type=""submit"" name=""action"" style=""height: 40px; margin-right: 20px;"" class=""btn btn-outline-primary"" value=""video"">відео</button>
    <button type=""submit"" name=""action"" style=""height: 40px; margin-right: 20px;"" class=""btn btn-outline-primary"" value=""image"">фото</button>
    <button type=""submit"" name=""action"" style=""height: 40px; margin-right: 20px;"" class=""btn btn-outline-primary"" value=""audio"">аудіо</button>
");
#nullable restore
#line 17 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\Privacy.cshtml"
}

#line default
#line hidden
#nullable disable
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