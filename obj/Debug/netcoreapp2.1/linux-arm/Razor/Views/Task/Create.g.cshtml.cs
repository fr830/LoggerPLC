#pragma checksum "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b49423071398faed9dd840b8dd99f9e9326c44a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Create), @"mvc.1.0.view", @"/Views/Task/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/Create.cshtml", typeof(AspNetCore.Views_Task_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b49423071398faed9dd840b8dd99f9e9326c44a6", @"/Views/Task/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a4f2a96e1708796c4f7747080737e5a25e1e75", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoggerPLC.Models.Task>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
            BeginContext(68, 28, false);
#line 5 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(103, 23, false);
#line 6 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(133, 37, false);
#line 7 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml"
Write(Html.HiddenFor(model => model.TaskID));

#line default
#line hidden
            EndContext();
            BeginContext(172, 358, true);
            WriteLiteral(@"<br>
<table class=""table"">
<thead>
    <tr>
      <th scope=""col"">Nazwa zadania</th>
      <th scope=""col"">Nazwa Taga</th>
      <th scope=""col"">IP PLC</th> 
      <th scope=""col"">Interwał</th>  
      <th scope=""col"">Aktywne</th>
    </tr>
</thead>
        <tr>
            <td>
                <div class=""editor-field""> 
                    ");
            EndContext();
            BeginContext(531, 144, false);
#line 22 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml"
               Write(Html.EditorFor(model => model.TaskName, new { htmlAttributes = new { @class = "form-control",style = " max-width: 160px ; max-height: 28px" } }));

#line default
#line hidden
            EndContext();
            BeginContext(675, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(698, 50, false);
#line 23 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(748, 127, true);
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n            <td>\r\n                <div class=\"editor-field\">\r\n                    ");
            EndContext();
            BeginContext(876, 143, false);
#line 28 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml"
               Write(Html.EditorFor(model => model.TagName, new { htmlAttributes = new { @class = "form-control",style = " max-width: 160px ; max-height: 28px" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1042, 49, false);
#line 29 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.TagName));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 127, true);
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n            <td>\r\n                <div class=\"editor-field\">\r\n                    ");
            EndContext();
            BeginContext(1219, 141, false);
#line 34 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml"
               Write(Html.EditorFor(model => model.IpPLC, new { htmlAttributes = new { @class = "form-control",style = " max-width: 160px ; max-height: 28px" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1383, 47, false);
#line 35 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.IpPLC));

#line default
#line hidden
            EndContext();
            BeginContext(1430, 128, true);
            WriteLiteral("\r\n                </div>\r\n            </td> \r\n            <td>\r\n                <div class=\"editor-field\">\r\n                    ");
            EndContext();
            BeginContext(1559, 148, false);
#line 40 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml"
               Write(Html.EditorFor(model => model.TaskInterval, new { htmlAttributes = new { @class = "form-control",style = " max-width: 160px ; max-height: 28px" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1707, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1730, 54, false);
#line 41 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.TaskInterval));

#line default
#line hidden
            EndContext();
            BeginContext(1784, 130, true);
            WriteLiteral("\r\n                </div> \r\n            </td>  \r\n            <td>\r\n                <div class=\"editor-field\">\r\n                    ");
            EndContext();
            BeginContext(1915, 144, false);
#line 46 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml"
               Write(Html.EditorFor(model => model.IsActive, new { htmlAttributes = new { @class = "form-control",style = " max-width: 160px ; max-height: 28px" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2059, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2082, 50, false);
#line 47 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(2132, 347, true);
            WriteLiteral(@"
                </div> 
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <p>
                    <input type=""submit"" value=""Zapisz"" class = ""btn btn-info btn-medium""/>
                </p> 
            </td>
        </tr>
</table>    
");
            EndContext();
#line 62 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Task\Create.cshtml"
}

#line default
#line hidden
            BeginContext(2482, 640, true);
            WriteLiteral(@"

<script src=""https://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.2.0.min.js""></script>
<script src=""https://ajax.aspnetcdn.com/ajax/jquery.validate/1.16.0/jquery.validate.min.js""></script>
<script src=""https://ajax.aspnetcdn.com/ajax/jquery.validation.unobtrusive/3.2.6/jquery.validate.unobtrusive.min.js""></script>

<script src=""https://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.2.0.min.js""></script>
<script src=""https://ajax.aspnetcdn.com/ajax/jquery.validate/1.16.0/jquery.validate.min.js""></script>
<script src=""https://ajax.aspnetcdn.com/ajax/jquery.validation.unobtrusive/3.2.6/jquery.validate.unobtrusive.min.js""></script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoggerPLC.Models.Task> Html { get; private set; }
    }
}
#pragma warning restore 1591
