#pragma checksum "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e53963904a32b25d15de119b031d46a16e913e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DeleteCon), @"mvc.1.0.view", @"/Views/Admin/DeleteCon.cshtml")]
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
#line 1 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\_ViewImports.cshtml"
using serviceCar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\_ViewImports.cshtml"
using serviceCar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e53963904a32b25d15de119b031d46a16e913e4", @"/Views/Admin/DeleteCon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d5013255d33914c0bbaaa6a41d109f2acbd59f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DeleteCon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<serviceCar.Models.DbModels.Conductor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
  
    Layout = "_UsersLayout";

    ViewBag.Title = "Delete Conductor";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Delete Conductor</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Conductor</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 17 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 21 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 25 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayNameFor(model => model.UserNavigation.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 29 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayFor(model => model.UserNavigation.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 33 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayNameFor(model => model.UserNavigation.LName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 37 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayFor(model => model.UserNavigation.LName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 41 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayNameFor(model => model.UserNavigation.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 45 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayFor(model => model.UserNavigation.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 49 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayNameFor(model => model.UserNavigation.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 53 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayFor(model => model.UserNavigation.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 57 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayNameFor(model => model.UserNavigation.IsAdmin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 61 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayFor(model => model.UserNavigation.IsAdmin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 65 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayNameFor(model => model.Cin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 69 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayFor(model => model.Cin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 73 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayNameFor(model => model.TelephoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 77 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayFor(model => model.TelephoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 81 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 85 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 89 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 93 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.DisplayFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
#nullable restore
#line 98 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
#nullable restore
#line 104 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
       Write(Html.ActionLink("Back to List", "DisplayCon"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 106 "C:\Users\hilia\OneDrive\Bureau\c# project\new one\serviceCar\Views\Admin\DeleteCon.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<serviceCar.Models.DbModels.Conductor> Html { get; private set; }
    }
}
#pragma warning restore 1591
