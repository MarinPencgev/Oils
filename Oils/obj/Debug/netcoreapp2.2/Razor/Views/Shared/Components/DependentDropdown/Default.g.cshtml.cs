#pragma checksum "C:\Users\Nora\Desktop\Oils-ProjectDefence\Oils\Oils\Views\Shared\Components\DependentDropdown\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e1ac957d974aa12418e8a2f3fef3d56b8eaca6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DependentDropdown_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DependentDropdown/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/DependentDropdown/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_DependentDropdown_Default))]
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
#line 1 "C:\Users\Nora\Desktop\Oils-ProjectDefence\Oils\Oils\Views\_ViewImports.cshtml"
using Oils;

#line default
#line hidden
#line 2 "C:\Users\Nora\Desktop\Oils-ProjectDefence\Oils\Oils\Views\_ViewImports.cshtml"
using Oils.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e1ac957d974aa12418e8a2f3fef3d56b8eaca6b", @"/Views/Shared/Components/DependentDropdown/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc48acd2abbd6e5f2d5c8ae8286a0bcd8244f3f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DependentDropdown_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Oils.Data.Domains.Product>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Nora\Desktop\Oils-ProjectDefence\Oils\Oils\Views\Shared\Components\DependentDropdown\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(76, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(105, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e1ac957d974aa12418e8a2f3fef3d56b8eaca6b3871", async() => {
                BeginContext(111, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Default</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(207, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(209, 1314, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e1ac957d974aa12418e8a2f3fef3d56b8eaca6b5149", async() => {
                BeginContext(215, 159, true);
                WriteLiteral("\r\n    <p>\r\n        <h1>PRODUCT CATALOG</h1>\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(375, 40, false);
#line 22 "C:\Users\Nora\Desktop\Oils-ProjectDefence\Oils\Oils\Views\Shared\Components\DependentDropdown\Default.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(415, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(483, 47, false);
#line 25 "C:\Users\Nora\Desktop\Oils-ProjectDefence\Oils\Oils\Views\Shared\Components\DependentDropdown\Default.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductCode));

#line default
#line hidden
                EndContext();
                BeginContext(530, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(598, 45, false);
#line 28 "C:\Users\Nora\Desktop\Oils-ProjectDefence\Oils\Oils\Views\Shared\Components\DependentDropdown\Default.cshtml"
               Write(Html.DisplayNameFor(model => model.Viscosity));

#line default
#line hidden
                EndContext();
                BeginContext(643, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(711, 51, false);
#line 31 "C:\Users\Nora\Desktop\Oils-ProjectDefence\Oils\Oils\Views\Shared\Components\DependentDropdown\Default.cshtml"
               Write(Html.DisplayNameFor(model => model.PackageCapacity));

#line default
#line hidden
                EndContext();
                BeginContext(762, 106, true);
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 37 "C:\Users\Nora\Desktop\Oils-ProjectDefence\Oils\Oils\Views\Shared\Components\DependentDropdown\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(925, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(998, 39, false);
#line 41 "C:\Users\Nora\Desktop\Oils-ProjectDefence\Oils\Oils\Views\Shared\Components\DependentDropdown\Default.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1037, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1117, 46, false);
#line 44 "C:\Users\Nora\Desktop\Oils-ProjectDefence\Oils\Oils\Views\Shared\Components\DependentDropdown\Default.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProductCode));

#line default
#line hidden
                EndContext();
                BeginContext(1163, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1243, 44, false);
#line 47 "C:\Users\Nora\Desktop\Oils-ProjectDefence\Oils\Oils\Views\Shared\Components\DependentDropdown\Default.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Viscosity));

#line default
#line hidden
                EndContext();
                BeginContext(1287, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1367, 50, false);
#line 50 "C:\Users\Nora\Desktop\Oils-ProjectDefence\Oils\Oils\Views\Shared\Components\DependentDropdown\Default.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PackageCapacity));

#line default
#line hidden
                EndContext();
                BeginContext(1417, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 53 "C:\Users\Nora\Desktop\Oils-ProjectDefence\Oils\Oils\Views\Shared\Components\DependentDropdown\Default.cshtml"
            }

#line default
#line hidden
                BeginContext(1484, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1523, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Oils.Data.Domains.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
