#pragma checksum "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44af917b8bfe7eb98b5969b7400c23bf4f501450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Donor_Index), @"mvc.1.0.view", @"/Views/Donor/Index.cshtml")]
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
#line 1 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\_ViewImports.cshtml"
using BloodAlliance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\_ViewImports.cshtml"
using BloodAlliance.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44af917b8bfe7eb98b5969b7400c23bf4f501450", @"/Views/Donor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71870e98f9b212fc4a792387575e6bb8c7365aec", @"/Views/_ViewImports.cshtml")]
    public class Views_Donor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BloodAlliance.Models.Donor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
  
    ViewData["Title"] = "#SAVELIFEDONATEBLOOD";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>#SAVELIFEDONATEBLOOD</h2>\r\n\r\n<table class=\"table\">\r\n\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n       \r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Prezime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BrojTelefona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Jmbg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.KrvnaGrupa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RhFaktor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 51 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BrojDarivanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TjelesnaTezina));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 59 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MjestoDarivanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 63 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DatumPosljednjeDonacije));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 67 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Hemoglobin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 71 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.KrvniPritisak));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 75 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        \r\n            <th>\r\n                ");
#nullable restore
#line 79 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StatusDonora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n        <tr></tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 85 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 92 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Prezime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 95 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 98 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 101 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 104 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BrojTelefona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 107 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Jmbg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 110 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.KrvnaGrupa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 113 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RhFaktor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 116 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BrojDarivanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 119 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TjelesnaTezina));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 122 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MjestoDarivanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 125 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DatumPosljednjeDonacije));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 128 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Hemoglobin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 131 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.KrvniPritisak));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 134 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Pol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 137 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StatusDonora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44af917b8bfe7eb98b5969b7400c23bf4f50145016896", async() => {
                WriteLiteral("Edit");
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
#line 140 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
                                           WriteLiteral(item.DonorId);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44af917b8bfe7eb98b5969b7400c23bf4f50145019097", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 141 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
                                              WriteLiteral(item.DonorId);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44af917b8bfe7eb98b5969b7400c23bf4f50145021304", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 142 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
                                             WriteLiteral(item.DonorId);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 145 "C:\Users\User\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

    <a href=""/Donor/Create"" class=""btn btn-danger"" role=""button"" aria-pressed=""true""> Kreiraj donora </a>

<br>
<br>
<a href=""/ZdravstvenaHistorija/Index"" class=""btn btn-danger"" role=""button"" aria-pressed=""true""> Zdravstvena historija </a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BloodAlliance.Models.Donor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
