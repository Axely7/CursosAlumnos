#pragma checksum "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5ea02200ed561689eaf04b7f3c0932cdfde9d63"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/listaAlumnos")]
    public partial class ListaAlumnos : ListaAlumnoBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ListaAlumnos</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group row\">\r\n    <div class=\"col-sm-10\">\r\n        <a href=\"/NuevoAlumno\" class=\"btn btn-primary m-1\">Nuevo Alumno</a>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 14 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
 if(Alumnos == null)
 {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 17 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
}

else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-deck");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 22 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
         foreach (var alumno in Alumnos)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card m-3");
            __builder.AddAttribute(10, "style", "min-width: 18rem; max-width: 30.5%; min-height: 26rem;");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 25 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
             if (alumno.FechaBaja == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-header");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "h3");
            __builder.AddContent(17, 
#nullable restore
#line 28 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                         alumno.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "img");
            __builder.AddAttribute(21, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(22, "src", 
#nullable restore
#line 30 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                                               alumno.Foto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card-footer text-center");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.AddMarkupContent(27, "<a href=\"#\" class=\"btn btn-primary m-1\">Cursos</a>\r\n                    ");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "href", 
#nullable restore
#line 33 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                               $"DetalleAlumno/{alumno.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "class", "btn btn-primary m-1");
            __builder.AddContent(31, "Ver");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.AddMarkupContent(33, "<a href=\"#\" class=\"btn btn-primary m-1\">Editar</a>\r\n                    ");
            __builder.AddMarkupContent(34, "<a href=\"#\" class=\"btn btn-danger m-1\">Borrar</a>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 37 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "card-header bg-danger");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "h3");
            __builder.AddContent(41, 
#nullable restore
#line 41 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                         alumno.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "img");
            __builder.AddAttribute(45, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(46, "src", 
#nullable restore
#line 43 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                                               alumno.Foto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "card-footer text-center bg-danger");
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.AddMarkupContent(51, "<a href=\"#\" class=\"btn btn-primary m-1\">Cursos</a>\r\n                    ");
            __builder.OpenElement(52, "a");
            __builder.AddAttribute(53, "href", 
#nullable restore
#line 46 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                               $"DetalleAlumno/{alumno.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(54, "class", "btn btn-primary m-1");
            __builder.AddContent(55, "Ver");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.AddMarkupContent(57, "<a href=\"#\" class=\"btn btn-primary m-1\">Editar</a>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 49 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 52 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 54 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
