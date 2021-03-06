#pragma checksum "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Join\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d984045aaf4cbb03f0774cfe95ebbbec1f6389a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Join_Create), @"mvc.1.0.view", @"/Views/Join/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d984045aaf4cbb03f0774cfe95ebbbec1f6389a8", @"/Views/Join/Create.cshtml")]
    public class Views_Join_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Join\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"form-group\">\r\n    <label for=\"name\">名称</label>\r\n    <input class=\"form-control\" type=\"text\" id=\"name\" name=\"name\" placeholder=\"请输入货物名称..\"");
            BeginWriteAttribute("required", " required=\"", 240, "\"", 251, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n<div class=\"form-group\">\r\n    <label for=\"weight\">重量</label>\r\n    <input class=\"form-control\" type=\"text\" id=\"weight\" name=\"weight\" onkeyup=\"checkInputIntFloat(this);\" placeholder=\"请输入货物重量..\"");
            BeginWriteAttribute("required", " required=\"", 454, "\"", 465, 0);
            EndWriteAttribute();
            WriteLiteral(@">
</div>
<div class=""form-group"">
    <label for=""userId"">用户</label>
    <select class=""form-control"" id=""userId"" name=""userId"" size=""1"">
        <option value=""0"">请选择所属用户</option>
    </select>
</div>
<div class=""form-group"">
    <label for=""typeId"">种类</label>
    <select class=""form-control"" id=""typeId"" name=""typeId"" size=""1"">
        <option value=""0"">请选择种类</option>
    </select>
</div>
<div class=""form-group"">
    <label for=""remarks"">备注</label>
    <input class=""form-control"" type=""text"" id=""remarks"" name=""remarks"" placeholder=""请输入货物备注..""");
            BeginWriteAttribute("required", " required=\"", 1031, "\"", 1042, 0);
            EndWriteAttribute();
            WriteLiteral(@">
</div>
<div class=""form-group"">
    <label for=""storageId"">仓库</label>
    <select class=""form-control"" id=""storageId"" name=""storageId"" size=""1"" onchange=""getRegion(this.value)"">
        <option value=""0"">请选择仓库</option>
    </select>
</div>
<div class=""form-group"">
    <label for=""regionId"">区域</label>
    <select class=""form-control"" id=""regionId"" name=""regionId"" size=""1"">
        <option value=""0"">请选择区域</option>
    </select>
</div>
<div class=""form-group"">
    <button id=""add-btn"" class=""btn btn-primary"" type=""submit"">添加</button>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function checkInputIntFloat(oInput) {
            if ('' !== oInput.value.replace(/\d{1,}\.{0,1}\d{0,}/, '')) {
                oInput.value = oInput.value.match(/\d{1,}\.{0,1}\d{0,}/) == null ? '' : oInput.value.match(/\d{1,}\.{0,1}\d{0,}/);
            }
        }
        $.ajax({
            url: '/Join/GetJoinModel',
            data: {},
            type: 'get',
            success: function (res) {
                console.log(res);
                var html = """";
                for (var i = 0; i < res.data.goodsTypeList.length; i++) {
                    html += ""<option value='"" + res.data.goodsTypeList[i].id + ""'>"" + res.data.goodsTypeList[i].name + ""</option>"";
                }
                $(""#typeId"").append(html);

                html = """";
                for (var i = 0; i < res.data.storageList.length; i++) {
                    html += ""<option value='"" + res.data.storageList[i].id + ""'>"" + res.data.storageList[i].name + ""</option>"";
            ");
                WriteLiteral(@"    }
                $(""#storageId"").append(html);

                html = """";
                for (var i = 0; i < res.data.usersList.length; i++) {
                    html += ""<option value='"" + res.data.usersList[i].id + ""'>"" + res.data.usersList[i].name + ""</option>"";
                }
                $(""#userId"").append(html);

            }
        });
        function getRegion(id) {
            $.ajax({
                url: '/Join/GetRegion',
                data: {
                    id: id
                },
                type: 'get',
                success: function (res) {

                    if (res.data.region.length === 0) {
                        $(""#regionId"").empty();
                        $(""#regionId"").append(""<option value='0'>该仓库没有划分区域，请前往仓库进行设置</option>"");
                    } else {
                        var html = ""<option value='0'>请选择区域</option>"";
                        for (var i = 0; i < res.data.region.length; i++) {
                        ");
                WriteLiteral(@"    html += ""<option value='"" + res.data.region[i].id + ""'>"" + res.data.region[i].name + ""</option>"";
                        }
                        $(""#regionId"").empty();
                        $(""#regionId"").append(html);
                    }

                }
            });
        }

        $(""#add-btn"").click(function () {
            var data = {
                name: $(""#name"").val(),
                weight: $(""#weight"").val(),
                userId: $(""#userId"").val(),
                typeId: $(""#typeId"").val(),
                remarks: $(""#remarks"").val(),
                storageId: $(""#storageId"").val(),
                regionId: $(""#regionId"").val()
            };
            $.post({
                url: """);
#nullable restore
#line 116 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Join\Create.cshtml"
                 Write(Url.Action("Join"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                data: data,
                success: function(res) {
                    if (res.code === 200) {
                        $.message(res.message);
                        setTimeout(function() {
                            window.location.href = """);
#nullable restore
#line 122 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Join\Create.cshtml"
                                               Write(Url.Action("Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                        },1000);\r\n                    }\r\n                }\r\n            });\r\n        });\r\n    </script>\r\n");
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
