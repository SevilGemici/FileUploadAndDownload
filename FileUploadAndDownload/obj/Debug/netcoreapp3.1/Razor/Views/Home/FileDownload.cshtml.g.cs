#pragma checksum "C:\Users\Sevil\source\repos\FileUploadAndDownload\FileUploadAndDownload\Views\Home\FileDownload.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "619f4581ec1805eccbfedcbc7da5d68d7dea29b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FileDownload), @"mvc.1.0.view", @"/Views/Home/FileDownload.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Sevil\source\repos\FileUploadAndDownload\FileUploadAndDownload\Views\_ViewImports.cshtml"
using FileUploadAndDownload;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sevil\source\repos\FileUploadAndDownload\FileUploadAndDownload\Views\_ViewImports.cshtml"
using FileUploadAndDownload.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"619f4581ec1805eccbfedcbc7da5d68d7dea29b2", @"/Views/Home/FileDownload.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98c145de40ced33d15a0b5cd22719b643d84b73f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FileDownload : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Sevil\source\repos\FileUploadAndDownload\FileUploadAndDownload\Views\Home\FileDownload.cshtml"
  
    ViewData["Title"] = "FileDownload";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <table class=\"table table-responsive table-bordered\">\r\n        <tr>\r\n            <th>File Name</th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 13 "C:\Users\Sevil\source\repos\FileUploadAndDownload\FileUploadAndDownload\Views\Home\FileDownload.cshtml"
         foreach (FileModel file in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\Sevil\source\repos\FileUploadAndDownload\FileUploadAndDownload\Views\Home\FileDownload.cshtml"
               Write(file.FileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 405, "\"", 454, 2);
            WriteAttributeValue("", 412, "/Home/DownloadFile?filename=", 412, 28, true);
#nullable restore
#line 17 "C:\Users\Sevil\source\repos\FileUploadAndDownload\FileUploadAndDownload\Views\Home\FileDownload.cshtml"
WriteAttributeValue("", 440, file.FileName, 440, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Download</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 19 "C:\Users\Sevil\source\repos\FileUploadAndDownload\FileUploadAndDownload\Views\Home\FileDownload.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n\r\n");
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
