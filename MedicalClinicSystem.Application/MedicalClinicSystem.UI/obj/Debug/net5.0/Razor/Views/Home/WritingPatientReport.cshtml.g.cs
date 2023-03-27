#pragma checksum "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\Home\WritingPatientReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac47ca521be8a2e5ffe6ddb4321c433836971c89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WritingPatientReport), @"mvc.1.0.view", @"/Views/Home/WritingPatientReport.cshtml")]
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
#line 1 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\_ViewImports.cshtml"
using MedicalClinicSystem.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\_ViewImports.cshtml"
using MedicalClinicSystem.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\Home\WritingPatientReport.cshtml"
using MedicalClinicSystem.EF.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac47ca521be8a2e5ffe6ddb4321c433836971c89", @"/Views/Home/WritingPatientReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81cb0396c41e8ea95352e4a0239270208a0cd515", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_WritingPatientReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MedicalRecordVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("WritingPatientReport"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral(@"


<div class=""container-xxl flex-grow-1 container-p-y"">
    <div class=""card mb-4"">
        <h5 class=""card-header"">إضافة تقرير طبي   </h5>
        <hr class=""my-0"" />
        <div class=""card-body"">
            <div id=""dropDownListdiv"">
              
                <div class=""row"">
                    <h1> بيانات المريض</h1>
                    <br />
                    <hr />
                    <div class=""col-md-6 mb-3"">
                        <div class=""form-group"">
                            <label class=""form-label""> رقم المريض</label>
                            <input type=""text""
                                   class=""form-control text-center""
                                   disabled");
            BeginWriteAttribute("value", "\r\n                                   value=\"", 804, "\"", 864, 1);
#nullable restore
#line 24 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\Home\WritingPatientReport.cshtml"
WriteAttributeValue("", 848, Model.IdPatient, 848, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                           
                        </div>
                    </div>
                    <div class=""col-md-6 mb-3"">
                        <div class=""form-group"">
                            <label class=""form-label""> الاسم</label>
                            <input type=""text""
                                   class=""form-control text-center""
                                   disabled");
            BeginWriteAttribute("value", "\r\n                                   value=\"", 1288, "\"", 1351, 1);
#nullable restore
#line 34 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\Home\WritingPatientReport.cshtml"
WriteAttributeValue(" ", 1332, Model.PatientName, 1333, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""col-md-6 mb-3"">
                        <div class=""form-group"">
                            <label class=""form-label""> العمر</label>
                            <input type=""text""
                                   class=""form-control text-center""
                                   disabled");
            BeginWriteAttribute("value", "\r\n                                   value=\"", 1746, "\"", 1808, 1);
#nullable restore
#line 43 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\Home\WritingPatientReport.cshtml"
WriteAttributeValue(" ", 1790, Model.AgePatient, 1791, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""col-md-6 mb-3"">
                        <div class=""form-group"">
                            <label class=""form-label""> الجنس</label>
                            <input type=""text""
                                   class=""form-control text-center""
                                   disabled");
            BeginWriteAttribute("value", "\r\n                                   value=\"", 2203, "\"", 2268, 1);
#nullable restore
#line 52 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\Home\WritingPatientReport.cshtml"
WriteAttributeValue(" ", 2247, Model.PatientGender, 2248, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""col-md-6 mb-3"">
                        <div class=""form-group"">
                            <label class=""form-label""> تاريخ القدوم</label>
                            <input type=""text""
                                   class=""form-control text-center""
                                   disabled");
            BeginWriteAttribute("value", "\r\n                                   value=\"", 2670, "\"", 2736, 2);
#nullable restore
#line 61 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\Home\WritingPatientReport.cshtml"
WriteAttributeValue(" ", 2714, Model.PatientGender, 2715, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2735, "]", 2735, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac47ca521be8a2e5ffe6ddb4321c433836971c899266", async() => {
                WriteLiteral(@"

                        <div class=""col-md-6 mb-3"">
                            <div class=""form-group"">
                                <label class=""form-label""> نتائج التحليل</label>
                                <input name=""testResults"" class=""form-control"" type=""text"" placeholder=""نتائج التحليل"" autofocus />
                            </div>
                        </div>

                        <div class=""col-md-6 mb-3"">
                            <div class=""form-group"">
                                <label class=""form-label"">  التشخيص</label>
                                <input name=""diagnosi"" class=""form-control"" type=""text"" placeholder="" التشخيص"" autofocus />
                            </div>
                        </div>

                        ");
#nullable restore
#line 83 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\Home\WritingPatientReport.cshtml"
                   Write(Html.HiddenFor(model => model.IdPatient));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 84 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\Home\WritingPatientReport.cshtml"
                   Write(Html.HiddenFor(model => model.AgePatient));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


                        <div class=""col-md-6 mb-3"">
                            <div class=""form-group"">
                                <label class=""form-label"">الادوية المصروفة </label>
                                <input name=""rescriptionMedications"" class=""form-control"" type=""text"" placeholder=""الادوية المصروفة"" autofocus />

                            </div>
                        </div>
                        <div class=""col-md-6 mb-3"">
                            <div class=""form-group"">
                                <label class=""form-label"">  ملاحظة</label>
                                <input name=""not"" class=""form-control"" type=""text"" placeholder=""إضافة ملاحظة"" autofocus />

                            </div>
                        </div>
                        <hr />
                        <hr />


                        <div class=""mt-2"">
                            <button type=""submit"" value=""addRepot"" class=""btn btn-primary me-2"">إضافة تقرير </button>
 ");
                WriteLiteral("                           <button type=\"reset\" class=\"btn btn-label-secondary\">إلغاء</button>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n        </div>\r\n\r\n        <!-- / Content -->\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MedicalRecordVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
