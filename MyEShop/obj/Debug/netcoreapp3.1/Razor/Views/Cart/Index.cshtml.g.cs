#pragma checksum "C:\Users\Артём\source\repos\MyEShop\MyEShop\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81a0e809736de20a3d03b54734b6e415b202517d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81a0e809736de20a3d03b54734b6e415b202517d", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Артём\source\repos\MyEShop\MyEShop\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Артём\source\repos\MyEShop\MyEShop\Views\Cart\Index.cshtml"
 if (Model.CartLines.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Товаров в корзине нет</p> <a href=\"/\">Назад к товарам</a>\r\n");
#nullable restore
#line 9 "C:\Users\Артём\source\repos\MyEShop\MyEShop\Views\Cart\Index.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Артём\source\repos\MyEShop\MyEShop\Views\Cart\Index.cshtml"
     for (int i = 0; i < Model.CartLines.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            ");
#nullable restore
#line 15 "C:\Users\Артём\source\repos\MyEShop\MyEShop\Views\Cart\Index.cshtml"
       Write(Model.CartLines[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 15 "C:\Users\Артём\source\repos\MyEShop\MyEShop\Views\Cart\Index.cshtml"
                                   Write(Model.CartLines[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a");
            BeginWriteAttribute("href", " href=\"", 348, "\"", 385, 2);
            WriteAttributeValue("", 355, "/Cart/RemoveFromCart?Number=", 355, 28, true);
#nullable restore
#line 15 "C:\Users\Артём\source\repos\MyEShop\MyEShop\Views\Cart\Index.cshtml"
WriteAttributeValue("", 383, i, 383, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Убрать из корзины </a>\r\n        </li>\r\n");
#nullable restore
#line 17 "C:\Users\Артём\source\repos\MyEShop\MyEShop\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Артём\source\repos\MyEShop\MyEShop\Views\Cart\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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