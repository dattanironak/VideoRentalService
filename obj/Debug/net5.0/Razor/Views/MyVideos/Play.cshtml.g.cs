#pragma checksum "C:\Users\dell\source\repos\VRSystem\Views\MyVideos\Play.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b0c82e387ef3d9ca9b78dd60b46917300f8fd6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyVideos_Play), @"mvc.1.0.view", @"/Views/MyVideos/Play.cshtml")]
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
#line 1 "C:\Users\dell\source\repos\VRSystem\Views\_ViewImports.cshtml"
using VRSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\source\repos\VRSystem\Views\_ViewImports.cshtml"
using VRSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b0c82e387ef3d9ca9b78dd60b46917300f8fd6d", @"/Views/MyVideos/Play.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3be27d1c0bc6a5939406859f4b6f41e8445a1fb", @"/Views/_ViewImports.cshtml")]
    public class Views_MyVideos_Play : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VRSystem.Models.Subscriptions>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\dell\source\repos\VRSystem\Views\MyVideos\Play.cshtml"
  
    var video = (Videos)ViewData["video"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"embed-responsive embed-responsive-16by9\">\r\n    <iframe class=\"embed-responsive-item\"");
            BeginWriteAttribute("src", " src=\"", 194, "\"", 240, 2);
            WriteAttributeValue("", 200, "https://localhost:44332/", 200, 24, true);
#nullable restore
#line 10 "C:\Users\dell\source\repos\VRSystem\Views\MyVideos\Play.cshtml"
WriteAttributeValue("", 224, video.VideoPath, 224, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" allowfullscreen></iframe>\r\n</div>\r\n\r\n\r\n<div>\r\n    \r\n    \r\n\r\n\r\n    <div>\r\n        <lable asp-for=\"Title\"><h2>");
#nullable restore
#line 20 "C:\Users\dell\source\repos\VRSystem\Views\MyVideos\Play.cshtml"
                              Write(video.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></lable>\r\n    </div>\r\n    <div>\r\n        <p>");
#nullable restore
#line 23 "C:\Users\dell\source\repos\VRSystem\Views\MyVideos\Play.cshtml"
      Write(video.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n    </div>\r\n    <div>\r\n        <h2>");
#nullable restore
#line 26 "C:\Users\dell\source\repos\VRSystem\Views\MyVideos\Play.cshtml"
       Write(video.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VRSystem.Models.Subscriptions> Html { get; private set; }
    }
}
#pragma warning restore 1591
