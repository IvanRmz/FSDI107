#pragma checksum "F:\myCalendar\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90ce43bd1dce04dc5208a3d0ca0650afd1d6ffb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "F:\myCalendar\Views\_ViewImports.cshtml"
using myCalendar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\myCalendar\Views\_ViewImports.cshtml"
using myCalendar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ce43bd1dce04dc5208a3d0ca0650afd1d6ffb6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2abcf888c2739078333327bef060c7866b9e1419", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\myCalendar\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/todo.css\">\r\n    <link rel=\"stylesheet\" href=\"/css/task.css\">\r\n    <link rel=\"stylesheet\" href=\"/css/register.css\">\r\n    <link rel=\"stylesheet\" href=\"/lib/fontawesome-free-5.14.0-web/css/all.css\">\r\n");
            }
            );
            WriteLiteral(@"<!-- emmet -->
<div class=""parent-container"">
    <div class=""side"">Menu</div>
    <div class=""content"">
        <h4>Tasks</h4>
        <div id=""tasks"" class=""section-tasks"">

        </div>
    </div>
    <div class=""details container"">
        <h4>New Task</h4>
        <div class=""details-section"">
            <input class=""rounded border border-primary"" type=""text"" id=""txtTitle"" placeholder=""Task Title"">
        </div>

        <div class=""details-section"">
            <label for=""chkImportant"">Important</label>
            <input type=""checkbox""  id=""chkImportant"">
        </div>

        <div class=""details-section"">
            <textarea  class=""rounded border border-primary"" id=""txtNotes"" placeholder=""Notes"" rows=""6""></textarea>
        </div>

        <div class=""details-section"">
            <button id=""btnSave"" class=""btn btn-info btn-primary"">Save Task</button>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src =\"/js/calendar.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
