#pragma checksum "C:\Users\jkhal\source\repos\WorkShop\WorkShop\Areas\Holidaies\Views\Skills\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24606bb71dceda031a3b982e1566baa54c27aebf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Holidaies_Views_Skills_Index), @"mvc.1.0.view", @"/Areas/Holidaies/Views/Skills/Index.cshtml")]
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
#line 1 "C:\Users\jkhal\source\repos\WorkShop\WorkShop\Areas\Holidaies\Views\Skills\Index.cshtml"
using BLL.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24606bb71dceda031a3b982e1566baa54c27aebf", @"/Areas/Holidaies/Views/Skills/Index.cshtml")]
    public class Areas_Holidaies_Views_Skills_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\jkhal\source\repos\WorkShop\WorkShop\Areas\Holidaies\Views\Skills\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layout/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<center>\r\n    <h2>Welcome To Holidaies</h2>\r\n</center>\r\n\r\n<br /><br />\r\n<h1>List Of Department</h1>\r\n\r\n<ul>\r\n");
#nullable restore
#line 20 "C:\Users\jkhal\source\repos\WorkShop\WorkShop\Areas\Holidaies\Views\Skills\Index.cshtml"
     foreach (var item in department.Get())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 22 "C:\Users\jkhal\source\repos\WorkShop\WorkShop\Areas\Holidaies\Views\Skills\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 23 "C:\Users\jkhal\source\repos\WorkShop\WorkShop\Areas\Holidaies\Views\Skills\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<h1>List Of Employee</h1>\r\n\r\n<ul>\r\n");
#nullable restore
#line 29 "C:\Users\jkhal\source\repos\WorkShop\WorkShop\Areas\Holidaies\Views\Skills\Index.cshtml"
     foreach (var item in employee.Get())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 31 "C:\Users\jkhal\source\repos\WorkShop\WorkShop\Areas\Holidaies\Views\Skills\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 32 "C:\Users\jkhal\source\repos\WorkShop\WorkShop\Areas\Holidaies\Views\Skills\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IEmployeeRep employee { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IDepartmentRep department { get; private set; }
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
