#pragma checksum "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b185026556bcff0dd20758c87546e1d3824e2062"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TaskGaps), @"mvc.1.0.view", @"/Views/Home/TaskGaps.cshtml")]
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
#line 1 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\_ViewImports.cshtml"
using SicariosSA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\_ViewImports.cshtml"
using SicariosSA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b185026556bcff0dd20758c87546e1d3824e2062", @"/Views/Home/TaskGaps.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a540da3b58f357807c20263a351be563ae46c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TaskGaps : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SicariosSA.ViewModels.TasksGapsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TaskGaps", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RandomTask", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
  
    ViewData["Title"] = "Zadanie z lukami";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
 if (ViewBag.Standard == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <center>\r\n        <h2>Egzamin 8 klasisty - Angielski</h2>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b185026556bcff0dd20758c87546e1d3824e20624654", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
             foreach (var task in Model.TaskGaps)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"container\">\r\n                    <div class=\"row border\">\r\n                        <div class=\"col-sm-12 border\">\r\n                            <h4>");
#nullable restore
#line 16 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                           Write(task.TaskName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"col-sm-12 border\">\r\n                            <h5>");
#nullable restore
#line 19 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                           Write(task.TextToFill);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        </div>\r\n                        <div class=\"col-sm-12 border\">\r\n                            <h5>Wprowadź numer odpowiedzi w danym polu:</h5>\r\n                        </div>\r\n");
#nullable restore
#line 24 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                         foreach (var taskAnswer in task.PossibleAnswer)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-sm-12\">\r\n                                <input type=\"text\" id=\"answer\" name=\"answer\" />\r\n                                <input type=\"hidden\" id=\"answerText\" name=\"answerText\"");
                BeginWriteAttribute("value", " value=\"", 1177, "\"", 1211, 1);
#nullable restore
#line 28 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
WriteAttributeValue("", 1185, taskAnswer.PossibleAnswer, 1185, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <br />\r\n                                <h6>");
#nullable restore
#line 30 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                               Write(taskAnswer.PossibleAnswer);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                            </div>\r\n");
#nullable restore
#line 32 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 35 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Sprawdź odpowiedź\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </center>\r\n");
#nullable restore
#line 42 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
}
else if (ViewBag.False == false)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <center>\r\n        <h2>Egzamin 8 klasisty - Angielski</h2>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b185026556bcff0dd20758c87546e1d3824e20629878", async() => {
                WriteLiteral("\r\n            <div class=\"alert alert-danger\" role=\"alert\">\r\n                <b>Zła odpowiedź!</b>\r\n            </div>\r\n");
#nullable restore
#line 51 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
             foreach (var task in Model.TaskGaps)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"container\">\r\n                    <div class=\"row align-items-start border\">\r\n                        <div class=\"col-sm-12 border\">\r\n                            <h4>");
#nullable restore
#line 56 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                           Write(task.TaskName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"col-sm-12 border\">\r\n                            <h5>");
#nullable restore
#line 59 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                           Write(task.TextToFill);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        </div>\r\n");
#nullable restore
#line 61 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                         foreach (var taskAnswer in task.PossibleAnswer)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-sm-12\">\r\n                                <h6>");
#nullable restore
#line 64 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                               Write(taskAnswer.PossibleAnswer);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                            </div>\r\n                            <div class=\"col-sm-12\">\r\n                                <h6>");
#nullable restore
#line 67 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                               Write(taskAnswer.PossibleAnswerPl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                            </div>\r\n");
#nullable restore
#line 69 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"col-sm-12 border\">\r\n                            <h5><b>Wytłumaczenie</b></h5>\r\n                            <h6>");
#nullable restore
#line 72 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                           Write(task.Explanation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 76 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Kolejne zadanie\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </center>\r\n");
#nullable restore
#line 83 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
}
else if (ViewBag.Success == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <center>\r\n        <h2>Egzamin 8 klasisty - Angielski</h2>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b185026556bcff0dd20758c87546e1d3824e206215300", async() => {
                WriteLiteral("\r\n            <div class=\"alert alert-success\" role=\"alert\">\r\n                <b>Poprawna odpowiedź!</b>\r\n            </div>\r\n");
#nullable restore
#line 92 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
             foreach (var task in Model.TaskGaps)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"container\">\r\n                    <div class=\"row align-items-start border\">\r\n                        <div class=\"col-sm-12 border\">\r\n                            <h4>");
#nullable restore
#line 97 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                           Write(task.TaskName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"col-sm-12 border\">\r\n                            <h5>");
#nullable restore
#line 100 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                           Write(task.TextToFill);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        </div>\r\n");
#nullable restore
#line 102 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                         foreach (var taskAnswer in task.PossibleAnswer)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-sm-12\">\r\n                                <h6>");
#nullable restore
#line 105 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                               Write(taskAnswer.PossibleAnswer);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                            </div>\r\n                            <div class=\"col-sm-12\">\r\n                                <h6>");
#nullable restore
#line 108 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                               Write(taskAnswer.PossibleAnswerPl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                            </div>\r\n");
#nullable restore
#line 110 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"col-sm-12 border\">\r\n                            <h5><b>Wytłumaczenie</b></h5>\r\n                            <h6>");
#nullable restore
#line 113 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
                           Write(task.Explanation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 117 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Kolejne zadanie\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </center>\r\n");
#nullable restore
#line 124 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\TaskGaps.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SicariosSA.ViewModels.TasksGapsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
