#pragma checksum "D:\Projects\Inventory\Inventory\Component\Ejercicios\BlazorPage\Form001.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e75a084e17348f6420fc1b8ad480f63232e50ef"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Inventory.Component.Ejercicios.BlazorPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\Inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\Inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\Inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\Inventory\Inventory\_Imports.razor"
using Inventory.Component.Ejercicios.BlazorPage;

#line default
#line hidden
#nullable disable
    public partial class Form001 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\Projects\Inventory\Inventory\Component\Ejercicios\BlazorPage\Form001.razor"
       
    [Parameter]
    public string Message { get; set; }

    string message;
    int id;
    string firstName;
    string secondName;
    string lastName;
    DateTime birth;
    int telephone;
    string address;

    protected override async Task OnInitializedAsync()
    {
        message = Message;

    }

    private void ChangeText()
    {


        message = "Hola mi id es " + id + "mi primer nombre es: " + firstName + " mi segundo nombre es " + secondName + " mi fecha de cumpleaños es " + birth +
            " mi numero telefonico es " + telephone + " esta es mi direccion " + address;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
