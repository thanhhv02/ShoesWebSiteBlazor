#pragma checksum "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\AccountView\ForgotPassword.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bc383bddbfbb26d7ebca0f836a900ce748435c2"
// <auto-generated/>
#pragma warning disable 1591
namespace PoPoy.Client.Pages.AccountView
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using PoPoy.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Pages.Ultilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Pages.AccountView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Services.AuthService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using PoPoy.Shared.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Shared.PaginationView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using PoPoy.Shared.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using PoPoy.Client.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using PoPoy.Shared.Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using PoPoy.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Myproject\CSharp\DATN\PoPoy.Client\_Imports.razor"
using PoPoy.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/forgot-password")]
    public partial class ForgotPassword : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "pass_recover_area section--padding2");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-lg-6 offset-lg-3");
            __builder.AddAttribute(8, "style", "margin-bottom: 30px;");
            __builder.OpenElement(9, "div");
            __builder.AddMarkupContent(10, "<input name=\"__RequestVerificationToken\" type=\"hidden\" value=\"UU7nxpCcWO2XzGz7IfOQSbE_Mqkte0Jw6HClMz2dZ20OXPqRrpgT06oxCOWIqqFVcdCbTirYnfAjpWlpzN7_IqZ22JAFX_HNwK88qZEWrNQ1\">\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "cardify recover_pass");
            __builder.AddMarkupContent(13, @"<div class=""login--header""><p>
                                Nhập email mà bạn đã đăng ký trước đây và bấm khôi phục. Bạn sẽ nhận được 1 email bao gồm tên đăng nhập và 1 đường link
                                để đặt mật khẩu mới cho tài khoản của bạn. Ai quên tên đăng nhập cũng có thể dùng chức năng này để lấy lại tên đăng nhập
                            </p></div>
                        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "login--form");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group");
            __builder.AddMarkupContent(18, "<label for=\"email\">Email:</label>\r\n                                ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "id", "email");
            __builder.AddAttribute(21, "type", "email");
            __builder.AddAttribute(22, "class", "text_field");
            __builder.AddAttribute(23, "placeholder", "Nhập email mà bạn dùng đã dùng để đăng ký");
            __builder.AddAttribute(24, "name", "email");
            __builder.AddAttribute(25, "required", "");
            __builder.AddAttribute(26, "autofocus", "");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\AccountView\ForgotPassword.razor"
                                               email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n                            ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\AccountView\ForgotPassword.razor"
                                              ()=>HandleSumbit()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "class", "btn btn--xs register_btn");
            __builder.AddAttribute(33, "style", "margin-top:30px");
            __builder.AddAttribute(34, "disabled", 
#nullable restore
#line 27 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\AccountView\ForgotPassword.razor"
                                                                                                                                      isLoading

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 28 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\AccountView\ForgotPassword.razor"
                                 if (isLoading)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "<span class=\"spinner-border spinner-border-sm\" role=\"status\" aria-hidden=\"true\"></span>");
#nullable restore
#line 31 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\AccountView\ForgotPassword.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, " Khôi phục\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "login_assist");
            __builder.OpenElement(40, "p");
            __builder.AddMarkupContent(41, "\r\n                                    Bạn đã có tài khoản thành viên ?\r\n                                    ");
            __builder.OpenElement(42, "a");
            __builder.AddAttribute(43, "href", "/login?returnUrl=" + (
#nullable restore
#line 36 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\AccountView\ForgotPassword.razor"
                                                               NavigationManager.ToBaseRelativePath(NavigationManager.Uri)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "Đăng nhập");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\AccountView\ForgotPassword.razor"
       

    public string email { get; set; }
    public bool isLoading { get; set; }
    public async Task HandleSumbit()
    {
        isLoading = true;
        if (string.IsNullOrEmpty(email))
        {
            _toastSvc.ShowWarning("Chưa nhập email !");
            isLoading = false;
            return;
        }
        isLoading = true;
        var result = await AuthService.ForgotPassword(email);
        if (result.Success)
        {
            _toastSvc.ShowSuccess(result.Data);
        }
        else
        {
            _toastSvc.ShowError(result.Data);

        }

        isLoading = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastSvc { get; set; }
    }
}
#pragma warning restore 1591
