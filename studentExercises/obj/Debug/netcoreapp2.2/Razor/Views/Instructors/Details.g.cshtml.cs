#pragma checksum "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\Instructors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f206ad95fa8884f627e7d71af00181e2da10237"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructors_Details), @"mvc.1.0.view", @"/Views/Instructors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instructors/Details.cshtml", typeof(AspNetCore.Views_Instructors_Details))]
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
#line 1 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\_ViewImports.cshtml"
using studentExercises;

#line default
#line hidden
#line 2 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\_ViewImports.cshtml"
using studentExercises.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f206ad95fa8884f627e7d71af00181e2da10237", @"/Views/Instructors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d14f88a7edc6bc825884e9df104cc9c3ce217894", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<studentExercises.Models.Instructor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\Instructors\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(88, 133, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Instructor</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(222, 38, false);
#line 14 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\Instructors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(260, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(324, 34, false);
#line 17 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\Instructors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(358, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(421, 45, false);
#line 20 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\Instructors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(466, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(530, 41, false);
#line 23 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\Instructors\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(571, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(634, 44, false);
#line 26 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\Instructors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(678, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(742, 40, false);
#line 29 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\Instructors\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(782, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(845, 47, false);
#line 32 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\Instructors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SlackHandle));

#line default
#line hidden
            EndContext();
            BeginContext(892, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(956, 43, false);
#line 35 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\Instructors\Details.cshtml"
       Write(Html.DisplayFor(model => model.SlackHandle));

#line default
#line hidden
            EndContext();
            BeginContext(999, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1062, 46, false);
#line 38 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\Instructors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Speciality));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1172, 42, false);
#line 41 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\Instructors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Speciality));

#line default
#line hidden
            EndContext();
            BeginContext(1214, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1277, 44, false);
#line 44 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\Instructors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CohortId));

#line default
#line hidden
            EndContext();
            BeginContext(1321, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1385, 40, false);
#line 47 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\Instructors\Details.cshtml"
       Write(Html.DisplayFor(model => model.CohortId));

#line default
#line hidden
            EndContext();
            BeginContext(1425, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1473, 67, false);
#line 52 "C:\Users\kenpe\source\repos\studentExercises\studentExercises\Views\Instructors\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /*id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1540, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1548, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f206ad95fa8884f627e7d71af00181e2da102379665", async() => {
                BeginContext(1570, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1586, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<studentExercises.Models.Instructor> Html { get; private set; }
    }
}
#pragma warning restore 1591
