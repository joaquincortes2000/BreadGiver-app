#pragma checksum "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\PerfilUsuario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abff08ee2f919f9276b871e2a1b12ebe0f3d94e6"
// <auto-generated/>
#pragma warning disable 1591
namespace BreadGiverApp.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Perfil")]
    public partial class PerfilUsuario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>PerfilUsuario</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<div class=""row"">
    <div class=""col-md-6"">
        <img class=""rounded mx-auto d-block"" width=""150"" height=""150"" src=""https://res.cloudinary.com/joaquin2000cortes/image/upload/v1593304032/perfil-hombre-dibujos-animados_18591-58483_irgbvm.jpg"" alt=""Alternate Text"">
        <div class=""custom-file"">
            <input type=""file"" class=""custom-file-input"" id=""customFile"">
            <label class=""custom-file-label"" for=""customFile"">Actualizar foto de perfil</label>
        </div>
        <div style=""margin-top: 5px;"" class=""container border-info"">
            <p class=""text-center"">Nombre</p>
            <p class=""text-center"">Apellido</p>
            <p class=""text-center"">Correo</p>

        </div>
    </div>
    <div class=""col-md-6"">
        <h3 class=""font-weight-bold"">Historial de compras</h3>
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Número de pedido</th>
                    <th scope=""col"">Tipo de compra</th>
                    <th scope=""col"">Costo total</th>
                </tr>
            </thead>
            <tr>
                <td>1</td>
                <td>Cotización</td>
                <td>$23000</td>
            </tr>
        </table>
    </div>
</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
