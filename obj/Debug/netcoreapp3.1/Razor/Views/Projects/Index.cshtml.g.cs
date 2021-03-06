#pragma checksum "E:\Personal\Portofolio\Views\Projects\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3188638f80fd21b883704ac91c718515c5c315ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Index), @"mvc.1.0.view", @"/Views/Projects/Index.cshtml")]
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
#line 1 "E:\Personal\Portofolio\Views\_ViewImports.cshtml"
using Portofolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Personal\Portofolio\Views\_ViewImports.cshtml"
using Portofolio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Personal\Portofolio\Views\_ViewImports.cshtml"
using Portofolio.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Personal\Portofolio\Views\_ViewImports.cshtml"
using static Portofolio.AppModels.Utils.KeyConstants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Personal\Portofolio\Views\_ViewImports.cshtml"
using static Portofolio.AppModels.Utils.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Personal\Portofolio\Views\_ViewImports.cshtml"
using Portofolio.AppModels.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3188638f80fd21b883704ac91c718515c5c315ad", @"/Views/Projects/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"123f75ec33827d5e3826a487286a977b19ac1d40", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Project thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "projects", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
  
    ViewData[TitleKey] = "Portofolio";
    ViewData[PaginationCurrentPage] = Model.PaginationModel.CurrentPage;
    ViewData[PaginationMaxPageCount] = Model.PaginationModel.MaxPageCount;
    ViewData[PaginationDisplayCount] = Model.PaginationModel.DisplayCount;
    ViewData[BannerTitleKey] = "Portofolio";

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
      
      await Html.RenderPartialAsync("_ShortBanner");
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Start popular-courses Area -->
<section class=""popular-courses-area section-gap courses-page"">
    <div class=""container"">
        <div class=""row d-flex justify-content-center"">
            <div class=""menu-content pb-70 col-lg-8"">
                <div class=""title text-center"">
                    <h1 class=""mb-10"">");
#nullable restore
#line 18 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                                 Write(ViewData[TitleKey]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                </div>\n            </div>\n        </div>\n        <div class=\"row\">\n");
#nullable restore
#line 23 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
             if (Model.PaginationModel.Collection != default(ICollection<Project>))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                 foreach(Project project in Model.PaginationModel.Collection)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""single-popular-carusel col-lg-3 col-md-6"">
                        <div class=""thumb-wrap relative"">
                            <div class=""thumb relative"">
                                <div class=""overlay overlay-bg""></div>     
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3188638f80fd21b883704ac91c718515c5c315ad7271", async() => {
                WriteLiteral("\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3188638f80fd21b883704ac91c718515c5c315ad7564", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1477, "~/", 1477, 2, true);
#nullable restore
#line 32 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
AddHtmlAttributeValue("", 1479, project.Thumbnail, 1479, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                                                                                        WriteLiteral(project.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                        </div>\n                        <div class=\"details\">\n                                <h4>\n                                    ");
#nullable restore
#line 38 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                               Write(project.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </h4>\n                            <p>");
#nullable restore
#line 40 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                          Write(project.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        </div>\n                    </div>\n");
#nullable restore
#line 43 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n");
#nullable restore
#line 46 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
      
        await Html.RenderPartialAsync("_PaginationPartial");
    

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\n<!-- End popular-courses Area -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
