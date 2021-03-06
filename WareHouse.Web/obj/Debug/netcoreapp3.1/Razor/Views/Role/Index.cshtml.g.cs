#pragma checksum "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7b4c7408772e6b4b5559840ebfcfc99c1d78a52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Index), @"mvc.1.0.view", @"/Views/Role/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7b4c7408772e6b4b5559840ebfcfc99c1d78a52", @"/Views/Role/Index.cshtml")]
    public class Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Role\Index.cshtml"
  
    ViewData["Title"] = "角色管理";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <button id=\"add-btn\" class=\"btn btn-cyan\">添加角色</button>\r\n    <table class=\"table table-striped table-hover\" id=\"role-table\">\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('#role-table').bootstrapTable({
            method: 'get',
            url: ""/Role/GetRole"", //请求路径
            striped: true, //是否显示行间隔色
            pageNumber: 1, //初始化加载第一页
            pagination: true, //是否分页
            sidePagination: 'client', //server:服务器端分页|client：前端分页
            pageSize: 5, //单页记录数
            pageList: [5, 10, 20, 30], //可选择单页记录数
            showRefresh: true, //刷新按钮
            columns: [
                {
                    field: ""id"",
                    title: ""主键""
                }, {
                    field: ""roleName"",
                    title: ""用户名""
                }, {
                    field: ""id"",
                    title: ""操作"",
                    formatter: function(value, row, index) {
                        var html = '';
                        html += ""<button class='btn btn-default' onclick='edit("" + value + "")'>修改</button>"";
                        html += ""<button class='btn btn-default' onclick='del("" ");
                WriteLiteral("+ value + \")\'>删除</button>\";\r\n                        return html;\r\n                    }\r\n                }\r\n            ]\r\n        });\r\n\r\n        $(\"#add-btn\").click(function () {\r\n            window.location.href = \"");
#nullable restore
#line 45 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Role\Index.cshtml"
                               Write(Url.Action("Create"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n        });\r\n        function edit(id) {\r\n            window.location.href = \"");
#nullable restore
#line 48 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Role\Index.cshtml"
                               Write(Url.Action("Edit"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?id=""+id;
        }
        function del(id) {
            $.post({
                url: '/Role/DeleteRole',
                data: {
                    id:id
                },
                success: function (res) {
                    if (res.code===200) {
                        $.message(""删除成功"");
                        setTimeout(function() {
                            window.location.href = """);
#nullable restore
#line 60 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Role\Index.cshtml"
                                               Write(Url.Action("Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                        },1000);
                    }

                }
            });
        }

        function GetRole() {
            $.ajax({
                url: '/Role/GetPages',
                data: {},
                type: 'get',
                success: function (res) {
                    console.log(res);
                }
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
