#pragma checksum "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fff0792c848ddcc9c3f57e4f2bf4e74259de91c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FiyatListeleri), @"mvc.1.0.view", @"/Views/Home/FiyatListeleri.cshtml")]
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
#line 1 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\_ViewImports.cshtml"
using web_odev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\_ViewImports.cshtml"
using web_odev.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff0792c848ddcc9c3f57e4f2bf4e74259de91c4", @"/Views/Home/FiyatListeleri.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cedf776fd8d39f5c28937e4031c4a7b80cc4f5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FiyatListeleri : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Arac>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
  
    ViewData["Title"] = "FiyatListeleri";
    Layout = "~/Views/Shared/Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"typo\">\r\n    <div class=\"container\">\r\n        <div class=\"typo-title\">\r\n            <h3>");
#nullable restore
#line 12 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
           Write(localizer["BİNEK ARAÇ FİYATLARI"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"grid_3 grid_4 w3_agileits_icons_page\">\r\n            <h3 class=\"agileits-icons-title\">");
#nullable restore
#line 15 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                                        Write(localizer["İlgilendiğiniz model için aşağıdaki binek otomobil fiyat listesini inceleyebilirsiniz."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"container\">\r\n            <div class=\"bs-docs-example\">\r\n                <table class=\"table table-striped\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th>");
#nullable restore
#line 22 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                           Write(localizer["Marka"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 23 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                           Write(localizer["Model"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 24 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                           Write(localizer["Donanım"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 25 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                           Write(localizer["Motor Hacmi"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 26 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                           Write(localizer["Yakıt"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 27 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                           Write(localizer["Vites"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>Hp</th>\r\n                            <th>");
#nullable restore
#line 29 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                           Write(localizer["Fiyat"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 36 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                               Write(item.Marka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                               Write(item.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                               Write(item.Donanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                               Write(item.Motor_hacmi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                               Write(localizer[@item.Yakit_tipi]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                               Write(localizer[@item.Vites_tipi]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                               Write(item.AracBg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                               Write(item.Fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 45 "C:\Users\akyol61\source\repos\web_odev\web_odev\Views\Home\FiyatListeleri.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Arac>> Html { get; private set; }
    }
}
#pragma warning restore 1591