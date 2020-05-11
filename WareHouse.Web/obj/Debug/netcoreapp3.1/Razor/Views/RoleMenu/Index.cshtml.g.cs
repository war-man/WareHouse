#pragma checksum "C:\Users\Administrator\Desktop\WareHouse\WareHouse.Web\Views\RoleMenu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7d2133cf6a90f25be3a30a44a467e3298c9547f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoleMenu_Index), @"mvc.1.0.view", @"/Views/RoleMenu/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7d2133cf6a90f25be3a30a44a467e3298c9547f", @"/Views/RoleMenu/Index.cshtml")]
    public class Views_RoleMenu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\WareHouse\WareHouse.Web\Views\RoleMenu\Index.cshtml"
  
    ViewData["Title"] = "权限管理";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""form-group"">
    <label for=""roleId"">角色</label>
    <select class=""form-control"" id=""roleId"" name=""roleId"" size=""1"" onchange=""getMenu(this.value)"">
        <option value=""0"">请选择角色</option>
    </select>
</div>
<div class=""table-responsive"">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>
                    <label class=""lyear-checkbox checkbox-primary"">
                        <input name=""checkbox"" type=""checkbox"" id=""check-all"">
                        <span> 全选</span>
                    </label>
                </th>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>
    <button class=""btn btn-primary"" id=""update-btn"">保存</button>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $.ajax({
            url: ""/RoleMenu/GetRole"",
            data: {},
            type: ""get"",
            success: function(res) {
                //console.log(res);
                var html = """";
                for (var i = 0; i < res.data.length; i++) {
                    //console.log(res.data[i].roleName);
                    html += ""<option value='"" + res.data[i].id + ""'>"" + res.data[i].roleName + ""</option>"";
                }
                $(""#roleId"").append(html);
            }
        });

        $.ajax({
            url: ""/RoleMenu/GetMenuTree"",
            data: {},
            type: ""get"",
            success: function(res) {
                console.log(res);
                var html = """";
                for (var i = 1; i < res.data.length + 1; i++) {
                    html +=
                        ""<tr><td><label class='lyear-checkbox checkbox-primary'><input type='checkbox' id='m"" +
                        res.data[i - 1].id +
      ");
                WriteLiteral(@"                  ""' class='checkbox-parent' dataid='id-"" +
                        i +
                        ""' value='"" +
                        res.data[i - 1].id +
                        ""'><span> "" +
                        res.data[i - 1].name +
                        ""</span></label></td></tr>"";
                    if (res.data[i - 1].menuList.length > 0) {
                        html += ""<tr><td class='p-l-20'>"";
                        for (var j = 1; j < res.data[i - 1].menuList.length + 1; j++) {
                            html +=
                                ""<label class='lyear-checkbox checkbox-primary checkbox-inline'><input type='checkbox' class='checkbox-child' id='m"" +
                                res.data[i - 1].menuList[j - 1].id +
                                ""' dataid='id-"" +
                                i +
                                ""-"" +
                                j +
                                ""' value='"" +
                         ");
                WriteLiteral(@"       res.data[i - 1].menuList[j - 1].id +
                                ""'><span> "" +
                                res.data[i - 1].menuList[j - 1].name +
                                ""</span></label>"";
                        }
                        html += ""</td></tr>"";
                    }
                }
                $(""tbody"").html(html);
                //动态选择框，上下级选中状态变化
                $('input.checkbox-parent').on('change',
                    function() {
                        var dataid = $(this).attr(""dataid"");
                        $('input[dataid^=' + dataid + '-]').prop('checked', $(this).is(':checked'));
                    }
                );
                $('input.checkbox-child').on('change',
                    function() {
                        var dataid = $(this).attr(""dataid"");
                        dataid = dataid.substring(0, dataid.lastIndexOf(""-""));
                        var parent = $('input[dataid=' + dataid + ']');
              ");
                WriteLiteral(@"          if ($(this).is(':checked')) {
                            parent.prop('checked', true);
                            //循环到顶级
                            while (dataid.lastIndexOf(""-"") != 2) {
                                dataid = dataid.substring(0, dataid.lastIndexOf(""-""));
                                parent = $('input[dataid=' + dataid + ']');
                                parent.prop('checked', true);
                            }
                        } else {
                            //父级
                            if ($('input[dataid^=' + dataid + '-]:checked').length == 0) {
                                parent.prop('checked', false);
                                //循环到顶级
                                while (dataid.lastIndexOf(""-"") != 2) {
                                    dataid = dataid.substring(0, dataid.lastIndexOf(""-""));
                                    parent = $('input[dataid=' + dataid + ']');
                                    if ($('input[d");
                WriteLiteral(@"ataid^=' + dataid + '-]:checked').length == 0) {
                                        parent.prop('checked', false);
                                    }
                                }
                            }
                        }
                    });
            }
        });

        $(""#update-btn"").click(function() {
            if ($(""#roleId"").val() === ""0"") {
                $.error(""请选择角色"");
                return 0;
            }
            else {
                $.post({
                    url: ""/RoleMenu/Update"",
                    data: {
                        roleId: $(""#roleId"").val(),
                        menuArray: GetArray()
                    },
                    success: function (res) {
                        if (res.code===200) {
                            $.message(""修改成功"");
                            setTimeout(function() {
                                window.location.href = """);
#nullable restore
#line 140 "C:\Users\Administrator\Desktop\WareHouse\WareHouse.Web\Views\RoleMenu\Index.cshtml"
                                                   Write(Url.Action("Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                            },2000);
                        }
                    }
                });
            }
            return 0;
        });

        function GetArray() {
            var checkId = [];//定义一个空数组
            var i = 0;
            $(""input[type='checkbox']:checked"").each(function () {//把所有被选中的复选框的值存入数组
                if ($(this).val() !== ""on"") {
                    checkId[i] = $(this).val();
                    i++;
                }
            });
            return checkId;
        }

        function getMenu(id) {
            $.ajax({
                url: ""/RoleMenu/GetMenuArray"",
                data: {
                    id:id
                },
                type: ""get"",
                success: function(res) {
                    console.log(res);
                    $(""input:checked"").each(function (i) {
                        $(this).prop(""checked"",false);
                    });
                    if (res.data.length > 0) {
   ");
                WriteLiteral("                     for (var i = 0; i < res.data.length; i++) {\r\n                            $(\"#m\" + res.data[i]).prop(\"checked\",true);\r\n                        }\r\n                    }\r\n                }\r\n            });\r\n        }\r\n    </script>\r\n");
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
