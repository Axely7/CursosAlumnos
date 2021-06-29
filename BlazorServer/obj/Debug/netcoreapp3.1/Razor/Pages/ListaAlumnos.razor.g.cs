#pragma checksum "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ce537cec3c194c7269d59cfe1e035363afca3c"
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
#line 3 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListaAlumnos")]
    public partial class ListaAlumnos : ListaAlumnoBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ListaAlumnos</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group row\">\r\n    <div class=\"col-sm-10\">\r\n        <a href=\"/NuevoAlumno\" class=\"btn btn-primary m-1\">Nuevo Alumno</a>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 15 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
 if (Alumnos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 18 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
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
#line 23 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
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
#line 26 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
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
#line 29 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
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
#line 31 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
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
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", 
#nullable restore
#line 33 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                   $"ListaCursosAlumno/{alumno.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "class", "btn btn-primary m-1");
            __builder.AddContent(30, "Cursos");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", 
#nullable restore
#line 34 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                   $"DetalleAlumno/{alumno.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "class", "btn btn-primary m-1");
            __builder.AddContent(35, "Ver");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", 
#nullable restore
#line 35 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                   $"modificarAlumno/{alumno.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "class", "btn btn-primary m-1");
            __builder.AddContent(40, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-danger m-1");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                                                     (()=> Borrar(alumno.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Baja");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 38 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "                    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "card-header bg-danger");
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.OpenElement(52, "h3");
            __builder.AddContent(53, 
#nullable restore
#line 42 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                             alumno.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "img");
            __builder.AddAttribute(57, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(58, "src", 
#nullable restore
#line 44 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                                                   alumno.Foto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "card-footer text-center bg-danger");
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.AddMarkupContent(63, "<a href=\"#\" class=\"btn btn-primary m-1\">Cursos</a>\r\n                        ");
            __builder.OpenElement(64, "a");
            __builder.AddAttribute(65, "href", 
#nullable restore
#line 47 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                   $"DetalleAlumno/{alumno.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(66, "class", "btn btn-primary m-1");
            __builder.AddContent(67, "Ver");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.OpenElement(69, "a");
            __builder.AddAttribute(70, "href", 
#nullable restore
#line 48 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                   $"modificarAlumno/{alumno.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(71, "class", "btn btn-primary m-1");
            __builder.AddContent(72, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 50 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
#nullable restore
#line 53 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(77, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 55 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(79, "\r\n\r\n");
#nullable restore
#line 58 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
 if (MostrarPopUP)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "    ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "modal bg-secondary");
            __builder.AddAttribute(83, "tabindex", "-1");
            __builder.AddAttribute(84, "style", "display:block");
            __builder.AddAttribute(85, "role", "dialog");
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "modal-dialog");
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "modal-content");
            __builder.AddMarkupContent(92, "\r\n                ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "modal-header bg-warning");
            __builder.AddMarkupContent(95, "\r\n                    ");
            __builder.AddMarkupContent(96, "<h3 class=\"modal-title\">Baja alumno</h3>\r\n                    ");
            __builder.OpenElement(97, "button");
            __builder.AddAttribute(98, "type", "button");
            __builder.AddAttribute(99, "class", "close");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                                                  CerrarPop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(101, "\r\n                        ");
            __builder.AddMarkupContent(102, "<span aria-hidden=\"true\">X</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n\r\n                ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "modal-body alert-danger");
            __builder.AddMarkupContent(107, "\r\n                    ");
            __builder.AddMarkupContent(108, "<strong>Va dar de baja a este alumno. Si esta seguro continue. Si no cierre esta ventana.</strong>\r\n                    <br>\r\n                    ");
            __builder.OpenElement(109, "button");
            __builder.AddAttribute(110, "type", "button");
            __builder.AddAttribute(111, "class", "btn btn-danger");
            __builder.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                                                           (() => DarDeBaja(idAlumnoBorrar))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(113, "\r\n                        Dar de baja\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
#nullable restore
#line 80 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(119, "    ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "modal");
            __builder.AddAttribute(122, "tabindex", "-1");
            __builder.AddAttribute(123, "style", "display:none");
            __builder.AddAttribute(124, "role", "dialog");
            __builder.AddMarkupContent(125, "\r\n        ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "modal-dialog");
            __builder.AddMarkupContent(128, "\r\n            ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "modal-content");
            __builder.AddMarkupContent(131, "\r\n                ");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "modal-header bg-warning");
            __builder.AddMarkupContent(134, "\r\n                    ");
            __builder.AddMarkupContent(135, "<h3 class=\"modal-title\">Baja alumno</h3>\r\n                    ");
            __builder.OpenElement(136, "button");
            __builder.AddAttribute(137, "type", "button");
            __builder.AddAttribute(138, "class", "close");
            __builder.AddAttribute(139, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                                                  CerrarPop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(140, "\r\n                        ");
            __builder.AddMarkupContent(141, "<span aria-hidden=\"true\">X</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n\r\n                ");
            __builder.OpenElement(144, "div");
            __builder.AddAttribute(145, "class", "modal-body alert-danger");
            __builder.AddMarkupContent(146, "\r\n                    ");
            __builder.AddMarkupContent(147, "<strong>Va dar de baja a este alumno. Si esta seguro continue. Si no cierre esta ventana.</strong>\r\n                    <br>\r\n                    ");
            __builder.OpenElement(148, "button");
            __builder.AddAttribute(149, "type", "button");
            __builder.AddAttribute(150, "class", "btn btn-danger");
            __builder.AddAttribute(151, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                                                           (() => DarDeBaja(idAlumnoBorrar))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(152, "\r\n                        Dar de baja\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n");
#nullable restore
#line 103 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(158, "\r\n");
#nullable restore
#line 105 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
 if (mostrarError)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(159, "    ");
            __builder.OpenElement(160, "div");
            __builder.AddAttribute(161, "class", "modal bg-secondary");
            __builder.AddAttribute(162, "tabindex", "-1");
            __builder.AddAttribute(163, "style", "display:block;");
            __builder.AddAttribute(164, "role", "dialog");
            __builder.AddMarkupContent(165, "\r\n        ");
            __builder.OpenElement(166, "div");
            __builder.AddAttribute(167, "class", "modal-dialog modal-confirm");
            __builder.AddMarkupContent(168, "\r\n            ");
            __builder.OpenElement(169, "div");
            __builder.AddAttribute(170, "class", "modal-content ");
            __builder.AddMarkupContent(171, "\r\n                ");
            __builder.OpenElement(172, "div");
            __builder.AddAttribute(173, "class", "modal-header justify-content-center bg-info");
            __builder.AddMarkupContent(174, "\r\n                    ");
            __builder.AddMarkupContent(175, "<div>\r\n                        <strong>Se produjo un error al realizar la operación.</strong>\r\n                    </div>\r\n                    ");
            __builder.OpenElement(176, "button");
            __builder.AddAttribute(177, "type", "button");
            __builder.AddAttribute(178, "class", "close");
            __builder.AddAttribute(179, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 115 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                      CerrarError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(180, "\r\n                        ");
            __builder.AddMarkupContent(181, "<i class=\"large material-icons\">cancel</i>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n                ");
            __builder.OpenElement(184, "div");
            __builder.AddAttribute(185, "class", "modal-body text-center");
            __builder.AddMarkupContent(186, "\r\n                    ");
            __builder.AddMarkupContent(187, "<h4>Ooops!</h4>\r\n                    ");
            __builder.OpenElement(188, "p");
            __builder.AddContent(189, 
#nullable restore
#line 121 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                        textoError

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n                    ");
            __builder.OpenElement(191, "button");
            __builder.AddAttribute(192, "class", "btn btn-success");
            __builder.AddAttribute(193, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 122 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
                                                              CerrarError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(194, "data-dismiss", "modal");
            __builder.AddContent(195, "Cerrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(197, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n");
#nullable restore
#line 127 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ListaAlumnos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
