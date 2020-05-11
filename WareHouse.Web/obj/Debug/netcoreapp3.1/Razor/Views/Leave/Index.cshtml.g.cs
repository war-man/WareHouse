#pragma checksum "C:\Users\Administrator\Desktop\WareHouse\WareHouse.Web\Views\Leave\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c2f65035cedd90b8b55b411384e4e4cf69385d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leave_Index), @"mvc.1.0.view", @"/Views/Leave/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3c2f65035cedd90b8b55b411384e4e4cf69385d", @"/Views/Leave/Index.cshtml")]
    public class Views_Leave_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\WareHouse\WareHouse.Web\Views\Leave\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <table class=""table table-striped table-hover"" id=""inside-table"">
    </table>
    <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" style=""display: none;"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">×</span></button>
                    <h4 class=""modal-title"" id=""myModalLabel"">详细信息</h4>
                </div>
                <div class=""modal-body"">
                    <p id=""goodsName""></p>
                    <p id=""typeName""></p>
                    <p id=""userName""></p>
                    <p id=""weight""></p>
                    <p id=""remarks""></p>
                    <p id=""storageName""></p>
                    <p id=""regionName""></p>
                </div>
                <div class=""modal-footer"">
                 ");
            WriteLiteral("   <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">关闭</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
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
                    title: ""所在仓库""
                }, {
                    field: ""regionName"",
                    title: ""所在区域""
                }, {
                    field: ""createdTime"",
                    title: ""入库时间""
                }, {
                    field: ""id"",
                  ");
                WriteLiteral(@"  title: ""操作"",
                    formatter: function (value, row, index) {
                        var html = '';
                        html += ""<button type='button' class='btn btn-default' data-toggle='modal' data-target='#myModal' onclick='detail("" + value + "")'>查看</button>"";
                        html += ""<button class='btn btn-default' onclick='edit("" + value + "")'>修改</button>"";
                        html += ""<button class='btn btn-default' onclick='leave("" + value + "")'>出库</button>"";
                        return html;
                    }
                }
            ]
        });

        function detail(id) {
            $.ajax({
                url: ""/Join/GetDetail"",
                data: {
                    id: id
                },
                type: ""get"",
                success: function (res) {
                    console.log(res);
                    $(""#goodsName"").html(""货物名称："" + res.data.goodsName);
                    $(""#typeName"").html(""分类名称："" + res");
                WriteLiteral(@".data.typeName);
                    $(""#userName"").html(""用户名称："" + res.data.userName);
                    $(""#weight"").html(""货物重量："" + res.data.weight);
                    $(""#remarks"").html(""货物备注："" + res.data.goodsRemarks);
                    $(""#storageName"").html(""所在仓库："" + res.data.storageName);
                    $(""#regionName"").html(""所在区域："" + res.data.regionName);
                }
            });
        };

        function edit(id) {
            window.location.href = """);
#nullable restore
#line 97 "C:\Users\Administrator\Desktop\WareHouse\WareHouse.Web\Views\Leave\Index.cshtml"
                               Write(Url.Action("Update"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?id=""+id;
        }

        function leave(id) {
            $.post({
                url: ""/Leave/GoodsLeave"",
                data: {
                    id:id
                },
                success: function(res) {
                    window.location.href = """);
#nullable restore
#line 107 "C:\Users\Administrator\Desktop\WareHouse\WareHouse.Web\Views\Leave\Index.cshtml"
                                       Write(Url.Action("Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                }\r\n            });\r\n        }\r\n    </script>\r\n");
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
