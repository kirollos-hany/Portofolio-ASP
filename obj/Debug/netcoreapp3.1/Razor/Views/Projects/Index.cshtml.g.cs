#pragma checksum "E:\Personal\Portofolio\Views\Projects\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "163d32799a57897ed83eddee4b22f75c5edc4ad8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Index), @"mvc.1.0.view", @"/Views/Projects/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
using Json.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163d32799a57897ed83eddee4b22f75c5edc4ad8", @"/Views/Projects/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a889185462bfe6c12d923c7c3eff1ad55cc77043", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Project>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
  
    ViewData[TitleKey] = "Projects";
    ViewData[BannerNavActionKey] = "index";
    ViewData[BannerNavControllerKey] = "projects";
    ViewData[BannerNavTitleKey] = ViewData[TitleKey];
    ViewData[BannerTitleKey] = ViewData[TitleKey];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Start popular-courses Area -->
<section class=""popular-courses-area section-gap courses-page"">
    <div class=""container"">
        <div class=""row d-flex justify-content-center"">
            <div class=""menu-content pb-70 col-lg-8"">
                <div class=""title text-center"">
                    <h1 class=""mb-10"">Our ");
#nullable restore
#line 16 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                                     Write(ViewData[TitleKey]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 21 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
             if (Model.Count != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                 foreach (Project project in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""single-popular-carusel col-lg-3 col-md-6"">
                        <div class=""thumb-wrap relative"">
                            <div class=""thumb relative"">
                                <div class=""overlay overlay-bg""></div>
");
#nullable restore
#line 29 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                                  
                                    var thumbnail = project.ProjectImages.Where((pi) => pi.Type.ImgType == "Thumbnail").FirstOrDefault<ProjectImage>();
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                                 if(thumbnail.ImagePath.StartsWith("~"))
                                {
                                    var imgSrc = @Url.Content(thumbnail.ImagePath);
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<img class=\"img-fluid\" src=\"imgSrc\" alt=\"Project thumbnail\">\r\n");
#nullable restore
#line 36 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                                }else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "163d32799a57897ed83eddee4b22f75c5edc4ad87938", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1780, "~/projects/image/", 1780, 17, true);
#nullable restore
#line 38 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
AddHtmlAttributeValue("", 1797, thumbnail.Id, 1797, 13, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 39 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                        <div class=\"details\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "163d32799a57897ed83eddee4b22f75c5edc4ad89915", async() => {
                WriteLiteral("\r\n                                <h4>\r\n                                    ");
#nullable restore
#line 45 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                               Write(project.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </h4>\r\n                            ");
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
#line 43 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
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
            WriteLiteral("\r\n                            <p>");
#nullable restore
#line 48 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                          Write(project.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 51 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "E:\Personal\Portofolio\Views\Projects\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n</section>\r\n<!-- End popular-courses Area -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
