#pragma checksum "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Error\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c288fd5f524580fcafd3760171d498ad64854499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_Index), @"mvc.1.0.view", @"/Views/Error/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Error/Index.cshtml", typeof(AspNetCore.Views_Error_Index))]
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
#line 1 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\_ViewImports.cshtml"
using LoggerPLC;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\_ViewImports.cshtml"
using LoggerPLC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c288fd5f524580fcafd3760171d498ad64854499", @"/Views/Error/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a4f2a96e1708796c4f7747080737e5a25e1e75", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LoggerPLC.Models.Error>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 295, true);
            WriteLiteral(@"

<h1></h1>
<table class=""table"">
<thead>
    <tr>
      <th scope=""col"">Nazwa zadania</th>
      <th scope=""col"">IP PLC</th>
      <th scope=""col"">Nazwa Taga</th>
      <th scope=""col"">Interwał</th>
      <th scope=""col"">Opis</th>
      <th scope=""col""></th>
    </tr>
</thead>

");
            EndContext();
#line 17 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Error\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(381, 49, true);
            WriteLiteral("        <tr>\r\n            <td> \r\n                ");
            EndContext();
            BeginContext(431, 41, false);
#line 21 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Error\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaskID));

#line default
#line hidden
            EndContext();
            BeginContext(472, 221, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               \r\n            </td>\r\n            <td>\r\n               \r\n            </td> \r\n            <td>\r\n               \r\n            </td> \r\n            <td> \r\n                 ");
            EndContext();
            BeginContext(694, 46, false);
#line 33 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Error\Index.cshtml"
            Write(Html.DisplayFor(modelItem => item.Descryption));

#line default
#line hidden
            EndContext();
            BeginContext(740, 56, true);
            WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(797, 106, false);
#line 36 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Error\Index.cshtml"
           Write(Html.ActionLink("Usun", "Delete", new { id = item.ErrorID }, new { @class = "btn btn-danger btn-medium" }));

#line default
#line hidden
            EndContext();
            BeginContext(903, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 39 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Error\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(946, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LoggerPLC.Models.Error>> Html { get; private set; }
    }
}
#pragma warning restore 1591
