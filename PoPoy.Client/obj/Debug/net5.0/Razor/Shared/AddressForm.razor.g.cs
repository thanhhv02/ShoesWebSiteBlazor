#pragma checksum "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7a93bdade1565ea306b39ee91032dace105d706"
// <auto-generated/>
#pragma warning disable 1591
namespace PoPoy.Client.Shared
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
    public partial class AddressForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "information_module");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "toggle_title astext");
            __builder.AddAttribute(4, "data-toggle", "collapse");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor"
                                                                             InitAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "<h4>\r\n                    Nhập địa chỉ\r\n                    <span class=\"fa-solid fa-chevron-down\"></span></h4>");
            __builder.CloseElement();
#nullable restore
#line 14 "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor"
         if (editAddress)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor"
                             address

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor"
                                                     SubmitAddress

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "information__set toggle_module collapse show");
                __builder2.AddAttribute(13, "id", "changepass-collapse");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "information_wrapper form--fields");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "<label>Thành phố/ Tỉnh <sup>*</sup></label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "id", "street");
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor"
                                                                address.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => address.City = __value, address.City))));
                __builder2.AddAttribute(24, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => address.City));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "<label>Đường/ Thôn <sup>*</sup></label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "id", "street");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor"
                                                                address.Street

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => address.Street = __value, address.Street))));
                __builder2.AddAttribute(34, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => address.Street));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "<label>Phường/ Xã <sup>*</sup></label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "id", "street");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor"
                                                                address.State

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => address.State = __value, address.State))));
                __builder2.AddAttribute(44, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => address.State));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group");
                __builder2.AddMarkupContent(48, "<label>Quận/ Huyện <sup>*</sup></label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(49);
                __builder2.AddAttribute(50, "id", "street");
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddAttribute(52, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor"
                                                                address.Country

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => address.Country = __value, address.Country))));
                __builder2.AddAttribute(54, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => address.Country));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                        ");
                __builder2.AddMarkupContent(56, "<div class=\"form-group\" style=\"margin-bottom:0; text-align:right\"><button class=\"btn btn--xs\" type=\"submit\">Lưu</button></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 41 "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor"
        }
        else if(address is not null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "author_module about_author");
            __builder.OpenElement(59, "p");
            __builder.AddMarkupContent(60, "<span class=\"indam\">Thành phố/ Tỉnh:</span> ");
#nullable restore
#line 45 "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor"
__builder.AddContent(61, address.City);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "p");
            __builder.AddMarkupContent(64, "<span class=\"indam\">Đường/ Thôn:</span> ");
#nullable restore
#line 46 "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor"
__builder.AddContent(65, address.Street);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "p");
            __builder.AddMarkupContent(68, "<span class=\"indam\">Phường/ Xã:</span> ");
#nullable restore
#line 47 "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor"
__builder.AddContent(69, address.State);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.OpenElement(71, "p");
            __builder.AddMarkupContent(72, "<span class=\"indam\">Quận/ Huyện:</span> ");
#nullable restore
#line 48 "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor"
__builder.AddContent(73, address.Country);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "D:\Myproject\CSharp\DATN\PoPoy.Client\Shared\AddressForm.razor"
       
    private Address address{ get; set; } = new Address();
    bool editAddress = false;

    protected override async Task OnInitializedAsync()
    {
        var userId = await LocalStorage.GetItemAsync<Guid>("getUserId");
        var temp = await AuthService.GetAddress(userId);
        if(temp is not null)
        {
            address = new Address();
            address = temp;
        }
    }

    private async Task SubmitAddress()
    {
        var userId = await LocalStorage.GetItemAsync<Guid>("getUserId");
        address = await AuthService.AddOrUpdateAddress(address, userId);
        InitAddress();
    }

    private void InitAddress()
    {
        //address = new Address();
        editAddress = editAddress == true ? false : true;
    }

    private void EditAddress()
    {
        editAddress = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
    }
}
#pragma warning restore 1591
