#pragma checksum "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Shared/Components/HotelFacility/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c2cddf48f2c768ec8d395297980adad4c148e3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HotelFacility_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HotelFacility/Default.cshtml")]
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
#line 1 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/_ViewImports.cshtml"
using ExpenseOnHotel.Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/_ViewImports.cshtml"
using ExpenseOnHotel.Application.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c2cddf48f2c768ec8d395297980adad4c148e3e", @"/Views/Shared/Components/HotelFacility/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a4ec481ee942f1e668873f488226c914b31951", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HotelFacility_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExpenseOnHotel.Application.Models.HotelFacilityViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/HotelFacility/Default.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"form-group\">\n    <div class=\"row\">\n        <div class=\"col-10\">\n            ");
#nullable restore
#line 6 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Shared/Components/HotelFacility/Default.cshtml"
       Write(Html.DropDownList("Facility", ViewBag.Facilities, "Selecione uma comodidade", new {@class="form-select"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""col-2"">
            <a class=""btn btn-primary mr-2"" href=""javascript: OnSelectFacility();"">Adicionar</a>
        </div>
    </div>

</div>

<ul class=""list-group list-group mt-2"" id=""hotelFacilitiesList"">
    <!--Aqui eu poderia usar o model e um foreach, mas resolvi fazer tudo pelo javascript mesmo-->
</ul>

<script>
    let facilities = ");
#nullable restore
#line 20 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Shared/Components/HotelFacility/Default.cshtml"
                Write(Html.Raw(Json.Serialize(@ViewBag.Facilities)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n    let hotelFacilitiesRemote = ");
#nullable restore
#line 21 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Shared/Components/HotelFacility/Default.cshtml"
                           Write(Html.Raw(Json.Serialize(@Model)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n</script>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c2cddf48f2c768ec8d395297980adad4c148e3e5632", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExpenseOnHotel.Application.Models.HotelFacilityViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
