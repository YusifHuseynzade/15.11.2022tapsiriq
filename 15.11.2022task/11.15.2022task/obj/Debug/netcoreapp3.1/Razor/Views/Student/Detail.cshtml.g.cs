#pragma checksum "C:\Users\DELL\Desktop\11.15.2022task\11.15.2022task\Views\Student\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8dabdb5526871a98681ae0f48dd54044514dbe6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Detail), @"mvc.1.0.view", @"/Views/Student/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8dabdb5526871a98681ae0f48dd54044514dbe6", @"/Views/Student/Detail.cshtml")]
    #nullable restore
    public class Views_Student_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\DELL\Desktop\11.15.2022task\11.15.2022task\Views\Student\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detail</h1>\r\n<h4>Studet Id viewdata: ");
#nullable restore
#line 7 "C:\Users\DELL\Desktop\11.15.2022task\11.15.2022task\Views\Student\Detail.cshtml"
                   Write(ViewData["id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>Studet Id viewbag: ");
#nullable restore
#line 8 "C:\Users\DELL\Desktop\11.15.2022task\11.15.2022task\Views\Student\Detail.cshtml"
                  Write(ViewBag.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>Studet Id tempdata: ");
#nullable restore
#line 9 "C:\Users\DELL\Desktop\11.15.2022task\11.15.2022task\Views\Student\Detail.cshtml"
                   Write(TempData["id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n<h4>Student Groupno viewbag: ");
#nullable restore
#line 11 "C:\Users\DELL\Desktop\11.15.2022task\11.15.2022task\Views\Student\Detail.cshtml"
                        Write(ViewBag.Groupno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
