#pragma checksum "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "def2f63ab80a2a7178719025965f7c807726594e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Update), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Update.cshtml")]
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
#line 4 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Update.cshtml"
using NewsProject.data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"def2f63ab80a2a7178719025965f7c807726594e", @"/Areas/Admin/Views/Home/Update.cshtml")]
    public class Areas_Admin_Views_Home_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsProject.ViewModels.ReportViewModel>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def2f63ab80a2a7178719025965f7c807726594e2843", async() => {
                WriteLiteral(@"
    <link href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"" rel=""stylesheet"">
    <style>
        textarea {
            resize: none;
            height: 65px;
        }

        #Id:last-child {
            readonly;
        }
    </style>
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
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 25 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Update.cshtml"
 using (Html.BeginForm(FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row d-flex justify-content-center mt-5"">
        <div class=""col-md-8"">
            <form action=""/Admin/Home/Update"" method=""post"">
                <div id=""Id"">
                    <b>Id</b>
                    <input class=""form-control"" readonly type=""text"" name=""Id""");
            BeginWriteAttribute("value", " value=\"", 852, "\"", 869, 1);
#nullable restore
#line 32 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Update.cshtml"
WriteAttributeValue("", 860, Model.Id, 860, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <br />\r\n                <b>Title</b>\r\n                ");
#nullable restore
#line 36 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Update.cshtml"
           Write(Html.TextAreaFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                <b>Long Title</b>\r\n                ");
#nullable restore
#line 39 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Update.cshtml"
           Write(Html.TextAreaFor(x => x.LongTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                <b>Content</b>\r\n                ");
#nullable restore
#line 42 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Update.cshtml"
           Write(Html.TextAreaFor(x => x.Content, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                <b>Read of Number</b>\r\n                ");
#nullable restore
#line 45 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Update.cshtml"
           Write(Html.TextBoxFor(x => x.ReadOfNumber, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                <b>Category Name</b>\r\n                ");
#nullable restore
#line 48 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Update.cshtml"
           Write(Html.TextBoxFor(x => x.CategoryId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                <b>Source Url</b>\r\n                ");
#nullable restore
#line 51 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Update.cshtml"
           Write(Html.TextBoxFor(x => x.SourceUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                <b>Is Active</b>\r\n                ");
#nullable restore
#line 54 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Update.cshtml"
           Write(Html.CheckBoxFor(x => x.IsActive, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <br />
                <div class=""d-flex justify-content-between"" >
                    <button class=""btn btn-primary"">Güncelle</button>
                    <a href=""/Admin/Home/Listele"">İptal</a>

                </div>

            </form>
        </div>
    </div>
");
#nullable restore
#line 65 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Areas\Admin\Views\Home\Update.cshtml"


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsProject.ViewModels.ReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
