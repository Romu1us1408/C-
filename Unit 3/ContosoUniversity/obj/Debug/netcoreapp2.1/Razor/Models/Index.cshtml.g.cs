#pragma checksum "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eac69b6e1ec75912d6973413a1080754372f8b3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Models_Index), @"mvc.1.0.razor-page", @"/Models/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Models/Index.cshtml", typeof(AspNetCore.Models_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eac69b6e1ec75912d6973413a1080754372f8b3c", @"/Models/Index.cshtml")]
    public class Models_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(94, 156, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(251, 51, false);
#line 17 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Course[0].Title));

#line default
#line hidden
            EndContext();
            BeginContext(302, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(358, 53, false);
#line 20 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Course[0].Credits));

#line default
#line hidden
            EndContext();
            BeginContext(411, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(467, 56, false);
#line 23 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Course[0].Department));

#line default
#line hidden
            EndContext();
            BeginContext(523, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Index.cshtml"
 foreach (var item in Model.Course) {

#line default
#line hidden
            BeginContext(648, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(697, 40, false);
#line 32 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(737, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(793, 42, false);
#line 35 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Credits));

#line default
#line hidden
            EndContext();
            BeginContext(835, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(891, 58, false);
#line 38 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Department.DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(949, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-page=\"./Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1024, "\"", 1053, 1);
#line 41 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Index.cshtml"
WriteAttributeValue("", 1039, item.CourseID, 1039, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1054, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-page=\"./Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1106, "\"", 1135, 1);
#line 42 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Index.cshtml"
WriteAttributeValue("", 1121, item.CourseID, 1121, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1136, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-page=\"./Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1190, "\"", 1219, 1);
#line 43 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Index.cshtml"
WriteAttributeValue("", 1205, item.CourseID, 1205, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1220, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 46 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 3\ContosoUniversity\Models\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1270, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity.Models.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Models.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Models.IndexModel>)PageContext?.ViewData;
        public ContosoUniversity.Models.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
