#pragma checksum "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1e2788db4ff5c250ebae3d9f7ad2e16157c93371f767e3f6bd48bcf08e09731c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\_ViewImports.cshtml"
using CRUD_Operation_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\_ViewImports.cshtml"
using CRUD_Operation_App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\_ViewImports.cshtml"
using CRUD_Operation_App.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\_ViewImports.cshtml"
using CRUD.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\_ViewImports.cshtml"
using CRUD.BLL.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1e2788db4ff5c250ebae3d9f7ad2e16157c93371f767e3f6bd48bcf08e09731c", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4c2132340536e02d4afa7dfef356363255aae33654ccaddf77eae0468116f66e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row col-8 offset-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Buttonspartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
 if (!string.IsNullOrEmpty(TempData["Message"] as string))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary\">\r\n        ");
#nullable restore
#line 10 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
   Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 12 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Employees</h1>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e2788db4ff5c250ebae3d9f7ad2e16157c93371f767e3f6bd48bcf08e09731c8356", async() => {
                WriteLiteral("Create New Employee");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<div class=\"mt-3 row justify-content-center align-items-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e2788db4ff5c250ebae3d9f7ad2e16157c93371f767e3f6bd48bcf08e09731c9921", async() => {
                WriteLiteral(@"
        <div class=""col-8"">
            <input type=""text"" class=""form-control"" name=""searchInp"" id=""searchInp"" placeholder=""Search By Name"" />
        </div>
        <div class=""col-4"">
            <input type=""submit"" value=""Search"" class=""btn btn-success"" />
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<br />\r\n\r\n");
#nullable restore
#line 30 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"table-container\">\r\n        <table class=\"mt-3 table table-striped table-hover text-center\">\r\n            <thead>\r\n                <tr>\r\n                    <th class=\"nowrap\">");
#nullable restore
#line 36 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                                  Write(Html.DisplayNameFor(E => E.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"nowrap\">");
#nullable restore
#line 37 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                                  Write(Html.DisplayNameFor(E => E.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"nowrap\">");
#nullable restore
#line 38 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                                  Write(Html.DisplayNameFor(E => E.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"nowrap\">");
#nullable restore
#line 39 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                                  Write(Html.DisplayNameFor(E => E.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"nowrap\">");
#nullable restore
#line 40 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                                  Write(Html.DisplayNameFor(E => E.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"nowrap\">");
#nullable restore
#line 41 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                                  Write(Html.DisplayNameFor(E => E.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"nowrap\">");
#nullable restore
#line 42 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                                  Write(Html.DisplayNameFor(E => E.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"nowrap\">");
#nullable restore
#line 43 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                                  Write(Html.DisplayNameFor(E => E.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"nowrap\">");
#nullable restore
#line 44 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                                  Write(Html.DisplayNameFor(E => E.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"nowrap\">");
#nullable restore
#line 45 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                                  Write(Html.DisplayNameFor(E => E.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"nowrap\">Details</th>\r\n                    <th class=\"nowrap\">Update</th>\r\n                    <th class=\"nowrap\">Delete</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 52 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                 foreach (var employee in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 55 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                       Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e2788db4ff5c250ebae3d9f7ad2e16157c93371f767e3f6bd48bcf08e09731c16609", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2241, "~/Files/Images/", 2241, 15, true);
#nullable restore
#line 57 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
AddHtmlAttributeValue("", 2256, employee.ImageName, 2256, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 59 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                       Write(employee.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 60 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                       Write(employee.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 61 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                       Write(employee.Department?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 62 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                       Write(Html.DisplayFor(M => employee.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 64 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                             if (employee.IsActive)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fas fa-circle text-success\"></i>\r\n");
#nullable restore
#line 67 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fas fa-circle text-danger\"></i>\r\n");
#nullable restore
#line 71 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>");
#nullable restore
#line 73 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                       Write(Html.DisplayFor(M => employee.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 74 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                       Write(employee.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 75 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                       Write(employee.HireDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e2788db4ff5c250ebae3d9f7ad2e16157c93371f767e3f6bd48bcf08e09731c21667", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 76 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = employee.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </tr>\r\n");
#nullable restore
#line 78 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 82 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mt-4 alert alert-warning\">\r\n        <h3>There are No Employees</h3>\r\n    </div>\r\n");
#nullable restore
#line 88 "D:\El-asdekaa\Documents\Projects\CRUD_Operation_App-Solution\CRUD_Operation_App\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .table-container {
        display: flex;
        justify-content: center;
        margin: 0 auto;
    }

        .table-container .table {
            margin: 0 auto;
            width: 100%;
            max-width: 1000px;
        }

    .table th, .table td {
        text-align: center;
        vertical-align: middle;
    }

    .nowrap {
        white-space: nowrap;
    }
</style>

<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css"">














");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
