#pragma checksum "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b12706693506ee5d7e6c2c2efbbcc0ba8d77422"
// <auto-generated/>
#pragma warning disable 1591
namespace PoPoy.Client.Pages.ProductView
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
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "box");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddAttribute(4, "id", "products");
#nullable restore
#line 6 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
         if (_productSvc.Products.Items == null || _productSvc.Products.Items.Count == 0)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<PoPoy.Client.Shared.LoadingScreen>(5);
            __builder.CloseComponent();
#nullable restore
#line 9 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
        }
        else
        {
            foreach (var item in _productSvc.Products.Items)
            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-4 col-md-6 col-sm-12");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "product-card");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "product-card-img");
#nullable restore
#line 19 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
                             try
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
                                 if (item.ProductImages.Any())
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 23 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
                                               item.ProductImages.FirstOrDefault().ImagePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "alt");
            __builder.CloseElement();
#nullable restore
#line 24 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
                                    if(item.ProductImages.Skip(1).FirstOrDefault().ImagePath != null)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 26 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
                                                   item.ProductImages.Skip(1).FirstOrDefault().ImagePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "alt");
            __builder.CloseElement();
#nullable restore
#line 27 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "img");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 30 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
                                                   item.ProductImages.FirstOrDefault().ImagePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "alt");
            __builder.CloseElement();
#nullable restore
#line 31 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
                                    }

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "img");
            __builder.AddAttribute(22, "src", (
#nullable restore
#line 36 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
                                               _config["BackendApiUrl"]

#line default
#line hidden
#nullable disable
            ) + "/uploads/no-photo-available.png");
            __builder.AddAttribute(23, "alt");
            __builder.CloseElement();
#nullable restore
#line 37 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
                                 



                            }
                            catch { }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "product-card-info");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "product-btn");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "href", "/product-detail/" + (
#nullable restore
#line 47 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
                                                          item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "class", "btn-flat btn-hover btn-shop-now");
            __builder.AddContent(32, "shop now");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                                ");
            __builder.AddMarkupContent(34, "<button class=\"btn-flat btn-hover btn-cart-add\"><i class=\"bx bxs-heart\"></i></button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                            ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "product-card-name");
#nullable restore
#line 56 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
__builder.AddContent(38, item.Title);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, " | Lượt xem: ");
#nullable restore
#line 56 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
__builder.AddContent(40, item.Views);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "product-card-price");
            __builder.OpenElement(44, "span");
            __builder.OpenElement(45, "del");
#nullable restore
#line 59 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
__builder.AddContent(46, item.OriginalPrice);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                ");
            __builder.OpenElement(48, "span");
            __builder.AddAttribute(49, "class", "curr-price");
#nullable restore
#line 60 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
__builder.AddContent(50, item.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"

            }

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "D:\Myproject\CSharp\DATN\PoPoy.Client\Pages\ProductView\ProductList.razor"
       
    protected override void OnInitialized()
    {
        _productSvc.ProductsChanged += StateHasChanged;
    }

    public void Dispose()
    {
        _productSvc.ProductsChanged -= StateHasChanged;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService _productSvc { get; set; }
    }
}
#pragma warning restore 1591
