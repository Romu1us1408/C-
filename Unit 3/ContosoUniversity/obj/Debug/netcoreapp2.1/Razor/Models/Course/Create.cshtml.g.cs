#pragma checksum "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Course\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f09edc5b7afac5c6bbf16fb05c9050093f53198d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Models_Course_Create), @"mvc.1.0.razor-page", @"/Models/Course/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Models/Course/Create.cshtml", typeof(AspNetCore.Models_Course_Create), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f09edc5b7afac5c6bbf16fb05c9050093f53198d", @"/Models/Course/Create.cshtml")]
    public class Models_Course_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Course\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(103, 1593, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>Course</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Course.CourseID"" class=""control-label""></label>
                <input asp-for=""Course.CourseID"" class=""form-control"" />
                <span asp-validation-for=""Course.CourseID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Course.Title"" class=""control-label""></label>
                <input asp-for=""Course.Title"" class=""form-control"" />
                <span asp-validation-for=""Course.Title"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Course.Credits"" class=""control-label""></label>
                <input asp-for=""Course.Credits"" class=""form-control"" />
                <span asp-validation-");
            WriteLiteral(@"for=""Course.Credits"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Course.DepartmentID"" class=""control-label""></label>
                <select asp-for=""Course.DepartmentID"" class =""form-control"" asp-items=""ViewBag.DepartmentID""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1714, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 47 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Course\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity.Models.Course.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Models.Course.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Models.Course.CreateModel>)PageContext?.ViewData;
        public ContosoUniversity.Models.Course.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591