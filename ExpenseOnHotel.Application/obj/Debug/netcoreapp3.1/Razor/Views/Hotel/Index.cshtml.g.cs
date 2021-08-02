#pragma checksum "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b74ff756926b1de6871514c86922515edc7cdc55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_Index), @"mvc.1.0.view", @"/Views/Hotel/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74ff756926b1de6871514c86922515edc7cdc55", @"/Views/Hotel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a4ec481ee942f1e668873f488226c914b31951", @"/Views/_ViewImports.cshtml")]
    public class Views_Hotel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExpenseOnHotel.Application.Models.HotelViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Hotel/Index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
  
    ViewData["Title"] = "Hotéis";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col\">\n        <h3>");
#nullable restore
#line 9 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    </div>\n    <div class=\"col\">\n\n        <a href=\"javascript: OpenModal(\'Cadastro de Hotel\', \'Hotel/Edit/\');\" class=\"btn btn-success mb-1\">\n            <i class=\"fas fa-plus\"></i>\n            Adicionar Hotel\n        </a>\n    </div>\n</div>\n\n");
#nullable restore
#line 20 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
 using (Html.BeginForm("Index", "Hotel", FormMethod.Get)){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\n    <div class=\"col\">\n");
            WriteLiteral("\n        ");
#nullable restore
#line 27 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
   Write(Html.TextBox("textSearch", null, new{@class="form-control", @placeholder="Busque pelo nome do hotel ou sua descrição"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"col\">\n        <button type=\"submit\" class=\"btn btn-secondary mr-2\">\n            <i class=\"fas fa-search\"></i>\n            Buscar\n        </button>\n\n        ");
#nullable restore
#line 35 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
   Write(Html.ActionLink("Limpar", "Index", "Hotel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </div>\n</div>\n");
#nullable restore
#line 39 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-striped mt-2"">
    <thead>
        <tr>
            <th scope=""col"">Nome</th>
            <th scope=""col"">Descrição</th>
            <th scope=""col"">Comodidades</th>
            <th scope=""col"">Ações</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 51 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
         foreach (var hotel in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n            <td>\n                <a");
            BeginWriteAttribute("href", " href=\"", 1482, "\"", 1558, 7);
            WriteAttributeValue("", 1489, "javascript:", 1489, 11, true);
            WriteAttributeValue(" ", 1500, "OpenModal(\'Cadastro", 1501, 20, true);
            WriteAttributeValue(" ", 1520, "de", 1521, 3, true);
            WriteAttributeValue(" ", 1523, "Hotel\',", 1524, 8, true);
            WriteAttributeValue(" ", 1531, "\'Hotel/Edit/", 1532, 13, true);
#nullable restore
#line 55 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
WriteAttributeValue("", 1544, hotel.Id, 1544, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1555, "\');", 1555, 3, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
                                                                                           Write(hotel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n            </td>\n            <td>\n                    ");
#nullable restore
#line 58 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
               Write(hotel.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
#nullable restore
#line 61 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
                    foreach (var f in @hotel.Facilities)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <i");
            BeginWriteAttribute("class", " class=\"", 1788, "\"", 1803, 1);
#nullable restore
#line 63 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
WriteAttributeValue("", 1796, f.Icon, 1796, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1804, "\"", 1826, 1);
#nullable restore
#line 63 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
WriteAttributeValue("", 1812, f.Description, 1812, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" mr-2></i>\n");
#nullable restore
#line 64 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            <td>\n                <a");
            BeginWriteAttribute("href", " href=\"", 1912, "\"", 1988, 7);
            WriteAttributeValue("", 1919, "javascript:", 1919, 11, true);
            WriteAttributeValue(" ", 1930, "OpenModal(\'Cadastro", 1931, 20, true);
            WriteAttributeValue(" ", 1950, "de", 1951, 3, true);
            WriteAttributeValue(" ", 1953, "Hotel\',", 1954, 8, true);
            WriteAttributeValue(" ", 1961, "\'Hotel/Edit/", 1962, 13, true);
#nullable restore
#line 67 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
WriteAttributeValue("", 1974, hotel.Id, 1974, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1985, "\');", 1985, 3, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</a> | \n                <a");
            BeginWriteAttribute("href", " href=\"", 2022, "\"", 2061, 4);
            WriteAttributeValue("", 2029, "javascript:", 2029, 11, true);
            WriteAttributeValue(" ", 2040, "Delete(\'", 2041, 9, true);
#nullable restore
#line 68 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
WriteAttributeValue("", 2049, hotel.Id, 2049, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2058, "\');", 2058, 3, true);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Excluir hotel?\');\">Excluir</a>\n            </td>\n            </tr>\n");
#nullable restore
#line 71 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n    <tfoot>\n        <tr>\n");
#nullable restore
#line 75 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
             if (@Model.Count() <= 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td colspan=\"4\">\n                    <div class=\"alert alert-warning\" role=\"alert\">\n                        Nenhum hotel encontrado.\n                    </div>\n                </td>\n");
#nullable restore
#line 82 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td colspan=\"4\">\n                    <div class=\"alert\" role=\"alert\">\n                        Hotéis encontrados: ");
#nullable restore
#line 87 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
                                       Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>                    \n                </td>\n");
#nullable restore
#line 90 "/home/danieljunior/Documentos/produto/ExpenseOn/ExpenseOnHotel/ExpenseOnHotel.Application/Views/Hotel/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\n    </tfoot>\n</table>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b74ff756926b1de6871514c86922515edc7cdc5513144", async() => {
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
                WriteLiteral("\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExpenseOnHotel.Application.Models.HotelViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
