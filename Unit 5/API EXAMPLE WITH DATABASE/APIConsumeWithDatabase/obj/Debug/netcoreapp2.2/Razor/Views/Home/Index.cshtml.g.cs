#pragma checksum "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 5\API EXAMPLE WITH DATABASE\APIConsumeWithDatabase\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81b3ded327343f8fbb6b8550360904e3b51e2958"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 5\API EXAMPLE WITH DATABASE\APIConsumeWithDatabase\Views\_ViewImports.cshtml"
using APIConsumeWithDatabase;

#line default
#line hidden
#line 2 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 5\API EXAMPLE WITH DATABASE\APIConsumeWithDatabase\Views\_ViewImports.cshtml"
using APIConsumeWithDatabase.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81b3ded327343f8fbb6b8550360904e3b51e2958", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cf994543cf5db664d631a9dabafb6b3973eb2e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reservation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddReservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetReservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateReservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteReservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 5\API EXAMPLE WITH DATABASE\APIConsumeWithDatabase\Views\Home\Index.cshtml"
   Layout = "_Layout"; ViewBag.Title = "All Reservations";

#line default
#line hidden
            BeginContext(94, 31, true);
            WriteLiteral("\r\n\r\n<h2>All Reservations</h2>\r\n");
            EndContext();
            BeginContext(125, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81b3ded327343f8fbb6b8550360904e3b51e29586195", async() => {
                BeginContext(187, 15, true);
                WriteLiteral("Add Reservation");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(206, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(208, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81b3ded327343f8fbb6b8550360904e3b51e29587657", async() => {
                BeginContext(272, 15, true);
                WriteLiteral("Get Reservation");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(291, 208, true);
            WriteLiteral("\r\n<table class=\"table table-sm table-striped table-bordered m-2\">\r\n    <thead><tr><th>ID</th><th>Name</th><th>Start Location</th><th>End Location</th><th>Update</th><th>Delete</th></tr></thead>\r\n    <tbody>\r\n");
            EndContext();
#line 11 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 5\API EXAMPLE WITH DATABASE\APIConsumeWithDatabase\Views\Home\Index.cshtml"
         foreach (var r in Model)
        {

#line default
#line hidden
            BeginContext(545, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(584, 4, false);
#line 14 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 5\API EXAMPLE WITH DATABASE\APIConsumeWithDatabase\Views\Home\Index.cshtml"
               Write(r.Id);

#line default
#line hidden
            EndContext();
            BeginContext(588, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(616, 6, false);
#line 15 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 5\API EXAMPLE WITH DATABASE\APIConsumeWithDatabase\Views\Home\Index.cshtml"
               Write(r.Name);

#line default
#line hidden
            EndContext();
            BeginContext(622, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(650, 15, false);
#line 16 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 5\API EXAMPLE WITH DATABASE\APIConsumeWithDatabase\Views\Home\Index.cshtml"
               Write(r.StartLocation);

#line default
#line hidden
            EndContext();
            BeginContext(665, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(693, 13, false);
#line 17 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 5\API EXAMPLE WITH DATABASE\APIConsumeWithDatabase\Views\Home\Index.cshtml"
               Write(r.EndLocation);

#line default
#line hidden
            EndContext();
            BeginContext(706, 167, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <!--Use below to use HTTPPut, which requires all fields to be changed (complete replacement) -->\r\n                    ");
            EndContext();
            BeginContext(873, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81b3ded327343f8fbb6b8550360904e3b51e295811488", async() => {
                BeginContext(928, 28, true);
                WriteLiteral("<img src=\"/icon/edit.png\" />");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 5\API EXAMPLE WITH DATABASE\APIConsumeWithDatabase\Views\Home\Index.cshtml"
                                                        WriteLiteral(r.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(960, 181, true);
            WriteLiteral("\r\n                    <!--Use below to use HTTPPatch, which allows individual fields to be changed -->\r\n                    <!--<a asp-action=\"UpdateReservationPatch\" asp-route-id=\"");
            EndContext();
            BeginContext(1142, 4, false);
#line 22 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 5\API EXAMPLE WITH DATABASE\APIConsumeWithDatabase\Views\Home\Index.cshtml"
                                                                        Write(r.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1146, 104, true);
            WriteLiteral("\"><img src=\"/icon/edit.png\" /></a>-->\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1250, 234, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81b3ded327343f8fbb6b8550360904e3b51e295814645", async() => {
                BeginContext(1301, 46, true);
                WriteLiteral("\r\n                        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1347, "\"", 1360, 1);
#line 26 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 5\API EXAMPLE WITH DATABASE\APIConsumeWithDatabase\Views\Home\Index.cshtml"
WriteAttributeValue("", 1355, r.Id, 1355, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1361, 116, true);
                WriteLiteral(" name=\"ReservationId\" />\r\n                        <input type=\"image\" src=\"/icon/close.png\" />\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1484, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "C:\Users\ldmat\OneDrive\Documents\IndianHills\Win19\C#\Unit 5\API EXAMPLE WITH DATABASE\APIConsumeWithDatabase\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1539, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
