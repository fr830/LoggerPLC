#pragma checksum "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Chart\Draw.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13d6272542dd5456ccaaaf9e758944d960531667"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chart_Draw), @"mvc.1.0.view", @"/Views/Chart/Draw.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chart/Draw.cshtml", typeof(AspNetCore.Views_Chart_Draw))]
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
#line 7 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Chart\Draw.cshtml"
using Highsoft.Web.Mvc.Charts;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13d6272542dd5456ccaaaf9e758944d960531667", @"/Views/Chart/Draw.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a4f2a96e1708796c4f7747080737e5a25e1e75", @"/Views/_ViewImports.cshtml")]
    public class Views_Chart_Draw : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Highsoft.Web.Mvc.Charts.Highcharts>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 298, true);
            WriteLiteral(@"<script src=""https://code.highcharts.com/highcharts.js""></script>
<script src=""https://code.highcharts.com/modules/series-label.js""></script>
<script src=""https://code.highcharts.com/modules/exporting.js""></script>
<script src=""https://code.highcharts.com/modules/export-data.js""></script>


");
            EndContext();
            BeginContext(373, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(379, 46, false);
#line 11 "C:\Users\Admin\Desktop\C#\LoggerPLC\Views\Chart\Draw.cshtml"
Write(Html.Highsoft().GetHighcharts(@Model, "chart"));

#line default
#line hidden
            EndContext();
            BeginContext(426, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Highsoft.Web.Mvc.Charts.Highcharts> Html { get; private set; }
    }
}
#pragma warning restore 1591
