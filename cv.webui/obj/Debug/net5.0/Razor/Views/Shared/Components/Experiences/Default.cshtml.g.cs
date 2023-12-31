#pragma checksum "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Shared\Components\Experiences\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a2716043e13b538208b5059d7a5236b0a3bc66e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Experiences_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Experiences/Default.cshtml")]
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
#line 1 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\_ViewImports.cshtml"
using cv.entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\_ViewImports.cshtml"
using cv.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a2716043e13b538208b5059d7a5236b0a3bc66e", @"/Views/Shared/Components/Experiences/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e60d3be31306e25659dd50712731651d7ff08f37", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Experiences_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"resume-section\" id=\"experience\">\r\n    <div class=\"resume-section-content\">\r\n        <h2 class=\"mb-5\">Experience</h2>\r\n");
#nullable restore
#line 5 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Shared\Components\Experiences\Default.cshtml"
         if(Model.Count() == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"d-flex flex-column flex-md-row justify-content-between mb-5\">\r\n                <p>I have no job experience. I am open to opportunities.</p>\r\n            </div>\r\n");
#nullable restore
#line 9 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Shared\Components\Experiences\Default.cshtml"
        }
        else {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Shared\Components\Experiences\Default.cshtml"
             foreach (var experience in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"d-flex flex-column flex-md-row justify-content-between mb-5\">\r\n                <div class=\"flex-grow-1\">\r\n                    <h3 class=\"mb-0\">");
#nullable restore
#line 14 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Shared\Components\Experiences\Default.cshtml"
                                Write(experience.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"subheading mb-3\">");
#nullable restore
#line 15 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Shared\Components\Experiences\Default.cshtml"
                                            Write(experience.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <p>");
#nullable restore
#line 16 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Shared\Components\Experiences\Default.cshtml"
                  Write(experience.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"flex-shrink-0\"><span class=\"text-primary\">");
#nullable restore
#line 18 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Shared\Components\Experiences\Default.cshtml"
                                                                  Write(((DateTime)experience.FirstDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 18 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Shared\Components\Experiences\Default.cshtml"
                                                                                                                                Write(((DateTime)experience.LastDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n            </div>\r\n");
#nullable restore
#line 20 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Shared\Components\Experiences\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Shared\Components\Experiences\Default.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; }
    }
}
#pragma warning restore 1591
