#pragma checksum "C:\Projects\DevTest\DevTest\Views\Home\Chart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1ecd3594888b7a30347667582089b727b779564"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chart), @"mvc.1.0.view", @"/Views/Home/Chart.cshtml")]
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
#line 1 "C:\Projects\DevTest\DevTest\Views\_ViewImports.cshtml"
using PDF_File_Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\DevTest\DevTest\Views\_ViewImports.cshtml"
using PDF_File_Test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1ecd3594888b7a30347667582089b727b779564", @"/Views/Home/Chart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"381dd18374035d301cf29f323433c5216917d466", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Chart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery.orgchart.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.orgchart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Projects\DevTest\DevTest\Views\Home\Chart.cshtml"
  
    ViewData["Title"] = "Chart";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1ecd3594888b7a30347667582089b727b7795645768", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <style type=""text/css"">
        #orgChart {
            width: auto;
            height: auto;
        }

        #orgChartContainer {
            /*width: 1000px;*/
            /*height: 500px;*/
            overflow: auto;
            background: #eeeeee;
        }
    </style>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1ecd3594888b7a30347667582089b727b7795647419", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\"//html2canvas.hertzen.com/dist/html2canvas.min.js\"></script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Chart", async() => {
                WriteLiteral(@"
    <h1 style=""margin-top:150px;"">jQuery orgChart Plugin Demo</h1>
    <div id=""TestDv"">
        <div id=""orgChartContainer"">
            <div id=""orgChart""></div>
        </div>
    </div>
    <div id=""img"">
    </div>
    
    <input type=""button"" value=""완료"" onclick=""fn_Sucess();"" />
    <input type=""button"" value=""이미지로 저장"" onclick=""fn_Save();"" />
    <input type=""button"" value=""인쇄"" onclick=""javascript: window.print();"" />
");
            }
            );
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1ecd3594888b7a30347667582089b727b7795649387", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""//cdnjs.cloudflare.com/ajax/libs/es6-promise/4.1.1/es6-promise.auto.js""></script>
    <script type=""text/javascript"">

        var testData = [
            { id: 1, name: ""CEO"", parent: 0 },
            { id: 2, name: ""경영기획총괄"", parent: 1 },
            { id: 3, name: ""CS본부"", parent: 1 },
            { id: 4, name: ""마케팅본부"", parent: 1 },
            { id: 6, name: ""컨택솔루션본부"", parent: 1 },
            { id: 7, name: ""DX추진팀"", parent: 2 },
            { id: 8, name: ""재무회계팀"", parent: 2 },
            { id: 9, name: ""전략기획팀"", parent: 2 },
            { id: 10, name: ""인재경영팀"", parent: 2 },
            { id: 11, name: ""경영지원팀"", parent: 2 },
            { id: 12, name: ""신사업추진단"", parent: 2 },
            { id: 13, name: ""IT정보보안TF"", parent: 7 },
            { id: 14, name: ""노사협력TF"", parent: 10 },
            { id: 15, name: ""신사업추진팀"", parent: 12 },
            { id: 16, name: ""KTCS BDO"", parent: 12 },
            { id: 17, name: ""CS 기획팀"", parent: 3 },
            { id: 18, name: ""CS 마케팅팀");
                WriteLiteral(@""", parent: 3 },
            { id: 19, name: ""CS 리텐션팀"", parent: 3 },
            { id: 20, name: ""CS lab"", parent: 17 },
            { id: 21, name: ""플랫폼 사업단"", parent: 3 },
            { id: 22, name: ""플랫폼사업팀"", parent: 21 },
            { id: 23, name: ""114팀"", parent: 21 },
            { id: 24, name: ""리서치사업 TF"", parent: 21 },
            { id: 25, name: ""마케팅기획팀"", parent: 4 },
            { id: 26, name: ""MOT유통사업팀"", parent: 4 },
            { id: 27, name: ""모바일유통사업팀"", parent: 4 },
            { id: 28, name: ""대형유통사업팀"", parent: 4 },
            { id: 29, name: ""마케팅지원TF"", parent: 4 },
            { id: 30, name: ""전략유통사업단"", parent: 4 },
            { id: 31, name: ""상품기획팀"", parent: 30 },
            { id: 32, name: ""채털운영팀"", parent: 30 },
            { id: 33, name: ""컨택솔루션기획팀"", parent: 6 },
            { id: 34, name: ""컨택영업1팀"", parent: 6 },
            { id: 35, name: ""컨택영업2팀"", parent: 6 },
            { id: 36, name: ""컨택영업3팀"", parent: 6 },
            { id: 37, name: ""AICC추진단"", parent: 6 },
   ");
                WriteLiteral(@"         { id: 38, name: ""컨택O&M단"", parent: 6 },
            { id: 39, name: ""AICC 기획팀"", parent: 37 },
            { id: 40, name: ""AICC 개발팀"", parent: 37 },
            { id: 41, name: ""AICC 지원 TF"", parent: 40 },
            { id: 42, name: ""컨택O&M1팀"", parent: 38 },
            { id: 43, name: ""컨택O&M2팀"", parent: 38 },
            { id: 44, name: ""교육컨설팅사업팀"", parent: 38 },
            { id: 45, name: ""컨택O&M지원팀"", parent: 38 },
            { id: 46, name: ""윤리경영실"", parent: 1 },
            { id: 47, name: ""제안 TF"", parent: 33 }
        ];
        $(function () {
            org_chart = $('#orgChart').orgChart({
                data: testData,
                showControls: true,
                allowEdit: true,
                onAddNode: function (node) {
                   // log('Created new node on node ' + node.data.id);
                    org_chart.newNode(node.data.id);
                    console.log(JSON.stringify(org_chart.getData()));
                },
                onDeleteNode: fun");
                WriteLiteral(@"ction (node) {
                    log('Deleted node ' + node.data.id);
                   // org_chart.deleteNode(node.data.id);
                }

            });
        });

        function PrintDiv(div) {
            div = div[0]
            html2canvas(div).then(function (canvas) {
                var myImage = canvas.toDataURL();
                downloadURI(myImage, ""저장이미지이름.png"")
            });
        }
        function downloadURI(uri, name) {
            var link = document.createElement(""a"")
            link.download = name;
            link.href = uri;
            document.body.appendChild(link);
            link.click();
        }

        function fn_Sucess() {
            $("".org-add-button"").hide().siblings("".org-del-button"").hide();
        }

        function fn_Save() {
            html2canvas($(""#orgChartContainer"").get(0)).then(function (canvas) {
                document.getElementById('img').appendChild(canvas)
            });
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591