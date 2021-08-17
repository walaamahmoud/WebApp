#pragma checksum "C:\Users\walaa\source\repos\WebApp\Views\Charts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c5a6bb020f7d75e6ab15badb6fb09cafa7091cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Charts_Index), @"mvc.1.0.view", @"/Views/Charts/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c5a6bb020f7d75e6ab15badb6fb09cafa7091cc", @"/Views/Charts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fd3bbcd1d9d63ae1ea083e5c29db300b81bd681", @"/Views/_ViewImports.cshtml")]
    public class Views_Charts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0 mr-lg-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Search", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c5a6bb020f7d75e6ab15badb6fb09cafa7091cc3310", async() => {
                    WriteLiteral(@"
        <div class=""input-group"">
            <input class=""form-control"" type=""text"" placeholder=""Search for..."">
            <span class=""input-group-btn"">
                <button class=""btn btn-primary"" type=""button"">
                    <i class=""fa fa-search""></i>
                </button>
            </span>
        </div>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"

<div class=""container-fluid"">
    <!-- Breadcrumbs-->
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item"">
            <a href=""#"">Dashboard</a>
        </li>
        <li class=""breadcrumb-item active"">Charts</li>
    </ol>
    <!-- Area Chart Example-->
    <div class=""card mb-3"">
        <div class=""card-header"">
            <i class=""fa fa-area-chart""></i> Area Chart Example
        </div>
        <div class=""card-body"">
            <canvas id=""myAreaChart"" width=""100"" height=""30""></canvas>
        </div>
        <div class=""card-footer small text-muted"">Updated yesterday at 11:59 PM</div>
    </div>
    <div class=""row"">
        <div class=""col-lg-8"">
            <!-- Example Bar Chart Card-->
            <div class=""card mb-3"">
                <div class=""card-header"">
                    <i class=""fa fa-bar-chart""></i> Bar Chart Example
                </div>
                <div class=""card-body"">
                    <canvas id=""myBarChart"" width=""100"" height=""");
            WriteLiteral(@"50""></canvas>
                </div>
                <div class=""card-footer small text-muted"">Updated yesterday at 11:59 PM</div>
            </div>
        </div>
        <div class=""col-lg-4"">
            <!-- Example Pie Chart Card-->
            <div class=""card mb-3"">
                <div class=""card-header"">
                    <i class=""fa fa-pie-chart""></i> Pie Chart Example
                </div>
                <div class=""card-body"">
                    <canvas id=""myPieChart"" width=""100"" height=""100""></canvas>
                </div>
                <div class=""card-footer small text-muted"">Updated yesterday at 11:59 PM</div>
            </div>
        </div>
    </div>
</div>
<!-- /.container-fluid-->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
