#pragma checksum "C:\Users\081230047\Documents\GitHub\Arthur\CadAlunoMVC_v5\CadAlunoMVC\Views\Shared\Error.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "040540be1dea0e439a6753509e5216282c880e69f80b26a84a37db9ee593f949"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\081230047\Documents\GitHub\Arthur\CadAlunoMVC_v5\CadAlunoMVC\Views\_ViewImports.cshtml"
using CadAlunoMVC

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\081230047\Documents\GitHub\Arthur\CadAlunoMVC_v5\CadAlunoMVC\Views\_ViewImports.cshtml"
using CadAlunoMVC.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"040540be1dea0e439a6753509e5216282c880e69f80b26a84a37db9ee593f949", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"920eddd16055001f106ef38d389e50d42a2834e714f4cae3e3c7f1420f883f57", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\081230047\Documents\GitHub\Arthur\CadAlunoMVC_v5\CadAlunoMVC\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1 class=\"text-danger\">Erro.</h1>\r\n<h2 class=\"text-danger\">Ocorreu um erro durante o processamento desta requisição :/</h2>\r\n\r\n\r\n<code class=\"danger\">\r\n    ");
            Write(
#nullable restore
#line 11 "C:\Users\081230047\Documents\GitHub\Arthur\CadAlunoMVC_v5\CadAlunoMVC\Views\Shared\Error.cshtml"
     Model.Erro

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</code>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
