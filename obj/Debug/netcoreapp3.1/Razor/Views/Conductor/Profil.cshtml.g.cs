#pragma checksum "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Profil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "035f45440311c344088d4a942000a95ec3c6b72a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conductor_Profil), @"mvc.1.0.view", @"/Views/Conductor/Profil.cshtml")]
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
#line 1 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/_ViewImports.cshtml"
using serviceCar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/_ViewImports.cshtml"
using serviceCar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"035f45440311c344088d4a942000a95ec3c6b72a", @"/Views/Conductor/Profil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0543cff94467543fc92cb08d8c6d139b133c69f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Conductor_Profil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<serviceCar.Models.DbModels.Conductor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Profil.cshtml"
  
    Layout = "_UsersLayout";
    ViewData["Title"]="Profil";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "035f45440311c344088d4a942000a95ec3c6b72a4278", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Votre Profile</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "035f45440311c344088d4a942000a95ec3c6b72a5331", async() => {
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>Conductor</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n        <dd class = \"col-sm-10\">\r\n            <p>Prènom : ");
#nullable restore
#line 23 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Profil.cshtml"
                   Write(Html.DisplayFor(model => model.UserNavigation.FName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        </dd>\r\n        \r\n        <dd class = \"col-sm-10\">\r\n            <p>Nom : ");
#nullable restore
#line 27 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Profil.cshtml"
                Write(Html.DisplayFor(model => model.UserNavigation.LName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        </dd>\r\n        \r\n        <dd class = \"col-sm-10\">\r\n            <p>Login : ");
#nullable restore
#line 31 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Profil.cshtml"
                  Write(Html.DisplayFor(model => model.UserNavigation.Login));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        </dd>\r\n        <dd class = \"col-sm-10\">\r\n            <p>Cin : ");
#nullable restore
#line 34 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Profil.cshtml"
                Write(Html.DisplayFor(model => model.Cin));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        </dd>\r\n        <dd class = \"col-sm-10\">\r\n            <p>Numéro de Télephone : ");
#nullable restore
#line 37 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Profil.cshtml"
                                Write(Html.DisplayFor(model => model.TelephoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        </dd>\r\n        <dd class = \"col-sm-10\">\r\n            <p>Adresse : ");
#nullable restore
#line 40 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Profil.cshtml"
                    Write(Html.DisplayFor(model => model.Adress));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        </dd>\r\n\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "035f45440311c344088d4a942000a95ec3c6b72a7948", async() => {
                    WriteLiteral("Editer");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Profil.cshtml"
                           WriteLiteral(Model.User);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "035f45440311c344088d4a942000a95ec3c6b72a10173", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
