#pragma checksum "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d5b96ae6e7a534707476bc92532e77302a49151"
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
 if (Alumnos == null)
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
            __builder.AddContent(7, "            ");
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
            __builder.AddContent(12, "                    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-header");
            __builder.AddMarkupContent(15, "\r\n                        ");
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
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
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
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card-footer text-center");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.AddMarkupContent(27, "<a href=\"#\" class=\"btn btn-primary m-1\">Cursos</a>\r\n                        ");
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
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "href", 
#nullable restore
#line 34 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                   $"modificarAlumno/{alumno.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "class", "btn btn-primary m-1");
            __builder.AddContent(36, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-danger m-1");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                                                     (()=> Borrar(alumno.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Baja");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 37 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "                    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "card-header bg-danger");
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "h3");
            __builder.AddContent(49, 
#nullable restore
#line 41 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                             alumno.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "img");
            __builder.AddAttribute(53, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(54, "src", 
#nullable restore
#line 43 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                                                   alumno.Foto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "card-footer text-center bg-danger");
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.AddMarkupContent(59, "<a href=\"#\" class=\"btn btn-primary m-1\">Cursos</a>\r\n                        ");
            __builder.OpenElement(60, "a");
            __builder.AddAttribute(61, "href", 
#nullable restore
#line 46 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                   $"DetalleAlumno/{alumno.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(62, "class", "btn btn-primary m-1");
            __builder.AddContent(63, "Ver");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.OpenElement(65, "a");
            __builder.AddAttribute(66, "href", 
#nullable restore
#line 47 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                   $"modificarAlumno/{alumno.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(67, "class", "btn btn-primary m-1");
            __builder.AddContent(68, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#nullable restore
#line 49 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 52 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 54 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "\r\n\r\n");
#nullable restore
#line 57 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
 if (MostrarPopUP)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "modal");
            __builder.AddAttribute(79, "tabindex", "-1");
            __builder.AddAttribute(80, "style", "display:block");
            __builder.AddAttribute(81, "role", "dialog");
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "modal-dialog");
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "modal-content");
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "modal-header bg-warning");
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.AddMarkupContent(92, "<h3 class=\"modal-title\">Baja alumno</h3>\r\n                    ");
            __builder.OpenElement(93, "button");
            __builder.AddAttribute(94, "type", "button");
            __builder.AddAttribute(95, "class", "close");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                                                  CerrarPop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(97, "\r\n                        ");
            __builder.AddMarkupContent(98, "<span aria-hidden=\"true\">X</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n\r\n                ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "modal-body alert-danger");
            __builder.AddMarkupContent(103, "\r\n                    ");
            __builder.AddMarkupContent(104, "<strong>Va dar de baja a este alumno. Si esta seguro continue. Si no cierre esta ventana.</strong>\r\n                    <br>\r\n                    ");
            __builder.OpenElement(105, "button");
            __builder.AddAttribute(106, "type", "button");
            __builder.AddAttribute(107, "class", "btn btn-danger");
            __builder.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                                                           (() => DarDeBaja(idAlumnoBorrar))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(109, "\r\n                        Dar de baja\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 79 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(115, "    ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "modal");
            __builder.AddAttribute(118, "tabindex", "-1");
            __builder.AddAttribute(119, "style", "display:none");
            __builder.AddAttribute(120, "role", "dialog");
            __builder.AddMarkupContent(121, "\r\n        ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "modal-dialog");
            __builder.AddMarkupContent(124, "\r\n            ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "modal-content");
            __builder.AddMarkupContent(127, "\r\n                ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "modal-header bg-warning");
            __builder.AddMarkupContent(130, "\r\n                    ");
            __builder.AddMarkupContent(131, "<h3 class=\"modal-title\">Baja alumno</h3>\r\n                    ");
            __builder.OpenElement(132, "button");
            __builder.AddAttribute(133, "type", "button");
            __builder.AddAttribute(134, "class", "close");
            __builder.AddAttribute(135, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                                                  CerrarPop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(136, "\r\n                        ");
            __builder.AddMarkupContent(137, "<span aria-hidden=\"true\">X</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n\r\n                ");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "class", "modal-body alert-danger");
            __builder.AddMarkupContent(142, "\r\n                    ");
            __builder.AddMarkupContent(143, "<strong>Va dar de baja a este alumno. Si esta seguro continue. Si no cierre esta ventana.</strong>\r\n                    <br>\r\n                    ");
            __builder.OpenElement(144, "button");
            __builder.AddAttribute(145, "type", "button");
            __builder.AddAttribute(146, "class", "btn btn-danger");
            __builder.AddAttribute(147, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                                                           (() => DarDeBaja(idAlumnoBorrar))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(148, "\r\n                        Dar de baja\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n");
#nullable restore
#line 102 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
