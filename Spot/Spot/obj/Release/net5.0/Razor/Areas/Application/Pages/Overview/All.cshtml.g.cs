#pragma checksum "C:\Users\Yuri\Desktop\Spot-main\Spot-main\Spot\Spot\Areas\Application\Pages\Overview\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5096143460317a1162b6bf3ef2225fb6f6ea03c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Application_Pages_Overview_All), @"mvc.1.0.razor-page", @"/Areas/Application/Pages/Overview/All.cshtml")]
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
#line 1 "C:\Users\Yuri\Desktop\Spot-main\Spot-main\Spot\Spot\Areas\Application\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yuri\Desktop\Spot-main\Spot-main\Spot\Spot\Areas\Application\Pages\_ViewImports.cshtml"
using Spot.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Yuri\Desktop\Spot-main\Spot-main\Spot\Spot\Areas\Application\Pages\Overview\All.cshtml"
using Spot.DataLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5096143460317a1162b6bf3ef2225fb6f6ea03c3", @"/Areas/Application/Pages/Overview/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1e48ff655a0d8ae3434b7645573bc678ffea715", @"/Areas/Application/Pages/_ViewImports.cshtml")]
    public class Areas_Application_Pages_Overview_All : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Application", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Editor/Watch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Yuri\Desktop\Spot-main\Spot-main\Spot\Spot\Areas\Application\Pages\Overview\All.cshtml"
   ViewData["Title"] = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\Users\Yuri\Desktop\Spot-main\Spot-main\Spot\Spot\Areas\Application\Pages\Overview\All.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 10 "C:\Users\Yuri\Desktop\Spot-main\Spot-main\Spot\Spot\Areas\Application\Pages\Overview\All.cshtml"
      
        var socialObjects = Model.socialObjects;
        foreach (var socialObject in Model.socialObjects)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict["socialObjectId"] = socialObject.Id.ToString();

            var presenter = Model.UserManager.FindByIdAsync(socialObject.PresenterId).Result;


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"p-1 mb-4 bg-light rounded-3 w-100 border border-5 rounded\">\r\n                <div class=\"container-fluid\">\r\n                    <h2 class=\"display-5 fw-bold\">");
#nullable restore
#line 21 "C:\Users\Yuri\Desktop\Spot-main\Spot-main\Spot\Spot\Areas\Application\Pages\Overview\All.cshtml"
                                             Write(socialObject.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                     <p><strong>");
#nullable restore
#line 22 "C:\Users\Yuri\Desktop\Spot-main\Spot-main\Spot\Spot\Areas\Application\Pages\Overview\All.cshtml"
                           Write(socialObject.Date.ToString("dd.MM HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> - через ");
#nullable restore
#line 22 "C:\Users\Yuri\Desktop\Spot-main\Spot-main\Spot\Spot\Areas\Application\Pages\Overview\All.cshtml"
                                                                                        Write((socialObject.Date - DateTime.Now).ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" дней</p>\r\n                    <hr/>\r\n                    <div class=\"border rounded bg-white\">\r\n                        <p>");
#nullable restore
#line 25 "C:\Users\Yuri\Desktop\Spot-main\Spot-main\Spot\Spot\Areas\Application\Pages\Overview\All.cshtml"
                      Write(socialObject.ShirtDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"d-flex justify-content-between\">\r\n                        <div class=\"border rounded bg-white w-25\">\r\n                            <p>");
#nullable restore
#line 29 "C:\Users\Yuri\Desktop\Spot-main\Spot-main\Spot\Spot\Areas\Application\Pages\Overview\All.cshtml"
                          Write(presenter.OrganisationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"btn btn-primary float-right\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5096143460317a1162b6bf3ef2225fb6f6ea03c37697", async() => {
                WriteLiteral("Подробнее");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 32 "C:\Users\Yuri\Desktop\Spot-main\Spot-main\Spot\Spot\Areas\Application\Pages\Overview\All.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = dict;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 37 "C:\Users\Yuri\Desktop\Spot-main\Spot-main\Spot\Spot\Areas\Application\Pages\Overview\All.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spot.Areas.Application.Pages.Overview.All> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Spot.Areas.Application.Pages.Overview.All> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Spot.Areas.Application.Pages.Overview.All>)PageContext?.ViewData;
        public Spot.Areas.Application.Pages.Overview.All Model => ViewData.Model;
    }
}
#pragma warning restore 1591
