#pragma checksum "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87acd622dbc36d23164fc9dca31cc9843ad8863c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductType_ListProductType), @"mvc.1.0.view", @"/Views/ProductType/ListProductType.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductType/ListProductType.cshtml", typeof(AspNetCore.Views_ProductType_ListProductType))]
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
#line 1 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\_ViewImports.cshtml"
using RestaurantDashboard;

#line default
#line hidden
#line 2 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\_ViewImports.cshtml"
using RestaurantDashboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87acd622dbc36d23164fc9dca31cc9843ad8863c", @"/Views/ProductType/ListProductType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a30fb93c464b6d2d2d8a64057aadea470f866e04", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductType_ListProductType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RestaurantDashboard.Models.ProductType.ProductTypeListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("ListProductType"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateProductType", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-fab btn-fab-md fab-right fab-right-bottom-fixed shadow btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
  
    ViewData["Title"] = "ListProductType";
    Layout = "~/Views/Shared/_Main_Layout.cshtml";

#line default
#line hidden
            BeginContext(171, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
  if (TempData["title"] != null)
    {



#line default
#line hidden
            BeginContext(218, 52, true);
            WriteLiteral("        <div class=\"toast\"\r\n             data-title=");
            EndContext();
            BeginContext(271, 28, false);
#line 12 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
                   Write(TempData["title"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(299, 29, true);
            WriteLiteral("\r\n             data-message=\'");
            EndContext();
            BeginContext(329, 30, false);
#line 13 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
                      Write(TempData["message"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(359, 26, true);
            WriteLiteral("\'\r\n             data-type=");
            EndContext();
            BeginContext(386, 16, false);
#line 14 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
                  Write(TempData["type"]);

#line default
#line hidden
            EndContext();
            BeginContext(402, 19, true);
            WriteLiteral(">\r\n        </div>\r\n");
            EndContext();
#line 16 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"


    }

    TempData["title"] = null;
    TempData["message"] = null;
    TempData["type"] = null;

#line default
#line hidden
            BeginContext(531, 145, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-12\">\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                ");
            EndContext();
            BeginContext(676, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f52939be9aa44328a30a66aff7b1efe8", async() => {
                BeginContext(699, 9, true);
                WriteLiteral("Dashboard");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(712, 130, true);
            WriteLiteral("\r\n            </li>\r\n            <li class=\"breadcrumb-item active\">ProductType List</li>\r\n\r\n        </ol>\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
            BeginContext(842, 1556, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a308f7adc054d279071a553644a8fc6", async() => {
                BeginContext(887, 90, true);
                WriteLiteral("\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card bg-white mb-3 font-weight-bold\">\r\n");
                EndContext();
                BeginContext(1255, 1136, true);
                WriteLiteral(@"            <div id=""collapseOne"" class=""panel-collapse collapse in"" aria-expanded=""true"" style="""">
                <div class=""card-body"">
                    <div class=""card-title""></div>
                    <div class=""row"">
                        <div class=""col-md-4 text-right"">
                            <label>Name</label>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""input-group"">
                                <input placeholder=""Customer Name"" class=""form-control r-0 light s-12 "" type=""text"">
                            </div>
                        </div>

                    </div>
                    <br>
                    <div class=""row"">
                        <div class=""col-md-6""></div>
                        <div class=""col-md-5 col-md-offset-5"">
                            <button type=""submit"" id=""search-customer"" class=""btn-fab shadow btn-primary icon-search""></button>
                    ");
                WriteLiteral("    </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2398, 1029, true);
            WriteLiteral(@"
<div class=""container-fluid my-3"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card no-b"">
                <div class=""card-body"">


                    <table class=""table table-light table-bordered table-hover data-tables ""
                           data-options='{""searching"":false}'>
                        <thead class=""bg-light text-black"">
                            <tr>
                                <th width=""10%"">ProductType Name</th>
                                <th width=""15%"">Punch Line</th>
                                <th width=""45%"">Description</th>
                                <th width=""10%"" class=""sorting_asc_disabled sorting_desc_disabled"">ProductType Image</th>
                                <th width=""10%"">Status</th>
                                <th width=""10%"" class=""sorting_asc_disabled sorting_desc_disabled"">Action</th>
                            </tr>
                        </thead>
                        <tbo");
            WriteLiteral("dy>\r\n");
            EndContext();
#line 91 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
                             foreach (var producttype in Model.ListProductTypeModel)
                                {

#line default
#line hidden
            BeginContext(3548, 115, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <label>");
            EndContext();
            BeginContext(3664, 27, false);
#line 95 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
                                      Write(producttype.ProductTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(3691, 130, true);
            WriteLiteral("</label>\r\n                                </td>\r\n                                <td>\r\n                                    <label>");
            EndContext();
            BeginContext(3822, 21, false);
#line 98 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
                                      Write(producttype.PunchLine);

#line default
#line hidden
            EndContext();
            BeginContext(3843, 130, true);
            WriteLiteral("</label>\r\n                                </td>\r\n                                <td>\r\n                                    <label>");
            EndContext();
            BeginContext(3974, 23, false);
#line 101 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
                                      Write(producttype.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3997, 87, true);
            WriteLiteral("</label>\r\n                                </td>\r\n                                <td>\r\n");
            EndContext();
#line 104 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
                                     if (@producttype.ProductTypeImage != null)
                                    {
                                        var base64 = Convert.ToBase64String(@producttype.ProductTypeImage);
                                        var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);

#line default
#line hidden
            BeginContext(4419, 44, true);
            WriteLiteral("                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\'", 4463, "\'", 4476, 1);
#line 108 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
WriteAttributeValue("", 4469, imgsrc, 4469, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4477, 46, true);
            WriteLiteral(" style=\"max-width:100px;max-height:100px\" />\r\n");
            EndContext();
#line 109 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(4641, 56, true);
            WriteLiteral(" <img src=\"\" style=\"max-width:100px;max-height:100px\" />");
            EndContext();
#line 111 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
                                                                                             }                                  

#line default
#line hidden
            BeginContext(4734, 77, true);
            WriteLiteral("                                </td>\r\n                                <td>\r\n");
            EndContext();
#line 114 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
                                     if (producttype.Status == "Active")
                                    {

#line default
#line hidden
            BeginContext(4924, 93, true);
            WriteLiteral("                                        <span class=\"badge badge-success r-5\">Active</span>\r\n");
            EndContext();
#line 117 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"

                                    }

#line default
#line hidden
            BeginContext(5058, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 119 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
                                     if (producttype.Status == "Inactive")
                                    {


#line default
#line hidden
            BeginContext(5175, 95, true);
            WriteLiteral("                                        <span class=\"badge badge-warning r-5\">Inactive</span>\r\n");
            EndContext();
#line 123 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5309, 115, true);
            WriteLiteral("                                </td>\r\n                                <td>\r\n\r\n                                    ");
            EndContext();
            BeginContext(5424, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0e2ae04a15042f28752dce5f014ce14", async() => {
                BeginContext(5480, 41, true);
                WriteLiteral("<i class=\"icon-edit lblue-text mr-3\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5433, "~/ProductType/EditProductType/", 5433, 30, true);
#line 127 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
AddHtmlAttributeValue("", 5463, producttype.Id, 5463, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5525, 40, true);
            WriteLiteral("\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5565, "\"", 5618, 2);
            WriteAttributeValue("", 5572, "/ProductType/DeleteProductType/", 5572, 31, true);
#line 128 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
WriteAttributeValue("", 5603, producttype.Id, 5603, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5619, 116, true);
            WriteLiteral("><i class=\"icon-trash text-red\"></i></a>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 131 "D:\CRM\CRMRestaurantGitHub\RestaurantDashboard\Views\ProductType\ListProductType.cshtml"
                                }

#line default
#line hidden
            BeginContext(5770, 150, true);
            WriteLiteral("                        </tbody>\r\n\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(5920, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62ac7dac0e0a48e8bc9658e48105de6a", async() => {
                BeginContext(6033, 24, true);
                WriteLiteral("<i class=\"icon-add\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6061, 100, true);
            WriteLiteral("\r\n<script>\r\n    //onload start\r\n\r\n    $(\".alert\").fadeOut(5000);//fade out error messages</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantDashboard.Models.ProductType.ProductTypeListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
