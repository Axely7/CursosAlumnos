#pragma checksum "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c608efb007cec7d0401b53919234e0dae5191854"
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
#line 3 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/nuevoAlumno")]
    public partial class NuevoAlumno : NuevoAlumnoBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
                  alumno

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
                                           HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.AddMarkupContent(7, "<h3>Nuevo Alumno</h3>\r\n    <hr>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group row");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.AddMarkupContent(13, "<label for=\"Nombre\" class=\"col-sm-2 col-form-label\">Nombre</label>\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-sm-10");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "id", "Nombre");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "placeholder", "Nombre del alumno");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
                                                                                                     alumno.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => alumno.Nombre = __value, alumno.Nombre))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => alumno.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __Blazor.BlazorServer.Pages.NuevoAlumno.TypeInference.CreateValidationMessage_0(__builder2, 25, 26, 
#nullable restore
#line 14 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
                                      () => alumno.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group row");
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.AddMarkupContent(33, "<label for=\"Email\" class=\"col-sm-2 col-form-label\">Email</label>\r\n        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-sm-10");
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "id", "Email");
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "placeholder", "Email");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
                                                                                        alumno.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => alumno.Email = __value, alumno.Email))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => alumno.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __Blazor.BlazorServer.Pages.NuevoAlumno.TypeInference.CreateValidationMessage_1(__builder2, 45, 46, 
#nullable restore
#line 21 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
                                      () => alumno.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(47, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n    ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group row");
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.AddMarkupContent(53, "<label for=\"Foto\" class=\"col-sm-2 col-form-label\">Foto</label>\r\n        ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col-sm-10");
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(57);
                __builder2.AddAttribute(58, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 27 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
                                 HandleFileSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(59, "Value", 
#nullable restore
#line 27 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
                                                                  alumno.Foto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => alumno.Foto = __value, alumno.Foto));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n            ");
                __Blazor.BlazorServer.Pages.NuevoAlumno.TypeInference.CreateValidationMessage_2(__builder2, 62, 63, 
#nullable restore
#line 28 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
                                      () => alumno.Foto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(64, "\r\n");
#nullable restore
#line 29 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
             if (fichero != null)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(65, "                ");
                __builder2.OpenElement(66, "p");
                __builder2.OpenElement(67, "strong");
                __builder2.AddContent(68, "Fichero seleccionado: ");
                __builder2.AddContent(69, 
#nullable restore
#line 31 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
                                                  fichero.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n");
#nullable restore
#line 32 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(71, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n    ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "row content");
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "col-md-1");
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.OpenElement(80, "input");
                __builder2.AddAttribute(81, "type", "submit");
                __builder2.AddAttribute(82, "class", "btn btn-primary");
                __builder2.AddAttribute(83, "value", "Guardar");
                __builder2.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
                                                                                   Guardar

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n        ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "col-md-2");
                __builder2.AddMarkupContent(89, "\r\n            ");
                __builder2.OpenElement(90, "input");
                __builder2.AddAttribute(91, "type", "button");
                __builder2.AddAttribute(92, "value", "Cancelar");
                __builder2.AddAttribute(93, "class", "btn btn-danger");
                __builder2.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
                                                                                   Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(98, "\r\n\r\n");
#nullable restore
#line 45 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
 if (mostrarError)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(99, "    ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "modal bg-secondary");
            __builder.AddAttribute(102, "tabindex", "-1");
            __builder.AddAttribute(103, "style", "display:block;");
            __builder.AddAttribute(104, "role", "dialog");
            __builder.AddMarkupContent(105, "\r\n        ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "modal-dialog modal-confirm");
            __builder.AddMarkupContent(108, "\r\n            ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "modal-content ");
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "modal-header justify-content-center bg-info");
            __builder.AddMarkupContent(114, "\r\n                    ");
            __builder.AddMarkupContent(115, "<div>\r\n                        <strong>Se produjo un error al realizar la operaci??n.</strong>\r\n                    </div>\r\n                    ");
            __builder.OpenElement(116, "button");
            __builder.AddAttribute(117, "type", "button");
            __builder.AddAttribute(118, "class", "close");
            __builder.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
                                      CerrarError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(120, "\r\n                        ");
            __builder.AddMarkupContent(121, "<i class=\"large material-icons\">cancel</i>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "modal-body text-center");
            __builder.AddMarkupContent(126, "\r\n                    ");
            __builder.AddMarkupContent(127, "<h4>Ooops!</h4>\r\n                    ");
            __builder.OpenElement(128, "p");
            __builder.AddContent(129, 
#nullable restore
#line 61 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
                        textoError

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                    ");
            __builder.OpenElement(131, "button");
            __builder.AddAttribute(132, "class", "btn btn-success");
            __builder.AddAttribute(133, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
                                                              CerrarError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(134, "data-dismiss", "modal");
            __builder.AddContent(135, "Cerrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n");
#nullable restore
#line 67 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoAlumno.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BlazorServer.Pages.NuevoAlumno
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
