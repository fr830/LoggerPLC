#pragma checksum "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b367f6ee91db9b16d54ead8648793cca765455a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Index), @"mvc.1.0.view", @"/Views/Task/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/Index.cshtml", typeof(AspNetCore.Views_Task_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b367f6ee91db9b16d54ead8648793cca765455a0", @"/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a4f2a96e1708796c4f7747080737e5a25e1e75", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LoggerPLC.Models.Task>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 296, true);
            WriteLiteral(@"
<h1></h1>
<table class=""table"">
<thead>
    <tr>
      <th scope=""col"">Nazwa zadania</th>
      <th scope=""col"">IP PLC</th>
      <th scope=""col"">Nazwa Taga</th>
      <th scope=""col"">Interwał</th>
      <th scope=""col"">Aktywne</th>
      <th scope=""col""></th>
    </tr>
</thead>

");
            EndContext();
#line 16 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(380, 49, true);
            WriteLiteral("        <tr>\r\n            <td> \r\n                ");
            EndContext();
            BeginContext(430, 43, false);
#line 20 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(473, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(529, 40, false);
#line 23 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IpPLC));

#line default
#line hidden
            EndContext();
            BeginContext(569, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(625, 42, false);
#line 26 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TagName));

#line default
#line hidden
            EndContext();
            BeginContext(667, 56, true);
            WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(724, 47, false);
#line 29 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaskInterval));

#line default
#line hidden
            EndContext();
            BeginContext(771, 59, true);
            WriteLiteral("\r\n            </td> \r\n            <td> \r\n                  ");
            EndContext();
            BeginContext(832, 31, false);
#line 32 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Index.cshtml"
              Write(item.IsActive==true?"TAK":"NIE");

#line default
#line hidden
            EndContext();
            BeginContext(864, 56, true);
            WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(921, 105, false);
#line 35 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Index.cshtml"
           Write(Html.ActionLink("Usun", "Delete", new { id = item.TaskID }, new { @class = "btn btn-danger btn-medium" }));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1045, 106, false);
#line 36 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Index.cshtml"
           Write(Html.ActionLink("Edytuj", "Edit", new { id = item.TaskID }, new { @class = "btn btn-warning btn-medium" }));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1170, 106, false);
#line 37 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Index.cshtml"
           Write(Html.ActionLink("Rysuj","Draw","Chart",new {id = item.TaskID}, new { @class = "btn btn-info btn-medium" }));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 37, true);
            WriteLiteral(" \r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1320, 23, true);
            WriteLiteral("\r\n</table>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(1344, 112, false);
#line 45 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Index.cshtml"
Write(Html.ActionLink("Dodaj nowe zadanie", "Create", new { id = " " }, new { @class = "btn btn-success btn-medium" }));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 12, true);
            WriteLiteral("\r\n</p>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LoggerPLC.Models.Task>> Html { get; private set; }
    }
}
#pragma warning restore 1591