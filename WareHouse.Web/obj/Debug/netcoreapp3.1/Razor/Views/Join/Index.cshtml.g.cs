#pragma checksum "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Join\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b8523e7fb7f3eea0c91270b45cbddd65821b30d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Join_Index), @"mvc.1.0.view", @"/Views/Join/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b8523e7fb7f3eea0c91270b45cbddd65821b30d", @"/Views/Join/Index.cshtml")]
    public class Views_Join_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Join\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <button id=\"add-btn\" class=\"btn btn-cyan\">添加货物并入库</button>\r\n    <table class=\"table table-striped table-hover\" id=\"inside-table\">\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //$.ajax({
        //    url: '/Join/GetAllInside',
        //    data: {},
        //    type: 'get',
        //    success: function (res) {
        //        console.log(res);
        //    }
        //});

        $('#inside-table').bootstrapTable({
            method: 'get',
            url: ""/Join/GetAllInside"", //请求路径
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
                    field: ""goodsName"",
                    title: ""货物名称""
                }, {
                    field: ""storageName"",
                    title: ""仓库名称""
                }, {
                    fiel");
                WriteLiteral(@"d: ""regionName"",
                    title: ""区域名称""
                }, {
                    field: ""createdTime"",
                    title: ""入库时间""
                }
            ]
        });
    </script>

    <script>
        $(""#add-btn"").click(function() {
            window.location.href = """);
#nullable restore
#line 57 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Join\Index.cshtml"
                               Write(Url.Action("Create"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n        });\r\n    </script>\r\n");
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
