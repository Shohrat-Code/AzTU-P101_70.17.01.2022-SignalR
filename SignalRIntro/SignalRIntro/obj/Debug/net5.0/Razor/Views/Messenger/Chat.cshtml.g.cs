#pragma checksum "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\70.17.01.2022-SignalR\Codes\SignalRIntro\SignalRIntro\Views\Messenger\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aabc83af515f0f231760f389c04899484d3a2e50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messenger_Chat), @"mvc.1.0.view", @"/Views/Messenger/Chat.cshtml")]
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
#line 1 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\70.17.01.2022-SignalR\Codes\SignalRIntro\SignalRIntro\Views\_ViewImports.cshtml"
using SignalRIntro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\70.17.01.2022-SignalR\Codes\SignalRIntro\SignalRIntro\Views\_ViewImports.cshtml"
using SignalRIntro.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\70.17.01.2022-SignalR\Codes\SignalRIntro\SignalRIntro\Views\_ViewImports.cshtml"
using SignalRIntro.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\70.17.01.2022-SignalR\Codes\SignalRIntro\SignalRIntro\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aabc83af515f0f231760f389c04899484d3a2e50", @"/Views/Messenger/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c13370ba8506de65f0de2b617bfaa054ee7a96ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Messenger_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmChat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\70.17.01.2022-SignalR\Codes\SignalRIntro\SignalRIntro\Views\Messenger\Chat.cshtml"
  
    ViewData["Title"] = "Chat";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1>Messenger with ");
#nullable restore
#line 10 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\70.17.01.2022-SignalR\Codes\SignalRIntro\SignalRIntro\Views\Messenger\Chat.cshtml"
                          Write(Model.Reciever.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <div class=\"messageBox\">\r\n");
#nullable restore
#line 12 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\70.17.01.2022-SignalR\Codes\SignalRIntro\SignalRIntro\Views\Messenger\Chat.cshtml"
                 foreach (var item in Model.Messages)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 380, "\"", 454, 1);
#nullable restore
#line 14 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\70.17.01.2022-SignalR\Codes\SignalRIntro\SignalRIntro\Views\Messenger\Chat.cshtml"
WriteAttributeValue("", 388, item.SenderId==_userManager.GetUserId(User)?"sender":"reciever", 388, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 15 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\70.17.01.2022-SignalR\Codes\SignalRIntro\SignalRIntro\Views\Messenger\Chat.cshtml"
                   Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 17 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\70.17.01.2022-SignalR\Codes\SignalRIntro\SignalRIntro\Views\Messenger\Chat.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"input-group mb-3\">\r\n                <input type=\"text\" class=\"form-control\" placeholder=\"type message\" id=\"message\">\r\n                <input hidden id=\"recieverid\"");
            BeginWriteAttribute("value", " value=\"", 748, "\"", 774, 1);
#nullable restore
#line 21 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\70.17.01.2022-SignalR\Codes\SignalRIntro\SignalRIntro\Views\Messenger\Chat.cshtml"
WriteAttributeValue("", 756, Model.Reciever.Id, 756, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <input hidden id=\"senderid\"");
            BeginWriteAttribute("value", " value=\"", 821, "\"", 858, 1);
#nullable restore
#line 22 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\70.17.01.2022-SignalR\Codes\SignalRIntro\SignalRIntro\Views\Messenger\Chat.cshtml"
WriteAttributeValue("", 829, _userManager.GetUserId(User), 829, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <button class=\"btn btn-outline-secondary\" type=\"button\" id=\"sendMessage\">Send</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmChat> Html { get; private set; }
    }
}
#pragma warning restore 1591
