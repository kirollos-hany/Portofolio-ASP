#pragma checksum "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74f99e7678d0c05e98b95bbcafa74df999917292"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_ContactDetails), @"mvc.1.0.view", @"/Views/Contact/ContactDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f99e7678d0c05e98b95bbcafa74df999917292", @"/Views/Contact/ContactDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"873aa7117a6b910c553a6134154629e501a7c82e", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_ContactDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mdi mdi-delete-forever clickable light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("is-delete", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editcontactstatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
  
  Layout = "_DashboardLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--Start Profile Card-->

<div class=""page-content page-container"" id=""page-content"">
  <div class=""padding"">
    <div class=""row container d-flex justify-content-center"">
      <div class=""col-xl-12 col-md-12"">
        <div class=""card user-card-full"">
          <div class=""row m-l-0 m-r-0"">
            <div class=""col-sm-4 bg-c-lite-green user-profile"">
              <div class=""card-block text-center text-white"">
                <h6 class=""f-w-600"">");
#nullable restore
#line 15 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                               Write(Model.Contact.ContactName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p>Created : ");
#nullable restore
#line 16 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                        Write(Model.Contact.CreatedAt.ToString("ddd, dd MMM yyyy hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Updated : ");
#nullable restore
#line 17 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                        Write(Model.Contact.UpdatedAt.ToString("ddd, dd MMM yyyy hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <i class=\"mdi mdi-square-edit-outline feather icon-edit m-t-10 f-16 clickable\" data-toggle=\"modal\"\r\n                  data-target=\"#editProfileModal\"></i>\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74f99e7678d0c05e98b95bbcafa74df9999172929565", async() => {
                WriteLiteral("\r\n\r\n                  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                                                                                                                   WriteLiteral(Model.Contact.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
              </div>
            </div>
            <div class=""col-sm-8"">
              <div class=""card-block"">
                <h6 class=""m-b-20 p-b-5 b-b-default f-w-600 dark"">Details</h6>
                <div class=""row"">
                  <div class=""col-sm-6"">
                    <p class=""m-b-10 f-w-600 dark"">Email</p>
                    <h6 class=""text-muted f-w-400"">
                      ");
#nullable restore
#line 32 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                 Write(Model.Contact.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h6>\r\n                  </div>\r\n                  <div class=\"col-sm-6\">\r\n                    <p class=\"m-b-10 f-w-600 dark\">Phone</p>\r\n                    <h6 class=\"text-muted f-w-400\">");
#nullable restore
#line 37 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                                              Write(Model.Contact.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                  </div>\r\n                  <div class=\"col-sm-6\">\r\n                    <p class=\"m-b-10 f-w-600 dark\">Status</p>\r\n                    <h6 class=\"text-muted f-w-400\">");
#nullable restore
#line 41 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                                              Write(Model.Contact.Status.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                  </div>
                </div>
                <h6 class=""m-b-20 m-t-40 p-b-5 b-b-default f-w-600 dark"">
                  Services
                </h6>
                <div class=""row"">
                  <div class=""col-sm-6"">
");
#nullable restore
#line 49 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                     if (Model.Contact.RequestedServices != default(ICollection<RequestedService>))
                    {
                      foreach (var service in Model.Contact.RequestedServices)
                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h6 class=\"text-muted f-w-400\">");
#nullable restore
#line 53 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                                                  Write(service.AssociatedService.ServiceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 54 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                      }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>
<!--End Profile Card-->

<!-- Modal HTML Markup -->
<div id=""editProfileModal"" class=""modal fade"">
  <div class=""modal-dialog"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h4 class=""modal-title text-xs-center"">Edit Contact</h4>
      </div>
      <div class=""modal-body"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74f99e7678d0c05e98b95bbcafa74df99991729215466", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 78 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
         if(TempData[ResultMessageKey] != null)
        {
          ResultMsgViewModel resultVM = TempData.GetResultMessage();

#line default
#line hidden
#nullable disable
                WriteLiteral("          <div class=\"modal-header\">\r\n          <div");
                BeginWriteAttribute("class", " class=\"", 3444, "\"", 3470, 1);
#nullable restore
#line 82 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
WriteAttributeValue("", 3452, resultVM.CssClass, 3452, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 82 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                                     Write(resultVM.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n          </div>\r\n");
#nullable restore
#line 84 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "74f99e7678d0c05e98b95bbcafa74df99991729216913", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                          WriteLiteral(Model.Contact.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 85 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Contact.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          <div class=\"form-group\">\r\n            <label class=\"control-label\">Status</label>\r\n            <div>\r\n              <input type=\"text\" class=\"form-control input-lg\"");
                BeginWriteAttribute("value", " value=\"", 3789, "\"", 3825, 1);
#nullable restore
#line 89 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
WriteAttributeValue("", 3797, Model.Contact.Status.Status, 3797, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n            </div>\r\n          </div>\r\n          <div class=\"form-group\">\r\n            <label class=\"control-label\">Statuses</label>\r\n            <div>\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74f99e7678d0c05e98b95bbcafa74df99991729220007", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 96 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                 if(Model.ContactStatuses != default(ICollection<ContactStatus>))
                  {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                     foreach (var status in Model.ContactStatuses)
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                      ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74f99e7678d0c05e98b95bbcafa74df99991729220834", async() => {
#nullable restore
#line 100 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                                             Write(status.Status);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                         WriteLiteral(status.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 101 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
                     
                  }

#line default
#line hidden
#nullable disable
                    WriteLiteral("              ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 95 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StatusId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74f99e7678d0c05e98b95bbcafa74df99991729224400", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 104 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StatusId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n          </div>\r\n          <button type=\"submit\" class=\"btn-primary btn-block btn-rounded\">\r\n            Edit\r\n          </button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      </div>\r\n    </div>\r\n    <!-- /.modal-content -->\r\n  </div>\r\n  <!-- /.modal-dialog -->\r\n</div>\r\n");
#nullable restore
#line 117 "E:\Personal\Portofolio\Views\Contact\ContactDetails.cshtml"
  
  await Html.RenderPartialAsync("_DeleteBtnPartial");

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- /.modal -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
