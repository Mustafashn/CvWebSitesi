#pragma checksum "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Certificates.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be774b21a4cd80ebf3074d3ce173fd493f1aadf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Certificates), @"mvc.1.0.view", @"/Views/Admin/Certificates.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be774b21a4cd80ebf3074d3ce173fd493f1aadf9", @"/Views/Admin/Certificates.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e60d3be31306e25659dd50712731651d7ff08f37", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Certificates : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Certification>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/CertificateDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Certificates.cshtml"
  
Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br>
<div class=""container"">
    <section class=""content"">
    <div class=""container-fluid"">
        <div class=""row""> 
            <!-- /.col -->
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-body"">
                            <div class=""tab-pane"" id=""timeline"">
");
#nullable restore
#line 15 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Certificates.cshtml"
                                 foreach(var certificate in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"timeline timeline-inverse\">\r\n                                        <div class=\"time-label\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 656, "\"", 714, 2);
            WriteAttributeValue("", 663, "/admin/CertificateEdit/", 663, 23, true);
#nullable restore
#line 18 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Certificates.cshtml"
WriteAttributeValue("", 686, certificate.CertificationId, 686, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-sm\">\r\n                                                ");
#nullable restore
#line 19 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Certificates.cshtml"
                                            Write(((DateTime)certificate.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </a>
                                            
                                        </div>
                                        <div>
                                            <div class=""timeline-item"">
                                                <div class=""timeline-body"">
                                                    <div class=""d-flex justify-content-between"">
                                                        ");
#nullable restore
#line 27 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Certificates.cshtml"
                                                   Write(certificate.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be774b21a4cd80ebf3074d3ce173fd493f1aadf97041", async() => {
                WriteLiteral("\r\n                                                        <input type=\"hidden\" name=\"CertificationId\"");
                BeginWriteAttribute("value", " value=\"", 1605, "\"", 1641, 1);
#nullable restore
#line 29 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Certificates.cshtml"
WriteAttributeValue("", 1613, certificate.CertificationId, 1613, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                        <button type=""submit"" class=""btn btn-danger btn-sm"">
                                                            <i class=""fas fa-trash ""></i></button>
                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                    </div>
                                                </div>
                                            </div>
                                        </div>      
                                    </div>
");
#nullable restore
#line 38 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Certificates.cshtml"
                                    
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                
                            </div>
                    <a href=""/admin/certificateAdd"" class=""btn btn-info"">Add Certification</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Certification>> Html { get; private set; }
    }
}
#pragma warning restore 1591
