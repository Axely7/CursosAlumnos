#pragma checksum "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c7d997b8deb75e2ffeb3063ce2ab889bf7c321e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
using BlazorServer.Servicios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
using ModeloClasesAlumnos;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/InscribirAlumno/{id:int}")]
    public partial class InscribirAlumno : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Inscribir Alumno</h1>\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
 if (listaCursos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 15 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
}
else if (alumno.FechaBaja != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p class=\"text-danger\">Este alumno está de baja.</p>\r\n");
#nullable restore
#line 19 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
}
else if (listaCursos.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.AddMarkupContent(5, "<p class=\"text-danger\">No hay cursos disponibles</p>\r\n");
#nullable restore
#line 23 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, @"<thead>
            <tr>
                <th><strong>Nombre Curso</strong></th>
                <th><strong>Coste</strong></th>
                <th><strong>F. Inicio Precio</strong></th>
                <th><strong>F. Fin Precio</strong></th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 36 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
             foreach (Curso c in listaCursos)
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
                 foreach (Precio p in c.ListaPrecios)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                    ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 40 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
                             c.NombreCurso

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "class", "text-success");
            __builder.OpenElement(21, "strong");
            __builder.AddContent(22, "$");
            __builder.AddContent(23, 
#nullable restore
#line 41 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
                                                           p.Coste

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 42 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
                             p.FechaInicio.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 43 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
                             p.FechaFin.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 44 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
                         if (DateTime.Now >= p.FechaInicio && DateTime.Now < p.FechaFin)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "                            ");
            __builder.OpenElement(32, "td");
            __builder.AddMarkupContent(33, "\r\n                                ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "submit");
            __builder.AddAttribute(36, "class", "btn btn-primary");
            __builder.AddAttribute(37, "value", "Inscribir");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
                                                                                                         (() => Inscribir(c.Id, p.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 49 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 51 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 55 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 57 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
 if (mostrarError)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "modal bg-secondary");
            __builder.AddAttribute(50, "tabindex", "-1");
            __builder.AddAttribute(51, "style", "display:block;");
            __builder.AddAttribute(52, "role", "dialog");
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "modal-dialog modal-confirm");
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "modal-content ");
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "modal-header justify-content-center bg-info");
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.AddMarkupContent(63, "<div>\r\n                        <strong>Se produjo un error al realizar la operación.</strong>\r\n                    </div>\r\n                    ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "class", "close");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
                                      CerrarError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.AddMarkupContent(69, "<i class=\"large material-icons\">cancel</i>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "modal-body text-center");
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.AddMarkupContent(75, "<h4>Ooops!</h4>\r\n                    ");
            __builder.OpenElement(76, "p");
            __builder.AddContent(77, 
#nullable restore
#line 73 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
                        textoError

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "class", "btn btn-success");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
                                                              CerrarError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "data-dismiss", "modal");
            __builder.AddContent(83, "Cerrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 79 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\InscribirAlumno.razor"
       

    [Parameter]
    public int id { get; set; }

    public List<Curso> listaCursos { get; set; } = new List<Curso>();
    Alumno alumno = new Alumno();
    Boolean mostrarError = false;
    String textoError = String.Empty;

    Login l = new Login();
    Usuario u = new Usuario();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            l.Usuario = Environment.GetEnvironmentVariable("UsuarioAPI");
            l.Password = Environment.GetEnvironmentVariable("UsuarioAPI");
            u = (await SevicioLogin.SolicitudLogin(l));
            Environment.SetEnvironmentVariable("Token", u.Token);

            listaCursos = (await ServicioCursos.DameCursos(id)).ToList();
            alumno = (await ServicioAlumnos.DameAlumno(id));
        }
        catch (Exception ex)
        {
            textoError = ex.Message;
            MostrarError();
            StateHasChanged();
        }
    }

    protected async Task Inscribir(int idCurso, int idprecio)
    {
        try
        {
            alumno = (await ServicioAlumnos.CursosInscribirAlumno(alumno, idCurso, idprecio));
            navigationManager.NavigateTo("/ListaCursosAlumno/" + id);
        }
        catch (Exception ex)
        {
            textoError = ex.Message;
            MostrarError();
            StateHasChanged();
        }
    }

    protected void CerrarError()
    {
        mostrarError = false;

    }

    protected void MostrarError()
    {

        mostrarError = true;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioLogin SevicioLogin { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioCursos ServicioCursos { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioAlumnos ServicioAlumnos { get; set; }
    }
}
#pragma warning restore 1591
