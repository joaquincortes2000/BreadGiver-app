#pragma checksum "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\Pages\Admin\RegistroItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f28b556b1a9a71e5e740bb81b0a3136fb477f3c"
// <auto-generated/>
#pragma warning disable 1591
namespace BreadGiverApp.Client.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using BreadGiverApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using BreadGiverApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using BreadGiverApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using Repositorios;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registroItem")]
    public partial class RegistroItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-center font-weight-bold\" style=\"font-family:Arial;\">Fromulario de Item</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"col\">\r\n\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-6");
            __builder.AddMarkupContent(7, "\r\n        \r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\Pages\Admin\RegistroItem.razor"
                          producto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n                ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col");
                __builder2.AddMarkupContent(14, "\r\n                    ");
                __builder2.AddMarkupContent(15, "<p class=\"text-center\">Producto</p>\r\n                    ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "type", "hidden");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\Pages\Admin\RegistroItem.razor"
                                                       producto.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.Id = __value, producto.Id));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "placeholder", "Ingresa el producto");
                __builder2.AddAttribute(25, "required", true);
                __builder2.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\Pages\Admin\RegistroItem.razor"
                                                                                                                     producto.NombreProducto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.NombreProducto = __value, producto.NombreProducto));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col");
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __builder2.AddMarkupContent(33, "<p class=\"text-center\">Precio por unidad</p>\r\n                    ");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "type", "text");
                __builder2.AddAttribute(37, "placeholder", "Ingresa el precio unitario");
                __builder2.AddAttribute(38, "required", true);
                __builder2.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\Pages\Admin\RegistroItem.razor"
                                                                                                                            producto.PrecioProducto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.PrecioProducto = __value, producto.PrecioProducto));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.AddMarkupContent(46, "<p class=\"text-center\">Total de productos</p>\r\n                    ");
                __builder2.OpenElement(47, "input");
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "type", "number");
                __builder2.AddAttribute(50, "placeholder", "Ingresa la cantidad total");
                __builder2.AddAttribute(51, "required", true);
                __builder2.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\Pages\Admin\RegistroItem.razor"
                                                                                                                             producto.PrecioProducto

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.PrecioProducto = __value, producto.PrecioProducto, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                ");
                __builder2.OpenElement(56, "button");
                __builder2.AddAttribute(57, "type", "submit");
                __builder2.AddAttribute(58, "class", "btn btn-primary w-100");
                __builder2.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\Pages\Admin\RegistroItem.razor"
                                                                              (()=> initializeObject())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(60, "Continuar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(62, "\r\n        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.AddMarkupContent(64, "<div class=\"col\">\r\n\r\n    </div>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\Pages\Admin\RegistroItem.razor"
       

    private Producto producto = new Producto();

    private void initializeObject()
    {
        producto = new Producto();
    }

    private async Task Crear()
    {
        var httpResponse = await repositorio.Post("api/producto", producto);
        if(httpResponse.Error)
        {
            var body = await httpResponse.HttpResponseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
