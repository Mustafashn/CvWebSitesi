#pragma checksum "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Skills.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1c06de96870946c7cc10e292340d86f8ff467d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Skills), @"mvc.1.0.view", @"/Views/Admin/Skills.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c06de96870946c7cc10e292340d86f8ff467d6", @"/Views/Admin/Skills.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e60d3be31306e25659dd50712731651d7ff08f37", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Skills : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/SkillDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Skills.cshtml"
  
    Layout = "_AdminLayout";
    string progressColor="";
    string badgeColor ="";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br>
<div class=""wrapper"">
<!-- Navbar -->
    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h3 class=""card-title"">Yetenek Listem</h3>
                        </div>
                        <!-- /.card-header -->
                        <div class=""card-body"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th style=""width: 10px"">#</th>
                                        <th>Task</th>
                                        <th>Progress</th>
                                        <th style=""width: 40px"">Label</th>
                                        <th style=""width: 200px""></th>
                                ");
            WriteLiteral("    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Skills.cshtml"
                                     for(int i=0; i<Model.Count;i++) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n");
#nullable restore
#line 35 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Skills.cshtml"
                                             if (Model[i].Perfection<50){
                                                progressColor="bg-danger";
                                                badgeColor="bg-danger";
                                            }
                                            else if (Model[i].Perfection<75) {
                                                progressColor="bg-warning";
                                                badgeColor="bg-warning";
                                            }
                                            else {
                                                progressColor="bg-success";
                                                badgeColor="bg-success";
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 47 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Skills.cshtml"
                                        Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 48 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Skills.cshtml"
                                       Write(Model[i].SkillName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <div class=\"progress progress-xs\">\r\n                                                <div");
            BeginWriteAttribute("class", " class=\"", 2455, "\"", 2490, 2);
            WriteAttributeValue("", 2463, "progress-bar", 2463, 12, true);
#nullable restore
#line 51 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Skills.cshtml"
WriteAttributeValue(" ", 2475, progressColor, 2476, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 2491, "\"", 2527, 3);
            WriteAttributeValue("", 2499, "width:", 2499, 6, true);
#nullable restore
#line 51 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Skills.cshtml"
WriteAttributeValue(" ", 2505, Model[i].Perfection, 2506, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2526, "%", 2526, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                            </div>\r\n                                        </td>\r\n                                        <td><span");
            BeginWriteAttribute("class", " class=\"", 2685, "\"", 2710, 2);
            WriteAttributeValue("", 2693, "badge", 2693, 5, true);
#nullable restore
#line 54 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Skills.cshtml"
WriteAttributeValue(" ", 2698, badgeColor, 2699, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 54 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Skills.cshtml"
                                                                       Write(Model[i].Perfection);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span></td>\r\n                                        <td>\r\n                                            <div class=\"d-grid gap-1 d-md-block\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1c06de96870946c7cc10e292340d86f8ff467d69847", async() => {
                WriteLiteral("\r\n                                                            <input type=\"hidden\" name=\"SkillId\"");
                BeginWriteAttribute("value", " value=\"", 3092, "\"", 3117, 1);
#nullable restore
#line 58 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Skills.cshtml"
WriteAttributeValue("", 3100, Model[i].SkillId, 3100, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                            <button type=""submit"" class=""btn btn-danger"">
                                                                <i class=""fas fa-trash""></i>Delete</button>
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
            WriteLiteral("\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 3444, "\"", 3485, 2);
            WriteAttributeValue("", 3451, "/admin/SkillEdit/", 3451, 17, true);
#nullable restore
#line 62 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Skills.cshtml"
WriteAttributeValue("", 3468, Model[i].SkillId, 3468, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-warning"">
                                                <i class=""fas fa-pencil-alt""></i>Edit</a>
                                                
                                            </div>
                                        </td>
                                    </tr>
");
#nullable restore
#line 68 "C:\Users\musta\Documents\UdemyWebProgramlama\CvWeb\cv.webui\Views\Admin\Skills.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                    <a href=""/admin/SkillAdd"" class=""btn btn-primary"">Add Skill</a>

                    <!-- /.card -->
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>
    <!-- /.content -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; }
    }
}
#pragma warning restore 1591
