#pragma checksum "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\User\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7f3c0b2baf7518f844f2182cd543595540e38ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Login), @"mvc.1.0.view", @"/Views/User/Login.cshtml")]
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
#line 2 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\User\Login.cshtml"
using MedicalClinicSystem.EF.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7f3c0b2baf7518f844f2182cd543595540e38ee", @"/Views/User/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81cb0396c41e8ea95352e4a0239270208a0cd515", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUser>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/User/Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\User\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html lang=\"ar\"\r\n      class=\"light-style customizer-hide\"\r\n      dir=\"rtl\"\r\n      data-theme=\"theme-default\"\r\n      data-assets-path=\"/assets/\"\r\n      data-template=\"vertical-menu-template\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7f3c0b2baf7518f844f2182cd543595540e38ee5698", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\"\r\n          content=\"width=device-width, initial-scale=1.0, user-scalable=no, minimum-scale=1.0, maximum-scale=1.0\" />\r\n\r\n    <title> نظام عيادة تسجيل الدخول </title>\r\n\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 567, "\"", 577, 0);
                EndWriteAttribute();
                WriteLiteral(@" />

    <!-- Favicon -->
    <link rel=""icon"" type=""image/x-icon"" href=""/assets/img/favicon/favicon.ico"" />

    <!-- Fonts -->
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"" />
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin />
    <link href=""https://fonts.googleapis.com/css2?family=IBM+Plex+Sans:ital,wght@0,300;0,400;0,500;0,600;0,700;1,300;1,400;1,500;1,600;1,700&family=Rubik:ital,wght@0,300;0,400;0,500;0,600;0,700;1,300;1,400;1,500;1,600;1,700&display=swap""
          rel=""stylesheet"" />

    <!-- Icons -->
    <link rel=""stylesheet"" href=""/assets/vendor/fonts/boxicons.css"" />
    <link rel=""stylesheet"" href=""/assets/vendor/fonts/fontawesome.css"" />
    <link rel=""stylesheet"" href=""/assets/vendor/fonts/flag-icons.css"" />

    <!-- Core CSS -->
    <link rel=""stylesheet"" href=""/assets/vendor/css/rtl/core.css"" class=""template-customizer-core-css"" />
    <link rel=""stylesheet"" href=""/assets/vendor/css/rtl/theme-default.css"" class=""template-customizer");
                WriteLiteral(@"-theme-css"" />
    <link rel=""stylesheet"" href=""/assets/css/demo.css"" />

    <!-- Vendors CSS -->
    <link rel=""stylesheet"" href=""/assets/vendor/libs/perfect-scrollbar/perfect-scrollbar.css"" />
    <link rel=""stylesheet"" href=""/assets/vendor/libs/typeahead-js/typeahead.css"" />
    <!-- Vendor -->
    <link rel=""stylesheet"" href=""/assets/vendor/libs/formvalidation/dist/css/formValidation.min.css"" />

    <!-- Page CSS -->
    <!-- Page -->
    <link rel=""stylesheet"" href=""/assets/vendor/css/pages/page-auth.css"" />
    <!-- Helpers -->
    <script src=""/assets/vendor/js/helpers.js""></script>

    <script src=""/assets/vendor/js/template-customizer.js""></script>
    <!--? Config:  Mandatory theme config file contain global vars & default theme options, Set your preferred theme option in this file.  -->
    <script src=""/assets/js/config.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7f3c0b2baf7518f844f2182cd543595540e38ee9105", async() => {
                WriteLiteral(@"
    <!-- Content -->
    <div class=""container-xxl"">
        <div class=""authentication-wrapper authentication-basic container-p-y"">
            <div class=""authentication-inner py-4"">
                <!-- Register -->
                <div class=""card"">
                    <div class=""card-body"">
                        <!-- Logo -->
                        <div class=""app-brand justify-content-center"">
                            <a href=""dashboards-analytics.html"" class=""app-brand-link gap-2"">
                                <span class=""app-brand-logo demo"">
                                    <svg width=""26px""
                                         height=""26px""
                                         viewBox=""0 0 26 26""
                                         version=""1.1""
                                         xmlns=""http://www.w3.org/2000/svg""
                                         xmlns:xlink=""http://www.w3.org/1999/xlink"">
                                        <title>icon");
                WriteLiteral(@"</title>
                                        <defs>
                                            <linearGradient x1=""50%"" y1=""0%"" x2=""50%"" y2=""100%"" id=""linearGradient-1"">
                                                <stop stop-color=""#5A8DEE"" offset=""0%""></stop>
                                                <stop stop-color=""#699AF9"" offset=""100%""></stop>
                                            </linearGradient>
                                            <linearGradient x1=""0%"" y1=""0%"" x2=""100%"" y2=""100%"" id=""linearGradient-2"">
                                                <stop stop-color=""#FDAC41"" offset=""0%""></stop>
                                                <stop stop-color=""#E38100"" offset=""100%""></stop>
                                            </linearGradient>
                                        </defs>
                                        <g id=""Pages"" stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                            ");
                WriteLiteral(@"<g id=""Login---V2"" transform=""translate(-667.000000, -290.000000)"">
                                                <g id=""Login"" transform=""translate(519.000000, 244.000000)"">
                                                    <g id=""Logo"" transform=""translate(148.000000, 42.000000)"">
                                                        <g id=""icon"" transform=""translate(0.000000, 4.000000)"">
                                                            <path d=""M13.8863636,4.72727273 C18.9447899,4.72727273 23.0454545,8.82793741 23.0454545,13.8863636 C23.0454545,18.9447899 18.9447899,23.0454545 13.8863636,23.0454545 C8.82793741,23.0454545 4.72727273,18.9447899 4.72727273,13.8863636 C4.72727273,13.5423509 4.74623858,13.2027679 4.78318172,12.8686032 L8.54810407,12.8689442 C8.48567157,13.19852 8.45300462,13.5386269 8.45300462,13.8863636 C8.45300462,16.887125 10.8856023,19.3197227 13.8863636,19.3197227 C16.887125,19.3197227 19.3197227,16.887125 19.3197227,13.8863636 C19.3197227,10.8856023 16.887125,8.453004");
                WriteLiteral(@"62 13.8863636,8.45300462 C13.5386269,8.45300462 13.19852,8.48567157 12.8689442,8.54810407 L12.8686032,4.78318172 C13.2027679,4.74623858 13.5423509,4.72727273 13.8863636,4.72727273 Z""
                                                                  id=""Combined-Shape""
                                                                  fill=""#4880EA""></path>
                                                            <path d=""M13.5909091,1.77272727 C20.4442608,1.77272727 26,7.19618701 26,13.8863636 C26,20.5765403 20.4442608,26 13.5909091,26 C6.73755742,26 1.18181818,20.5765403 1.18181818,13.8863636 C1.18181818,13.540626 1.19665566,13.1982714 1.22574292,12.8598734 L6.30410592,12.859962 C6.25499466,13.1951893 6.22958398,13.5378796 6.22958398,13.8863636 C6.22958398,17.8551125 9.52536149,21.0724191 13.5909091,21.0724191 C17.6564567,21.0724191 20.9522342,17.8551125 20.9522342,13.8863636 C20.9522342,9.91761479 17.6564567,6.70030817 13.5909091,6.70030817 C13.2336969,6.70030817 12.8824272,6.72514561 12.5388136,6.7731");
                WriteLiteral(@"4791 L12.5392575,1.81561642 C12.8859498,1.78721495 13.2366963,1.77272727 13.5909091,1.77272727 Z""
                                                                  id=""Combined-Shape2""
                                                                  fill=""url(#linearGradient-1)""></path>
                                                            <rect id=""Rectangle""
                                                                  fill=""url(#linearGradient-2)""
                                                                  x=""0""
                                                                  y=""0""
                                                                  width=""7.68181818""
                                                                  height=""7.68181818""></rect>
                                                        </g>
                                                    </g>
                                                </g>
                                            </g>
  ");
                WriteLiteral(@"                                      </g>
                                    </svg>
                                </span>
                                <span class=""app-brand-text demo h3 fw-bold mb-0""> عيادة الشفاء</span>
                            </a>
                        </div>
                        <!-- /Logo -->
                        <h4 class=""mb-2"">تسجيل الدخول 👋</h4>
");
#nullable restore
#line 119 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\User\Login.cshtml"
                         if (TempData["Error"] != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-md-12 alert alert-danger\">\r\n                                <span><b>عذرا</b> - ");
#nullable restore
#line 122 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\User\Login.cshtml"
                                               Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n                            </div>\r\n");
#nullable restore
#line 124 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\User\Login.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7f3c0b2baf7518f844f2182cd543595540e38ee16264", async() => {
                    WriteLiteral("\r\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7f3c0b2baf7518f844f2182cd543595540e38ee16563", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 127 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\User\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 128 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\User\Login.cshtml"
                                 if (@ViewBag.Message != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\User\Login.cshtml"
                               Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\User\Login.cshtml"
                                                    ;
                                }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"

                                <div class=""mb-3"">
                                    <label class=""form-label"">اسم المستخدم!</label>
                                    <input name=""userName"" type=""text""
                                           class=""form-control""
                                           placeholder=""اسم المستخدم او البريد الالكتروني "" />
                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7f3c0b2baf7518f844f2182cd543595540e38ee19645", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 139 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\User\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserName);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                </div>
                                <div class=""form-password-toggle mb-3"">
                                    <div class=""d-flex justify-content-between"">
                                        <label class=""form-label"" for=""password"">كلمة المرور !</label>
                                    </div>
                                    <div class=""input-group input-group-merge"">
                                        <input name=""password""
                                               type=""password""
                                               id=""password""
                                               class=""form-control""
                                               placeholder=""&#xb7;&#xb7;&#xb7;&#xb7;&#xb7;&#xb7;&#xb7;&#xb7;&#xb7;&#xb7;&#xb7;&#xb7;""
                                               aria-describedby=""password"" />
                                        <span class=""input-group-text cursor-pointer""><i class=""bx bx-hide""></i></span>
    ");
                    WriteLiteral("                                </div>\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7f3c0b2baf7518f844f2182cd543595540e38ee22553", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 154 "E:\My_GitHub\MedicalClinicSystem\MedicalClinicSystem.Application\MedicalClinicSystem.UI\Views\User\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Pass);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                </div>

                                <div class=""mb-3"">
                                    <button class=""btn btn-primary d-grid w-100"" type=""submit"">تسجيل </button>
                                </div>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                            <!-- /Register -->
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- / Content -->
    <!-- Core JS -->
    <!-- build:js assets/vendor/js/core.js -->
    <script src=""/assets/vendor/libs/jquery/jquery.js""></script>
    <script src=""/assets/vendor/libs/popper/popper.js""></script>
    <script src=""/assets/vendor/js/bootstrap.js""></script>
    <script src=""/assets/vendor/libs/perfect-scrollbar/perfect-scrollbar.js""></script>
    <script src=""/assets/vendor/libs/hammer/hammer.js""></script>
    <script src=""/assets/vendor/libs/i18n/i18n.js""></script>
    <script src=""/assets/vendor/libs/typeahead-js/typeahead.js""></script>

    <script src=""/assets/vendor/js/menu.js""></script>
    <!-- endbuild -->
    <!-- Vendors JS -->
    <script src=""/assets/vendor/libs/formvalidation/dist/js/FormValidation.min.js""></script>
    <script src=""/assets/vendor/libs/formvalidation/dist/js/plugins/Bootstrap5.min.js""></scrip");
                WriteLiteral("t>\r\n    <script src=\"/assets/vendor/libs/formvalidation/dist/js/plugins/AutoFocus.min.js\"></script>\r\n\r\n    <!-- Main JS -->\r\n    <script src=\"/assets/js/main.js\"></script>\r\n\r\n    <!-- Page JS -->\r\n    <script src=\"/assets/js/pages-auth.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUser> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591