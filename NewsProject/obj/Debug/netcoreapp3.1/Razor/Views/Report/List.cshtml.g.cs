#pragma checksum "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Views\Report\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2c38224a5f78d720ebc0babd1f65ecc8e68f55a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_List), @"mvc.1.0.view", @"/Views/Report/List.cshtml")]
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
#line 1 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Views\_ViewImports.cshtml"
using NewsProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Views\_ViewImports.cshtml"
using NewsProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2c38224a5f78d720ebc0babd1f65ecc8e68f55a", @"/Views/Report/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2c63998759310363d7d5cfcf208857a0f47a457", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsProject.data.concrete.ReportRepository>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Views\Report\List.cshtml"
 foreach (var data in Model.ListWithCategoryId(ViewBag.CategoryId))
{



#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section>
    <div class=""container"" style=""padding: 2rem;"">
        <div class=""row"">
            <div class="" col-md-8 content card"" style=""padding: 1rem; border: 1px solid gray; border: 1px solid rgba(0,0,0,0.2);"">
                <div class="" card-header"" style=""text-align: center; font-weight: 700; background-color: white !important;"">
                    <a style=""float:left;color:black""");
            BeginWriteAttribute("href", " href=\"", 656, "\"", 684, 2);
            WriteAttributeValue("", 663, "/Report/News/", 663, 13, true);
#nullable restore
#line 16 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Views\Report\List.cshtml"
WriteAttributeValue("", 676, data.Id, 676, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Views\Report\List.cshtml"
                                                                              Write(data.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\" card-body\">\r\n                    <p>");
#nullable restore
#line 22 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Views\Report\List.cshtml"
                  Write(data.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\" content-bottom\" style=\"display: flex;display: flex;justify-content: space-between;margin: 0 1rem;\">\r\n                    <div class=\" card-text\" style=\"opacity: 0.8;\">\r\n                        <p>");
#nullable restore
#line 26 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Views\Report\List.cshtml"
                      Write(data.DateTime.ToString("dd MM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"card-text\" style=\"opacity: 0.8;\">\r\n                        <p>Okunma Sayısı: <span>");
#nullable restore
#line 29 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Views\Report\List.cshtml"
                                           Write(data.ReadOfNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n\r\n\r\n            </div>\r\n            \r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n");
#nullable restore
#line 42 "C:\Users\kerim\Documents\GitHub\NewsProject\NewsProject\Views\Report\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsProject.data.concrete.ReportRepository> Html { get; private set; }
    }
}
#pragma warning restore 1591
