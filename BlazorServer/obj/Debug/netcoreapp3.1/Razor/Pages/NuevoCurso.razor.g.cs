#pragma checksum "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d53e70c50c4a663deffe048e0aa66e3f58249189"
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
#line 2 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
using BlazorServer.Servicios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
using ModeloClasesAlumnos;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/NuevoCurso")]
    public partial class NuevoCurso : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Nuevo Curso</h3>\r\n<hr>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                  curso

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group row");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.AddMarkupContent(13, "<label for=\"NombreCurso\" class=\"col-sm-2 col-form-label\">Curso: </label>\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-sm-10");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "id", "NombreCurso");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "placeholder", "Nombre del curso");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                                                                                                         curso.NombreCurso

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => curso.NombreCurso = __value, curso.NombreCurso))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => curso.NombreCurso));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __Blazor.BlazorServer.Pages.NuevoCurso.TypeInference.CreateValidationMessage_0(__builder2, 25, 26, 
#nullable restore
#line 17 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                                      () => curso.NombreCurso

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(31);
            __builder.AddAttribute(32, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                  precio

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 22 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(36);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(38);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group row");
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.AddMarkupContent(43, "<label for=\"Coste\" class=\"col-sm-2 col-form-label\">Precio: </label>\r\n        ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "col-sm-10");
                __builder2.AddMarkupContent(46, "\r\n            ");
                __Blazor.BlazorServer.Pages.NuevoCurso.TypeInference.CreateInputNumber_1(__builder2, 47, 48, "Coste", 49, "Debe introducir un coste", 50, "form-control", 51, "Precio del curso", 52, 
#nullable restore
#line 28 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                                                                                                                                                    precio.Coste

#line default
#line hidden
#nullable disable
                , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => precio.Coste = __value, precio.Coste)), 54, () => precio.Coste);
                __builder2.AddMarkupContent(55, "\r\n            ");
                __Blazor.BlazorServer.Pages.NuevoCurso.TypeInference.CreateValidationMessage_2(__builder2, 56, 57, 
#nullable restore
#line 29 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                                      () => precio.Coste

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group row");
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.AddMarkupContent(64, "<label for=\"FechaInicio\" class=\"col-sm-2 col-form-label\">Fecha inicio: </label>\r\n        ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "col-sm-10");
                __builder2.AddMarkupContent(67, "\r\n            ");
                __Blazor.BlazorServer.Pages.NuevoCurso.TypeInference.CreateInputDate_3(__builder2, 68, 69, "FechaInicio", 70, "Debe seleccionar una fecha", 71, "form-control", 72, "Fecha inicio del precio", 73, 
#nullable restore
#line 35 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                                                                                                                                                                 precio.FechaInicio

#line default
#line hidden
#nullable disable
                , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => precio.FechaInicio = __value, precio.FechaInicio)), 75, () => precio.FechaInicio);
                __builder2.AddMarkupContent(76, "\r\n            ");
                __Blazor.BlazorServer.Pages.NuevoCurso.TypeInference.CreateValidationMessage_4(__builder2, 77, 78, 
#nullable restore
#line 36 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                                      ()=>precio.FechaInicio

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(79, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n    ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group row");
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.AddMarkupContent(85, "<label for=\"FechaInicio\" class=\"col-sm-2 col-form-label\">Fecha Fin</label>\r\n        ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "col-sm-10");
                __builder2.AddMarkupContent(88, "\r\n            ");
                __Blazor.BlazorServer.Pages.NuevoCurso.TypeInference.CreateInputDate_5(__builder2, 89, 90, "Debe seleccionar una fecha", 91, "FechaFin", 92, "form-control", 93, "Fecha fin del precio", 94, 
#nullable restore
#line 42 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                                                                                                                                                           precio.FechaFin

#line default
#line hidden
#nullable disable
                , 95, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => precio.FechaFin = __value, precio.FechaFin)), 96, () => precio.FechaFin);
                __builder2.AddMarkupContent(97, "\r\n            ");
                __Blazor.BlazorServer.Pages.NuevoCurso.TypeInference.CreateValidationMessage_6(__builder2, 98, 99, 
#nullable restore
#line 43 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                                      () => precio.FechaFin

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(100, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(103, "\r\n\r\n");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "row content");
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "col-md-1");
            __builder.AddMarkupContent(109, "\r\n        ");
            __builder.OpenElement(110, "input");
            __builder.AddAttribute(111, "type", "submit");
            __builder.AddAttribute(112, "class", "btn btn-primary");
            __builder.AddAttribute(113, "value", "Guardar");
            __builder.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                                                                               Guardar

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n    ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "col-md-2");
            __builder.AddMarkupContent(119, "\r\n        ");
            __builder.OpenElement(120, "input");
            __builder.AddAttribute(121, "type", "button");
            __builder.AddAttribute(122, "value", "Cancelar");
            __builder.AddAttribute(123, "class", "btn btn-danger");
            __builder.AddAttribute(124, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                                                                               Cancelar

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n\r\n");
#nullable restore
#line 57 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
 if (mostrarError)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(128, "    ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "modal bg-secondary");
            __builder.AddAttribute(131, "tabindex", "-1");
            __builder.AddAttribute(132, "style", "display:block;");
            __builder.AddAttribute(133, "role", "dialog");
            __builder.AddMarkupContent(134, "\r\n        ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "modal-dialog modal-confirm");
            __builder.AddMarkupContent(137, "\r\n            ");
            __builder.OpenElement(138, "div");
            __builder.AddAttribute(139, "class", "modal-content ");
            __builder.AddMarkupContent(140, "\r\n                ");
            __builder.OpenElement(141, "div");
            __builder.AddAttribute(142, "class", "modal-header justify-content-center bg-info");
            __builder.AddMarkupContent(143, "\r\n                    ");
            __builder.AddMarkupContent(144, "<div>\r\n                        <strong>Se produjo un error al realizar la operación.</strong>\r\n                    </div>\r\n                    ");
            __builder.OpenElement(145, "button");
            __builder.AddAttribute(146, "type", "button");
            __builder.AddAttribute(147, "class", "close");
            __builder.AddAttribute(148, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                                      CerrarError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(149, "\r\n                        ");
            __builder.AddMarkupContent(150, "<i class=\"large material-icons\">cancel</i>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                ");
            __builder.OpenElement(153, "div");
            __builder.AddAttribute(154, "class", "modal-body text-center");
            __builder.AddMarkupContent(155, "\r\n                    ");
            __builder.AddMarkupContent(156, "<h4>Ooops!</h4>\r\n                    ");
            __builder.OpenElement(157, "p");
            __builder.AddContent(158, 
#nullable restore
#line 73 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                        textoError

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                    ");
            __builder.OpenElement(160, "button");
            __builder.AddAttribute(161, "class", "btn btn-success");
            __builder.AddAttribute(162, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
                                                              CerrarError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(163, "data-dismiss", "modal");
            __builder.AddContent(164, "Cerrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n");
#nullable restore
#line 79 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\NuevoCurso.razor"
       
    Curso curso = new Curso();
    Precio precio = new Precio();

    Boolean mostrarError = false;
    String textoError = String.Empty;
    Login l = new Login();
    Usuario u = new Usuario();

    public void HandleValidSubmit()
    {
        Console.WriteLine("OnValidSubmit");
    }

    protected override async Task OnInitializedAsync()
    {

        try
        {
            l.Usuario = Environment.GetEnvironmentVariable("UsuarioAPI");
            l.Password = Environment.GetEnvironmentVariable("UsuarioAPI");
            u = (await SevicioLogin.SolicitudLogin(l));
            Environment.SetEnvironmentVariable("Token", u.Token);
        }
        catch (Exception ex)
        {
            textoError = ex.Message;
            MostrarError();
            StateHasChanged();
        }
    }




    protected async Task Guardar()
    {
        try
        {
            if (curso.NombreCurso != String.Empty &&
                precio.Coste >= 0 && precio.FechaFin != null &&
                precio.FechaInicio != null)
            {
                curso.ListaPrecios = new List<Precio>();
                curso.ListaPrecios.Add(precio);
                await ServicioCurso.AltaCurso(curso);
                navigationManager.NavigateTo("/ListaCursos");
            }
        }
        catch (Exception ex)
        {
            textoError = ex.Message;
            MostrarError();
            StateHasChanged();
        }

    }

    protected void Cancelar()
    {
        navigationManager.NavigateTo("/ListaCursos");
    }

    protected override void OnInitialized()
    {
        curso.NombreCurso = "Nuevo Curso";
        precio.Coste = 19.99;
        precio.FechaInicio = DateTime.Now;
        precio.FechaFin = DateTime.Now.AddDays(30);

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioCursos ServicioCurso { get; set; }
    }
}
namespace __Blazor.BlazorServer.Pages.NuevoCurso
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "ParsingErrorMessage", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "placeholder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "ParsingErrorMessage", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "placeholder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ParsingErrorMessage", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "placeholder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
