#pragma checksum "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\Inventario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f76b2a5d93a207e77ea7c3be2c23f3f65b0abae9"
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
#line 1 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using BreadGiverApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using BreadGiverApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using BreadGiverApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Repositorios;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Inventario")]
    public partial class Inventario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"font-weight-bolder\">Control de inventario</h1>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<thead>\r\n        <tr>\r\n            <th>Producto</th>\r\n            <th>Cantidad</th>\r\n            <th>Precio</th>\r\n            <th>Opciones</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 19 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\Inventario.razor"
         foreach (var item in todoItems ?? new List<Producto>())
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "td");
            __builder.AddAttribute(11, "hidden", true);
            __builder.AddContent(12, 
#nullable restore
#line 22 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\Inventario.razor"
                        item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 23 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\Inventario.razor"
                 item.NombreProducto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 24 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\Inventario.razor"
                 item.CantidadProducto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 25 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\Inventario.razor"
                 item.PrecioProducto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.AddMarkupContent(23, "<td><a href=\"/registroItem\" style=\"color: blue;\">Actualizar Item</a></td>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 28 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\Inventario.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "           \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\Inventario.razor"
       

    //private List<Producto> listaProducto;


    private List<Producto> todoItems;

    protected override async Task OnInitializedAsync() =>
    todoItems = await Http.GetFromJsonAsync<List<Producto>>("producto/obtenerTodos");



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
