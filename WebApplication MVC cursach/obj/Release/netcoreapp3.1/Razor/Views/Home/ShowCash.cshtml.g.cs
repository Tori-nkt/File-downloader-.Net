#pragma checksum "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecd3814d2f89dc54a832d83ad095386559dd2478"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowCash), @"mvc.1.0.view", @"/Views/Home/ShowCash.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecd3814d2f89dc54a832d83ad095386559dd2478", @"/Views/Home/ShowCash.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e41db46591b793943de7b158d49876ecfc50b510", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowCash : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApplication_MVC_cursach.Models.Result>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
   Html.RenderPartial("Privacy"); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info\" role=\"alert\">\r\n        Тут могло б бути щось цікаве..\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
     if (Model[0].ModelType == "video")
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                <script type=\"text/javascript\" src=\"//s3.spruto.com/embed/player.js\"></script>\r\n                <script class=\"splayer\">var params = { \"playlist\": [{ \"title\": \"\", \"posterUrl\": \"\", \"video\": [{ \"url\": \"");
#nullable restore
#line 23 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
                                                                                                                   Write(item.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" }], \"duration\": 0 }], \"uiLanguage\": \"ru\", \"width\": \"320\", \"height\": \"180\" }; player.embed(params);</script>\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 742, "\"", 759, 1);
#nullable restore
#line 25 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
WriteAttributeValue("", 749, item.Link, 749, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:blue\">");
#nullable restore
#line 25 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n                <span style=\"font-size:15px;color:green\">");
#nullable restore
#line 26 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
                                                    Write(item.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                <span style=\"color:gray;\">");
#nullable restore
#line 27 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
                                     Write(item.Snippet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                <script type=\"text/javascript\" src=\"//s3.spruto.com/embed/player.js\"></script>\r\n            </div>\r\n");
#nullable restore
#line 31 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
         
    }
    else if (Model[0].ModelType == "audio")
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                <script type=\"text/javascript\" src=\"//s3.spruto.com/embed/player.js\"></script>\r\n                <script class=\"splayer\">var params = { \"playlist\": [{ \"title\": \"\", \"posterUrl\": \"\", \"video\": [{ \"url\": \"");
#nullable restore
#line 39 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
                                                                                                                   Write(item.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" }], \"duration\": 0 }], \"uiLanguage\": \"ru\", \"width\": \"320\", \"height\": \"180\" }; player.embed(params);</script>\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1575, "\"", 1592, 1);
#nullable restore
#line 41 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
WriteAttributeValue("", 1582, item.Link, 1582, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:blue\">");
#nullable restore
#line 41 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n                <span style=\"font-size:15px;color:green\">");
#nullable restore
#line 42 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
                                                    Write(item.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                <span style=\"color:gray;\">");
#nullable restore
#line 43 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
                                     Write(item.Snippet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                <script type=\"text/javascript\" src=\"//s3.spruto.com/embed/player.js\"></script>\r\n\r\n            </div>\r\n");
#nullable restore
#line 48 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-columns\">\r\n");
#nullable restore
#line 53 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\">\r\n\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2113, "\"", 2128, 1);
#nullable restore
#line 57 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
WriteAttributeValue("", 2119, item.Img, 2119, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:250px\" alt=\"Card image cap\">\r\n                    <div class=\"card-body\">\r\n                        <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 59 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
                                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                        <button type=\"button\" class=\"btn btn-outline-primary\" data-toggle=\"modal\" data-target=\".bd-example-modal-lg-");
#nullable restore
#line 60 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
                                                                                                                               Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">відкрити фото</button>\r\n\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 2510, "\"", 2557, 4);
            WriteAttributeValue("", 2518, "modal", 2518, 5, true);
            WriteAttributeValue(" ", 2523, "fade", 2524, 5, true);
            WriteAttributeValue(" ", 2528, "bd-example-modal-lg-", 2529, 21, true);
#nullable restore
#line 62 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
WriteAttributeValue("", 2549, item.id, 2549, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
                            <div class=""modal-dialog modal-lg"">
                                <div class=""modal-content"">
                                    <img class=""card-img-top""");
            BeginWriteAttribute("src", " src=\"", 2831, "\"", 2846, 1);
#nullable restore
#line 65 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
WriteAttributeValue("", 2837, item.Img, 2837, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:1000px\" alt=\"Card image cap\">\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 71 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 74 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\vikyc\source\repos\WebApplication MVC cursach\WebApplication MVC cursach\Views\Home\ShowCash.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApplication_MVC_cursach.Models.Result>> Html { get; private set; }
    }
}
#pragma warning restore 1591