#pragma checksum "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Course\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8668d79446070ac40a9c506f029a7356abc02a74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Models_Course_Edit), @"mvc.1.0.razor-page", @"/Models/Course/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Models/Course/Edit.cshtml", typeof(AspNetCore.Models_Course_Edit), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8668d79446070ac40a9c506f029a7356abc02a74", @"/Models/Course/Edit.cshtml")]
    public class Models_Course_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Course\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(99, 1444, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Course</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Course.CourseID"" />
            <div class=""form-group"">
                <label asp-for=""Course.Title"" class=""control-label""></label>
                <input asp-for=""Course.Title"" class=""form-control"" />
                <span asp-validation-for=""Course.Title"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Course.Credits"" class=""control-label""></label>
                <input asp-for=""Course.Credits"" class=""form-control"" />
                <span asp-validation-for=""Course.Credits"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Course.DepartmentID"" class=""control-label""></label>
                <select asp-for=""Course.Departm");
            WriteLiteral(@"entID"" class=""form-control"" asp-items=""ViewBag.DepartmentID""></select>
                <span asp-validation-for=""Course.DepartmentID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""./Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1561, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 44 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Course\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity.Models.Course.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Models.Course.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Models.Course.EditModel>)PageContext?.ViewData;
        public ContosoUniversity.Models.Course.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
