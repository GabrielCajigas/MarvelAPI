#pragma checksum "/Users/gabrielcajigas/Desktop/M-app/Views/Home/Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22a970a377fcac625fe2044a24a5c8ed464cbea8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Main), @"mvc.1.0.view", @"/Views/Home/Main.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Main.cshtml", typeof(AspNetCore.Views_Home_Main))]
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
#line 1 "/Users/gabrielcajigas/Desktop/M-app/Views/_ViewImports.cshtml"
using M_app;

#line default
#line hidden
#line 2 "/Users/gabrielcajigas/Desktop/M-app/Views/_ViewImports.cshtml"
using M_app.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a970a377fcac625fe2044a24a5c8ed464cbea8", @"/Views/Home/Main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b51fdd65c487acc9f3e6d44296d293f6c13c80be", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22a970a377fcac625fe2044a24a5c8ed464cbea83237", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(27, 103, true);
            WriteLiteral("\n\n<div class=\" mt-2 container border\">\n    \n    <h1 class=\"display-2 text-center\">All your Heroes</h1>\n");
            EndContext();
#line 6 "/Users/gabrielcajigas/Desktop/M-app/Views/Home/Main.cshtml"
      
        foreach(var heroes in ViewBag.Heroes)
        {
            if(heroes.usuario == ViewBag.User)
            {
            

#line default
#line hidden
            BeginContext(267, 100, true);
            WriteLiteral("    <div class=\" d-inline-block  m-2 col-sm-3 mb-4\">\n        <div class=\"card h-100\">\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 367, "\"", 392, 2);
            WriteAttributeValue("", 374, "/delete/", 374, 8, true);
#line 14 "/Users/gabrielcajigas/Desktop/M-app/Views/Home/Main.cshtml"
WriteAttributeValue("", 382, heroes.Id, 382, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(393, 105, true);
            WriteLiteral(" class=\"p-2 float-left\">X</a>\n            <div class=\"card-body\">\n                <h4 class=\"card-title\">");
            EndContext();
            BeginContext(499, 11, false);
#line 16 "/Users/gabrielcajigas/Desktop/M-app/Views/Home/Main.cshtml"
                                  Write(heroes.Name);

#line default
#line hidden
            EndContext();
            BeginContext(510, 44, true);
            WriteLiteral(" </h4>\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(555, 18, false);
#line 17 "/Users/gabrielcajigas/Desktop/M-app/Views/Home/Main.cshtml"
                                Write(heroes.Description);

#line default
#line hidden
            EndContext();
            BeginContext(573, 81, true);
            WriteLiteral(" </p>\n            </div>\n            <div class=\"card-footer\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 654, "\"", 717, 2);
            WriteAttributeValue("", 661, "https://comicstore.marvel.com/search?search=", 661, 44, true);
#line 20 "/Users/gabrielcajigas/Desktop/M-app/Views/Home/Main.cshtml"
WriteAttributeValue("", 705, heroes.Name, 705, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(718, 72, true);
            WriteLiteral(" target=\"_blank\" class=\"comicbutton comicbutton-accent\">More info about ");
            EndContext();
            BeginContext(791, 11, false);
#line 20 "/Users/gabrielcajigas/Desktop/M-app/Views/Home/Main.cshtml"
                                                                                                                                                     Write(heroes.Name);

#line default
#line hidden
            EndContext();
            BeginContext(802, 50, true);
            WriteLiteral("</a>\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 24 "/Users/gabrielcajigas/Desktop/M-app/Views/Home/Main.cshtml"
          }
         }
       

#line default
#line hidden
            BeginContext(884, 13, true);
            WriteLiteral("    </div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591