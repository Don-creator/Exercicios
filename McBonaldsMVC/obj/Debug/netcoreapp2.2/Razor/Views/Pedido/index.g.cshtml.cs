#pragma checksum "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad93c85b644c5458b6bfda97b4d43f1acab6bdbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_index), @"mvc.1.0.view", @"/Views/Pedido/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/index.cshtml", typeof(AspNetCore.Views_Pedido_index))]
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
#line 1 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC;

#line default
#line hidden
#line 2 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad93c85b644c5458b6bfda97b4d43f1acab6bdbf", @"/Views/Pedido/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cecd1f98a04a4696ecde4ba045dcb777a275b8f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<McBonaldsMVC.ViewModels.PedidoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "chocolate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "biscoito", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 29, true);
            WriteLiteral("<main>\r\n        <h2>Pede aí, ");
            EndContext();
            BeginContext(78, 17, false);
#line 3 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
                Write(Model.NomeCliente);

#line default
#line hidden
            EndContext();
            BeginContext(95, 16, true);
            WriteLiteral("!</h2>\r\n        ");
            EndContext();
            BeginContext(111, 2384, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad93c85b644c5458b6bfda97b4d43f1acab6bdbf5074", async() => {
                BeginContext(174, 175, true);
                WriteLiteral("\r\n            <div>\r\n                <label for=\"nome\">Nome Completo</label>\r\n                <br />\r\n                <input id=\"nome\" type=\"text\" maxlength=\"20\" minlength=\"3\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 349, "\"", 376, 1);
#line 8 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
WriteAttributeValue("", 357, Model.Cliente.Nome, 357, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(377, 215, true);
                WriteLiteral(" name=\"nome\" />\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"endereco\">Endereço</label>\r\n                <br />\r\n                <input id=\"endereco\" type=\"text\" maxlength=\"20\" minlength=\"3\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 592, "\"", 623, 1);
#line 14 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
WriteAttributeValue("", 600, Model.Cliente.Endereco, 600, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(624, 231, true);
                WriteLiteral(" name=\"endereco\" />\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"telefone\">Telefone para contato</label>\r\n                <br />\r\n                <input id=\"telefone\" type=\"text\" placeholder=\"11 12345 6789\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 855, "\"", 886, 1);
#line 20 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
WriteAttributeValue("", 863, Model.Cliente.Telefone, 863, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(887, 185, true);
                WriteLiteral(" name = \"telefone\" />\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"email\">E-mail</label>\r\n                <br />\r\n                <input id=\"email\" type=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1072, "\"", 1100, 1);
#line 26 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
WriteAttributeValue("", 1080, Model.Cliente.Email, 1080, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1101, 266, true);
                WriteLiteral(@" name=""email"" />
            </div>

            <div class=""double-field"">
                <div>
                    <label for=""hamburguer"">Hamburguer</label>
                    <select id=""hamburguer"" name = ""hamburguer"" required>
                        ");
                EndContext();
                BeginContext(1367, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad93c85b644c5458b6bfda97b4d43f1acab6bdbf8326", async() => {
                    BeginContext(1402, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1420, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 34 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
                         foreach (var hamburguer in Model.Hamburgueres)
                        {

#line default
#line hidden
                BeginContext(1522, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1546, 137, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad93c85b644c5458b6bfda97b4d43f1acab6bdbf10803", async() => {
                    BeginContext(1578, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(1580, 15, false);
#line 36 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
                                                    Write(hamburguer.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1595, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(1601, 16, false);
#line 36 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
                                                                         Write(hamburguer.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(1617, 57, true);
                    WriteLiteral(" \r\n                            \r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 36 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
                          WriteLiteral(hamburguer.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1683, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 39 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
                        }

#line default
#line hidden
                BeginContext(1712, 211, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n                <div>\r\n                    <label for=\"shake\">Shake</label>\r\n                    <select id=\"shake\" name=\"shake\" >\r\n                        ");
                EndContext();
                BeginContext(1923, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad93c85b644c5458b6bfda97b4d43f1acab6bdbf14107", async() => {
                    BeginContext(1958, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1976, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 46 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
                         foreach (var s in Model.Shakes)
                        {

#line default
#line hidden
                BeginContext(2063, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(2091, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad93c85b644c5458b6bfda97b4d43f1acab6bdbf16573", async() => {
                    BeginContext(2114, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(2116, 6, false);
#line 48 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
                                               Write(s.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(2122, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(2128, 7, false);
#line 48 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
                                                           Write(s.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(2135, 32, true);
                    WriteLiteral("\r\n\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 48 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
                              WriteLiteral(s.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2176, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 51 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
                        }

#line default
#line hidden
                BeginContext(2205, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(2229, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad93c85b644c5458b6bfda97b4d43f1acab6bdbf19604", async() => {
                    BeginContext(2255, 9, true);
                    WriteLiteral("Chocolate");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2273, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(2299, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad93c85b644c5458b6bfda97b4d43f1acab6bdbf21097", async() => {
                    BeginContext(2324, 8, true);
                    WriteLiteral("Biscoito");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2341, 147, true);
                WriteLiteral("\r\n                    </select>\r\n                </div>\r\n            </div>\r\n            <input type=\"submit\" value=\"Finalizar pedido!\"/>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 4 "C:\Users\49390062802\Desktop\MVC\Exercicios\McBonaldsMVC\Views\Pedido\index.cshtml"
AddHtmlAttributeValue("", 139, Url.Action("Registrar","Pedido"), 139, 33, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2495, 15, true);
            WriteLiteral("\r\n\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<McBonaldsMVC.ViewModels.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
