#pragma checksum "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\Pages\FormularioBorrar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2996ed1da09516675af8dfa3aeac7ae6c8cd254"
// <auto-generated/>
#pragma warning disable 1591
namespace Examen.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\_Imports.razor"
using Examen.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\_Imports.razor"
using Examen.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\_Imports.razor"
using Examen.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\_Imports.razor"
using Examen.Client.Servicios;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/formularioborrar/{id:int}")]
    public partial class FormularioBorrar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FormularioBorrar</h3>");
#nullable restore
#line 8 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\Pages\FormularioBorrar.razor"
 if (alumno == null) 
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Cargando...</em></p>");
#nullable restore
#line 9 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\Pages\FormularioBorrar.razor"
                             }
else{




#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\Pages\FormularioBorrar.razor"
                 alumno

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\Pages\FormularioBorrar.razor"
                                        Borrar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "card");
                __builder2.AddMarkupContent(8, "<h5 class=\"card-header\">Datos de Alumno</h5>\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "card-body");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "container");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "row");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-md-6");
                __builder2.AddMarkupContent(17, "<label>Nombre</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\Pages\FormularioBorrar.razor"
                                                                    alumno.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => alumno.Nombre = __value, alumno.Nombre))));
                __builder2.AddAttribute(22, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => alumno.Nombre));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n                     ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-md-6");
                __builder2.AddMarkupContent(26, "<label>Apellido Paterno</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\Pages\FormularioBorrar.razor"
                                                                    alumno.ApellidoP

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => alumno.ApellidoP = __value, alumno.ApellidoP))));
                __builder2.AddAttribute(31, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => alumno.ApellidoP));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n                 ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "row");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-md-6");
                __builder2.AddMarkupContent(37, "<label>Apellido Materno</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\Pages\FormularioBorrar.razor"
                                                                    alumno.ApellidoM

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => alumno.ApellidoM = __value, alumno.ApellidoM))));
                __builder2.AddAttribute(42, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => alumno.ApellidoM));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n  \r\n                  <br>\r\n                  ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "row");
                __builder2.AddMarkupContent(46, "<div class=\"col-md-4\"></div>\r\n\r\n                     ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "col-md-4");
                __builder2.AddMarkupContent(49, "<input type=\"submit\" class=\"btn btn-danger\" value=\"Borrar\">\r\n                       ");
                __builder2.OpenElement(50, "input");
                __builder2.AddAttribute(51, "type", "button");
                __builder2.AddAttribute(52, "class", "btn btn-secondary");
                __builder2.AddAttribute(53, "value", "Cancelar");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\Pages\FormularioBorrar.razor"
                                                                                                 NavigateHome

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n                    <div class=\"col-md-4\"></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 64 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\Pages\FormularioBorrar.razor"








}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\OjaiSistemas\PruebaLogin\Examen\Examen\Client\Pages\FormularioBorrar.razor"
       

    public Alumnos alumno;

    [Parameter]
    public int id { get; set; }

    protected async override Task OnInitializedAsync()
    {
      alumno = await servicios.DetalleAlumno(id);
    }

    protected async Task Borrar()
    {
        await servicios.BorrarAlumno(id);
        NavigateHome();
    }

    private void NavigateHome()
    {
        naviagte.NavigateTo("/");
    }






#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager naviagte { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiciosAlumnos servicios { get; set; }
    }
}
#pragma warning restore 1591