#pragma checksum "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "509591d4880e2381102861b9be76b1344a72111b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_ProductAttributeCombinationGeneratePopup), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/ProductAttributeCombinationGeneratePopup.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 7 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Services.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"509591d4880e2381102861b9be76b1344a72111b", @"/Areas/Admin/Views/Product/ProductAttributeCombinationGeneratePopup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9afeeb77ddd3a4a2e0698ab1d31f0fa32cb5e81", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_ProductAttributeCombinationGeneratePopup : Nop.Web.Framework.Mvc.Razor.NopRazorPage<ProductAttributeCombinationModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductAttributeCombinationGeneratePopup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
  
    Layout = "_AdminPopupLayout";

    //page title
    ViewBag.PageTitle = T("Admin.Catalog.Products.ProductAttributes.AttributeCombinations.GenerateSeveralTitle").Text;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
 if (ViewBag.RefreshPage == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\r\n        try {window.opener.document.forms[\'");
#nullable restore
#line 13 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
                                       Write(Context.Request.Query["formId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'].");
#nullable restore
#line 13 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
                                                                            Write(Context.Request.Query["btnId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".click();}\r\n        catch (e){}\r\n        window.close();\r\n</script>\r\n");
#nullable restore
#line 17 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
 if (Model.Warnings.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"callout callout-danger\">\r\n        <ul>\r\n");
#nullable restore
#line 23 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
             foreach (var warning in Model.Warnings)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 25 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
               Write(warning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 26 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n");
#nullable restore
#line 29 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "509591d4880e2381102861b9be76b1344a72111b18681", async() => {
                WriteLiteral("\r\n    <div class=\"content-header clearfix\">\r\n        <h1 class=\"pull-left\">\r\n            ");
#nullable restore
#line 37 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
       Write(T("Admin.Catalog.Products.ProductAttributes.AttributeCombinations.GenerateSeveralTitle"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </h1>\r\n        <div class=\"pull-right\">\r\n            <button type=\"submit\" name=\"save\" class=\"btn bg-blue\">\r\n                <i class=\"fa fa-floppy-o\"></i>\r\n                ");
#nullable restore
#line 42 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
           Write(T("Admin.Catalog.Products.ProductAttributes.AttributeCombinations.Generate"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </button>\r\n            ");
#nullable restore
#line 44 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
       Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.ProductAttributeCombinationDetailsButtons }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"content\">\r\n        <h4>");
#nullable restore
#line 48 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
       Write(T("Admin.Catalog.Products.ProductAttributes.AttributeCombinations.RequiredAttribute"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n        <div class=\"form-horizontal\">\r\n");
#nullable restore
#line 50 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
             foreach (var attribute in Model.ProductAttributes)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"panel-group\">\r\n                    <div class=\"panel panel-default\">\r\n                        <div class=\"panel-heading\">\r\n                            ");
#nullable restore
#line 55 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
                        Write(attribute.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
                             if (attribute.IsRequired)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <span>*</span>\r\n");
#nullable restore
#line 59 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                        <div class=\"panel-body\">\r\n");
#nullable restore
#line 62 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
                             foreach (var attributeValue in attribute.Values)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div>\r\n                                    <input");
                BeginWriteAttribute("id", " id=\"", 2510, "\"", 2551, 2);
                WriteAttributeValue("", 2515, "attribute_value_", 2515, 16, true);
#nullable restore
#line 65 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
WriteAttributeValue("", 2531, attributeValue.Id, 2531, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 2568, "\"", 2596, 1);
#nullable restore
#line 65 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
WriteAttributeValue("", 2576, attributeValue.Id, 2576, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2597, "\"", 2640, 2);
                WriteAttributeValue("", 2604, "attribute_value_", 2604, 16, true);
#nullable restore
#line 65 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
WriteAttributeValue("", 2620, attributeValue.Id, 2620, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 65 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
                                                                                                                                                                          Write(attributeValue.Checked);

#line default
#line hidden
#nullable disable
                WriteLiteral("/>\r\n                                    <label");
                BeginWriteAttribute("for", " for=\"", 2713, "\"", 2755, 2);
                WriteAttributeValue("", 2719, "attribute_value_", 2719, 16, true);
#nullable restore
#line 66 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
WriteAttributeValue("", 2735, attributeValue.Id, 2735, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 66 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
                                                                                  Write(attributeValue.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                </div>\r\n");
#nullable restore
#line 68 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 72 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
               WriteLiteral(Context.Request.Query["productId"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
           WriteLiteral(Context.Request.Query["btnId"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["btnId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-btnId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["btnId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\nybsys\Downloads\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Product\ProductAttributeCombinationGeneratePopup.cshtml"
            WriteLiteral(Context.Request.Query["formId"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["formId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-formId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["formId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Nop.Services.Common.IGenericAttributeService genericAttributeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductAttributeCombinationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
