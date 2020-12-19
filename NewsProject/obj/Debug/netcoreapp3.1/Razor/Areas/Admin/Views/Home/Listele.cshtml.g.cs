#pragma checksum "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Listele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d969d3feac28fabbf4d2f1d7a623e906eadb2be3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Listele), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Listele.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d969d3feac28fabbf4d2f1d7a623e906eadb2be3", @"/Areas/Admin/Views/Home/Listele.cshtml")]
    public class Areas_Admin_Views_Home_Listele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsProject.data.concrete.ReportRepository>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Listele.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d969d3feac28fabbf4d2f1d7a623e906eadb2be32955", async() => {
                WriteLiteral("\r\n    <link href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css\" rel=\"stylesheet\">\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d969d3feac28fabbf4d2f1d7a623e906eadb2be34036", async() => {
                WriteLiteral(@"
    <div class=""m-4"">
        <table class=""table table-bordered"" style=""width:100%"">
            <thead class=""thead-dark"">
                <tr>
                    <th>ID</th>
                    <th>Title</th>
                    <th>Content</th>
                    <th>Category</th>
                    <th>Date Time</th>
                    <th>Sil</th>
                    <th>Güncelle</th>
                </tr>
            </thead>

");
#nullable restore
#line 23 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Listele.cshtml"
             foreach (var data in Model.GetAllWithCategory())
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n                <p>");
#nullable restore
#line 27 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Listele.cshtml"
              Write(data.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </td>\r\n            <td style=\"min-width: 150px;\">");
#nullable restore
#line 29 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Listele.cshtml"
                                     Write(data.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Listele.cshtml"
           Write(data.Content);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Listele.cshtml"
           Write(data.Category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\" min-width: 106px;\">");
#nullable restore
#line 32 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Listele.cshtml"
                                      Write(data.DateTime.ToString("dd MM yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
                WriteLiteral("            <td>");
#nullable restore
#line 34 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Listele.cshtml"
           Write(Html.ActionLink("Sil", "DeleteReport", new { id = data.Id }, new { @class = "btn btn-danger", onclick = "return confirm('Silme işlemini onaylıyor musun?')" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td><a");
                BeginWriteAttribute("href", " href=\"", 1370, "\"", 1404, 2);
                WriteAttributeValue("", 1377, "/Admin/Home/Update/", 1377, 19, true);
#nullable restore
#line 35 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Listele.cshtml"
WriteAttributeValue("", 1396, data.Id, 1396, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Listele.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsProject.data.concrete.ReportRepository> Html { get; private set; }
    }
}
#pragma warning restore 1591
