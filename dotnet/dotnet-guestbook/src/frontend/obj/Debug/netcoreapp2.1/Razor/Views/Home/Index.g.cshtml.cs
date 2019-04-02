#pragma checksum "C:\src\dotnet-guestbook\src\frontend\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d54adafb6ac01af5f050eb130060becae32b5232"
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
#line 1 "C:\src\dotnet-guestbook\src\frontend\Views\_ViewImports.cshtml"
using dotnet_guestbook;

#line default
#line hidden
#line 2 "C:\src\dotnet-guestbook\src\frontend\Views\_ViewImports.cshtml"
using dotnet_guestbook.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d54adafb6ac01af5f050eb130060becae32b5232", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd93eecdb60f6fe4762289400885699e45887d2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GuestbookEntry>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 313, true);
            WriteLiteral(@"
<div class=""header"">
        <div class=""container"">
            <h1>
                <a href=""/"">
                    My Guestbook
                </a>
            </h1>
            <a href=""#"" class=""text-muted"">View on GitHub</a>
        </div>
    </div>

<div class=""container posts mt-0"">
    ");
            EndContext();
            BeginContext(349, 835, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c4bf51ce868473cb31f96ce6f330a1e", async() => {
                BeginContext(404, 773, true);
                WriteLiteral(@"
        <label class=""sr-only"" for=""name"">Name</label>
        <div class=""input-group mb-2 mr-sm-2"">
            <div class=""input-group-prepend"">
                <div class=""input-group-text"">Your Name</div>
            </div>
            <input type=""text"" class=""form-control"" id=""name"" name=""name"" required>
        </div>
        <label class=""sr-only"" for=""message"">Message</label>
        <div class=""input-group mb-2 mr-sm-2"">
            <div class=""input-group-prepend"">
                <div class=""input-group-text"">Message</div>
            </div>
            <input type=""text"" class=""form-control"" id=""message"" name=""message"" required>
        </div>
        <button type=""submit"" class=""btn btn-primary mb-2"">Post to Guestbook</button>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1184, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 33 "C:\src\dotnet-guestbook\src\frontend\Views\Home\Index.cshtml"
     if (Model == null || !Model.Any())
    {

#line default
#line hidden
            BeginContext(1236, 127, true);
            WriteLiteral("        <div class=\"alert alert-info\" role=\"alert\">\r\n            No messages are logged to the guestbook yet.\r\n        </div>\r\n");
            EndContext();
#line 38 "C:\src\dotnet-guestbook\src\frontend\Views\Home\Index.cshtml"
    }
    else
    {
        

#line default
#line hidden
#line 41 "C:\src\dotnet-guestbook\src\frontend\Views\Home\Index.cshtml"
         foreach (var msg in Model)
        {

#line default
#line hidden
            BeginContext(1435, 128, true);
            WriteLiteral("            <div class=\"card my-3 col-12\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
            EndContext();
            BeginContext(1564, 38, false);
#line 45 "C:\src\dotnet-guestbook\src\frontend\Views\Home\Index.cshtml"
                                      Write(Html.DisplayFor(modelItem => msg.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1602, 69, true);
            WriteLiteral("</h5>\r\n                    <h6 class=\"card-subtitle mb-2 text-muted\">");
            EndContext();
            BeginContext(1672, 72, false);
#line 46 "C:\src\dotnet-guestbook\src\frontend\Views\Home\Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => DateTime.UtcNow.Subtract(msg.Date).Minutes));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 112, true);
            WriteLiteral(" minutes ago</h6>\r\n                    <br>\r\n                    <p class=\"card-text\">\r\n                        ");
            EndContext();
            BeginContext(1857, 41, false);
#line 49 "C:\src\dotnet-guestbook\src\frontend\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => msg.Message));

#line default
#line hidden
            EndContext();
            BeginContext(1898, 72, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 53 "C:\src\dotnet-guestbook\src\frontend\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#line 53 "C:\src\dotnet-guestbook\src\frontend\Views\Home\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(1988, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GuestbookEntry>> Html { get; private set; }
    }
}
#pragma warning restore 1591