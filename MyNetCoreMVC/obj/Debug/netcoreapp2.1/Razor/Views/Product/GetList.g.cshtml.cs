#pragma checksum "C:\Users\win10pro\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\Product\GetList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b89d577442242c58c983b4a68752f577d3926c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetList), @"mvc.1.0.view", @"/Views/Product/GetList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/GetList.cshtml", typeof(AspNetCore.Views_Product_GetList))]
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
#line 1 "C:\Users\win10pro\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\_ViewImports.cshtml"
using MyNetCoreMVC;

#line default
#line hidden
#line 2 "C:\Users\win10pro\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\_ViewImports.cshtml"
using MyNetCoreMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b89d577442242c58c983b4a68752f577d3926c0", @"/Views/Product/GetList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e8349a69a9b9dbbc33631bafc0217674c3299b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\win10pro\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\Product\GetList.cshtml"
  
    ViewData["Title"] = "GetList";

#line default
#line hidden
            BeginContext(65, 50, true);
            WriteLiteral("<h2>List Product</h2>\r\n<div class=\"alert-success\">");
            EndContext();
            BeginContext(116, 19, false);
#line 6 "C:\Users\win10pro\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\Product\GetList.cshtml"
                      Write(TempData["message"]);

#line default
#line hidden
            EndContext();
            BeginContext(135, 170, true);
            WriteLiteral("</div>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Price</th>\r\n            <th>Handle</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 16 "C:\Users\win10pro\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\Product\GetList.cshtml"
         foreach (var product in Model)
        {

#line default
#line hidden
            BeginContext(357, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(396, 12, false);
#line 19 "C:\Users\win10pro\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\Product\GetList.cshtml"
               Write(product.name);

#line default
#line hidden
            EndContext();
            BeginContext(408, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(436, 13, false);
#line 20 "C:\Users\win10pro\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\Product\GetList.cshtml"
               Write(product.price);

#line default
#line hidden
            EndContext();
            BeginContext(449, 47, true);
            WriteLiteral("</td>\r\n                <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 496, "\"", 533, 2);
            WriteAttributeValue("", 503, "/Product/Update?id=", 503, 19, true);
#line 22 "C:\Users\win10pro\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\Product\GetList.cshtml"
WriteAttributeValue("", 522, product.id, 522, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(534, 23, true);
            WriteLiteral(">Edit</a> | <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 557, "\"", 573, 1);
#line 22 "C:\Users\win10pro\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\Product\GetList.cshtml"
WriteAttributeValue("", 562, product.id, 562, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(574, 74, true);
            WriteLiteral(" class=\"btn-delete\">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 25 "C:\Users\win10pro\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\Product\GetList.cshtml"
        }

#line default
#line hidden
            BeginContext(659, 764, true);
            WriteLiteral(@"    </tbody>
</table>
<script>
    var listBtnDelete = document.getElementByClassName(""btn-delete"");
    for (var i = 0; i < listBtnDelete.length; i++) {
        listBtnDelete[i].onclick = function () {
            if (confirm(""Are you sure?"")) {
                var currentDeleteButton = this;
                var deleteId = id;
                var xmlHttpRequest = new XMLHttpRequest();
                xmlHttpRequest.onreadystatechange = function () {
                    if (this.readyState === 4 && this.status === 200) {
                        alert(""Delete success"");
                    }
                }
                xmlHttpRequest.open(""DELETE"", ""/Product/Delete?id="" + deleteId, true);
            }
        };
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
