#pragma checksum "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/ServiceCar/Views/Home/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c19fc49b933fbfac6ac19deb22ad56928df130a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/ServiceCar/Views/_ViewImports.cshtml"
using serviceCar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/ServiceCar/Views/_ViewImports.cshtml"
using serviceCar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c19fc49b933fbfac6ac19deb22ad56928df130a", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0543cff94467543fc92cb08d8c6d139b133c69f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<serviceCar.Models.DbModels.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/ServiceCar/Views/Home/Login.cshtml"
  
    

    ViewData["Title"] = "Home Page";
    Layout="_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""card index-card0 border-0"">
        <div class=""row d-flex"">
            <div class=""col-lg-6"">
                <div class=""card1 pb-5"">
                    <!--<div class=""row""> <img src=""https://i.imgur.com/CXQmsmF.png"" class=""logo""> </div>-->
                    <div class=""row px-3 justify-content-center mt-4 mb-5 border-line""> <img src=""https://i.imgur.com/uNGdWHi.png"" class=""image""> </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""card2 card border-0 px-4 py-5"">
                    <div class=""row mb-4 px-3"">
                        <h6 class=""mb-0 mr-4 mt-2"">Sign in with</h6>
                        <div class=""facebook text-center mr-3"">
                            <div class=""fa fa-facebook""></div>
                        </div>
                        <div class=""twitter text-center mr-3"">
                            <div class=""fa fa-twitter""></div>
                      ");
            WriteLiteral(@"  </div>
                        <div class=""linkedin text-center mr-3"">
                            <div class=""fa fa-linkedin""></div>
                        </div>
                    </div>
                    <div class=""row px-3 mb-4"">
                        <div class=""line""></div> <small class=""or text-center"">Or</small>
                        <div class=""line""></div>
                    </div>
                    <div class=""row px-3"">
");
#nullable restore
#line 37 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/ServiceCar/Views/Home/Login.cshtml"
                     using (Html.BeginForm()){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row px-3\">\r\n                            <label class=\"mb-1\">\r\n                                <h6 class=\"mb-0 text-sm\">Email Address</h6>\r\n                            </label>\r\n                            ");
#nullable restore
#line 42 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/ServiceCar/Views/Home/Login.cshtml"
                       Write(Html.TextBoxFor(model => model.Login, new { @class = "mb-4", placeholder = "Enter a valid email address" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row px-3\">\r\n                            <label class=\"mb-1\">\r\n                                <h6 class=\"mb-0 text-sm\">Password</h6>\r\n                            </label> ");
#nullable restore
#line 47 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/ServiceCar/Views/Home/Login.cshtml"
                                Write(Html.PasswordFor(model => model.Password, new { @class = "mb-4", placeholder = "Enter your password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <div class=""row px-3 mb-4"">
                            <div class=""custom-control custom-checkbox custom-control-inline""> <input id=""chk1"" type=""checkbox"" name=""chk"" class=""custom-control-input""> <label for=""chk1"" class=""custom-control-label text-sm"">Remember me</label> </div> <a href=""#"" class=""ml-auto mb-0 text-sm"">Forgot Password?</a>
                        </div>
                        <div class=""row mb-3 px-3""> <button type=""submit"" class=""btn btn-blue text-center"">Login</button> </div>
");
#nullable restore
#line 53 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/ServiceCar/Views/Home/Login.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row mb-4 px-3""> <small class=""font-weight-bold"">Don't have an account? <a class=""text-danger "">See your administrator</a></small> </div>
                </div>
            </div>
        </div>
        
    </div>
</div></div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<serviceCar.Models.DbModels.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
