#pragma checksum "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d5661c494422cf8c7f703b39171e91dc48d3534"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RoomManage), @"mvc.1.0.view", @"/Views/Admin/RoomManage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/RoomManage.cshtml", typeof(AspNetCore.Views_Admin_RoomManage))]
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
#line 1 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\_ViewImports.cshtml"
using MiniProject;

#line default
#line hidden
#line 2 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\_ViewImports.cshtml"
using MiniProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d5661c494422cf8c7f703b39171e91dc48d3534", @"/Views/Admin/RoomManage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"995f6496ea3e0f3b56c0144e78006c50eacee8cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RoomManage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MiniProject.External.PaginatedList<MiniProject.Models.Room>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "AddEdit_Partial/_partial_AddEdit_Room", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoomManage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link choose"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
  
    ViewData["Title"] = "Room Manage";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(167, 635, true);
            WriteLiteral(@"
<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-dark"">Room Management</h6>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <div class=""row ml-1 mr-1"">
                <div class=""col-sm-12 col-md-6 mt-3"">
                    <i class=""fa fa-circle text-success""></i> &nbsp;&nbsp; Room List
                </div>
                <div class=""col-sm-12 col-md-6 mt-3"" align=""right"">
                    <button data-toggle=""modal"" data-target=""#add-modal"" class=""btn btn-primary""> Create </button>
                    ");
            EndContext();
            BeginContext(802, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d5661c494422cf8c7f703b39171e91dc48d35345608", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 19 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new Room();

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(876, 444, true);
            WriteLiteral(@"
                </div>
            </div>
            <table class=""table"" id=""dataTable"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Room</th>
                        <th>Room Description</th>
                        <th>Status</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 33 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1393, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1456, 7, false);
#line 36 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1463, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1503, 9, false);
#line 37 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1512, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1552, 16, false);
#line 38 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
                           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1568, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1608, 44, false);
#line 39 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
                           Write(Html.Raw(item.Get_RoomStatusEnumWithColor()));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 221, true);
            WriteLiteral("</td>\r\n\r\n                            <td class=\"options\">\r\n                                <div class=\"btn-group\">\r\n                                    <a href=\"javascript:void(0)\" title=\"Update\" data-target=\"#edit-modal_");
            EndContext();
            BeginContext(1874, 7, false);
#line 43 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
                                                                                                    Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1881, 246, true);
            WriteLiteral("\" data-toggle=\"modal\">\r\n                                        <i class=\"fa fa-cog fa-fw\"></i>\r\n                                    </a>\r\n                                    <a href=\"javascript:void(0)\" title=\"Delete\" data-target=\"#delete-modal_");
            EndContext();
            BeginContext(2128, 7, false);
#line 46 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
                                                                                                      Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2135, 213, true);
            WriteLiteral("\" data-toggle=\"modal\">\r\n                                        <i class=\"fa fa-times fa-fw\"></i>\r\n                                    </a>\r\n                                </div>\r\n                                ");
            EndContext();
            BeginContext(2348, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d5661c494422cf8c7f703b39171e91dc48d353411185", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 50 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2418, 102, true);
            WriteLiteral("\r\n                                \r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 54 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
                    }

#line default
#line hidden
            BeginContext(2543, 109, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"card-footer\">\r\n");
            EndContext();
#line 61 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
          
            var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
            var nextDisabled = !Model.HasNextPage ? "disabled" : "";
            var pageStart = Model.PageIndex;
            if (Model.PageIndex >= 2)
            {
                pageStart = Model.PageIndex == 2 ? 1 : pageStart - 2;
            }
        

#line default
#line hidden
            BeginContext(3005, 90, true);
            WriteLiteral("        <nav class=\"pull-right\">\r\n            <ul class=\"pagination\">\r\n                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3095, "\"", 3126, 2);
            WriteAttributeValue("", 3103, "page-item", 3103, 9, true);
#line 72 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
WriteAttributeValue(" ", 3112, prevDisabled, 3113, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3127, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(3150, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d5661c494422cf8c7f703b39171e91dc48d353414512", async() => {
                BeginContext(3283, 84, true);
                WriteLiteral("\r\n                        <span aria-hidden=\"true\">&lt;</span>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
                            WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3371, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 79 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
                 for (int i = pageStart; i < Model.PageIndex + 4 && i <= Model.TotalPages; i++)
                {
                    var disabled = Model.PageIndex == i ? "disabled" : "";

#line default
#line hidden
            BeginContext(3588, 23, true);
            WriteLiteral("                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3611, "\"", 3638, 2);
            WriteAttributeValue("", 3619, "page-item", 3619, 9, true);
#line 82 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
WriteAttributeValue(" ", 3628, disabled, 3629, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3639, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(3666, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d5661c494422cf8c7f703b39171e91dc48d353417985", async() => {
                BeginContext(3794, 55, true);
                WriteLiteral("\r\n                            <span aria-hidden=\"true\">");
                EndContext();
                BeginContext(3850, 1, false);
#line 86 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
                                                Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(3851, 33, true);
                WriteLiteral("</span>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
                               WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3888, 29, true);
            WriteLiteral("\r\n                    </li>\r\n");
            EndContext();
#line 89 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
                }

#line default
#line hidden
            BeginContext(3936, 21, true);
            WriteLiteral("\r\n                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3957, "\"", 3988, 2);
            WriteAttributeValue("", 3965, "page-item", 3965, 9, true);
#line 91 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
WriteAttributeValue(" ", 3974, nextDisabled, 3975, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3989, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(4012, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d5661c494422cf8c7f703b39171e91dc48d353421654", async() => {
                BeginContext(4145, 84, true);
                WriteLiteral("\r\n                        <span aria-hidden=\"true\">&gt;</span>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "C:\Users\tai02\source\repos\MiniProject\MiniProject\Views\Admin\RoomManage.cshtml"
                            WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4233, 80, true);
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n        </nav>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MiniProject.External.PaginatedList<MiniProject.Models.Room>> Html { get; private set; }
    }
}
#pragma warning restore 1591