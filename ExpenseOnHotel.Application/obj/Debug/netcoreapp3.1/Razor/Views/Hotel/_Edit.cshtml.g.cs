#pragma checksum "D:\produto\ExpenseOnHotel\ExpenseOnHotel.Application\Views\Hotel\_Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb7337fec18acd20effdc2d72215a2d3e50d57b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel__Edit), @"mvc.1.0.view", @"/Views/Hotel/_Edit.cshtml")]
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
#line 1 "D:\produto\ExpenseOnHotel\ExpenseOnHotel.Application\Views\_ViewImports.cshtml"
using ExpenseOnHotel.Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\produto\ExpenseOnHotel\ExpenseOnHotel.Application\Views\_ViewImports.cshtml"
using ExpenseOnHotel.Application.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb7337fec18acd20effdc2d72215a2d3e50d57b6", @"/Views/Hotel/_Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a4ec481ee942f1e668873f488226c914b31951", @"/Views/_ViewImports.cshtml")]
    public class Views_Hotel__Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExpenseOnHotel.Application.Models.HotelViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Hotel/Edit.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\produto\ExpenseOnHotel\ExpenseOnHotel.Application\Views\Hotel\_Edit.cshtml"
 using (Html.BeginForm("Edit", "Hotel", FormMethod.Post, new { @id = "frm" }))
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\produto\ExpenseOnHotel\ExpenseOnHotel.Application\Views\Hotel\_Edit.cshtml"
Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <div class=\"form-floating mb-1\">\r\n  ");
#nullable restore
#line 8 "D:\produto\ExpenseOnHotel\ExpenseOnHotel.Application\Views\Hotel\_Edit.cshtml"
Write(Html.TextBoxFor(x => x.Name, new {@class="form-control", @placeholder = "Nome do Hotel", @required="required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  <label for=\"Name\">Nome do Hotel</label>\r\n</div>\r\n");
            WriteLiteral("  <div class=\"form-floating mb-1\">\r\n");
            WriteLiteral("</div>\r\n");
            WriteLiteral("  <div class=\"form-floating mb-1\">\r\n  ");
#nullable restore
#line 17 "D:\produto\ExpenseOnHotel\ExpenseOnHotel.Application\Views\Hotel\_Edit.cshtml"
Write(Html.TextAreaFor(x => x.Description, new {@cols="50", @rows="4", @class="form-control" , @required="required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  <label for=\"Description\">Descrição</label>\r\n</div>\r\n");
            WriteLiteral(@"  <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
  <li class=""nav-item"" role=""presentation"">
    <button class=""nav-link active"" id=""endereco-tab"" data-bs-toggle=""tab"" data-bs-target=""#endereco"" type=""button""
      role=""tab"" aria-controls=""Endereço"" aria-selected=""true"">Endereço</button>
  </li>
  <li class=""nav-item"" role=""presentation"">
    <button class=""nav-link"" id=""facility-tab"" data-bs-toggle=""tab"" data-bs-target=""#facilities"" type=""button""
      role=""tab"" aria-controls=""Facilities"" aria-selected=""false"">Comodidades</button>
  </li>
</ul>
  <div class=""tab-content mt-2"" id=""TabContent"" style=""min-height: 200px;"">
  <div class=""tab-pane fade show active"" id=""endereco"" role=""tabpanel"" aria-labelledby=""endereco-tab"">
    ");
#nullable restore
#line 33 "D:\produto\ExpenseOnHotel\ExpenseOnHotel.Application\Views\Hotel\_Edit.cshtml"
Write(await Html.PartialAsync("_Adress", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </div>\r\n\r\n  <div class=\"tab-pane fade\" id=\"facilities\" role=\"tabpanel\" aria-labelledby=\"facility-tab\">\r\n    ");
#nullable restore
#line 37 "D:\produto\ExpenseOnHotel\ExpenseOnHotel.Application\Views\Hotel\_Edit.cshtml"
Write(await Component.InvokeAsync("HotelFacility", new {id = Model.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </div>\r\n</div>\r\n");
            WriteLiteral("  <div class=\"modal-footer\">\r\n  <button onclick=\"CloseModal();\" class=\"btn btn-secondary\">Fechar</button>\r\n  <button Name=\"submit\" type=\"submit\" class=\"btn btn-primary\">Salvar</button>\r\n</div>\r\n");
#nullable restore
#line 45 "D:\produto\ExpenseOnHotel\ExpenseOnHotel.Application\Views\Hotel\_Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb7337fec18acd20effdc2d72215a2d3e50d57b67262", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExpenseOnHotel.Application.Models.HotelViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
