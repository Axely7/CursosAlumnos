#pragma checksum "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8fc6864acb6b0a5bdf9c6ec1f9041e1d1a4d5da"
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
#line 2 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
using BlazorServer.Servicios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
using ModeloClasesAlumnos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/modificarAlumno/{id:int}")]
    public partial class ModificarAlumno : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Modificar Alumno</h3>\r\n<hr>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center m-3");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-8");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-header");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "h1");
            __builder.AddContent(14, 
#nullable restore
#line 15 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                     alumno.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-body text-center");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "img");
            __builder.AddAttribute(21, "class", "card-img-top");
            __builder.AddAttribute(22, "src", 
#nullable restore
#line 18 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                                                alumno.Foto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(26);
            __builder.AddAttribute(27, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                          alumno

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 21 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                                                 HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(31);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(33);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group row");
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.AddMarkupContent(38, "<label for=\"Nombre\" class=\"col-sm-2 col-form-label\">Nombre</label>\r\n                ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-sm-10");
                __builder2.AddMarkupContent(41, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "id", "Nombre");
                __builder2.AddAttribute(44, "class", "form-control");
                __builder2.AddAttribute(45, "placeholder", "Nombre del alumno");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                                                                                                             alumno.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => alumno.Nombre = __value, alumno.Nombre))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => alumno.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __Blazor.BlazorServer.Pages.ModificarAlumno.TypeInference.CreateValidationMessage_0(__builder2, 50, 51, 
#nullable restore
#line 28 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                                              () => alumno.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group row");
                __builder2.AddMarkupContent(57, "\r\n                ");
                __builder2.AddMarkupContent(58, "<label for=\"Email\" class=\"col-sm-2 col-form-\">Email</label>\r\n                ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-sm-10");
                __builder2.AddMarkupContent(61, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(62);
                __builder2.AddAttribute(63, "id", "Email");
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "placeholder", "Email");
                __builder2.AddAttribute(66, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                                                                                                alumno.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => alumno.Email = __value, alumno.Email))));
                __builder2.AddAttribute(68, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => alumno.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n                    ");
                __Blazor.BlazorServer.Pages.ModificarAlumno.TypeInference.CreateValidationMessage_1(__builder2, 70, 71, 
#nullable restore
#line 35 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                                              () => alumno.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(72, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n            ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group row");
                __builder2.AddMarkupContent(77, "\r\n                ");
                __builder2.AddMarkupContent(78, "<label for=\"Foto\" class=\"col-sm-2 col-form-label\">Foto</label>\r\n                ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "col-sm-10");
                __builder2.AddMarkupContent(81, "\r\n                    ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(82);
                __builder2.AddAttribute(83, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 41 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                                         FicheroSeleccionado

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(84, "Value", 
#nullable restore
#line 41 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                                                                           alumno.Foto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(85, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => alumno.Foto = __value, alumno.Foto));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n                    ");
                __Blazor.BlazorServer.Pages.ModificarAlumno.TypeInference.CreateValidationMessage_2(__builder2, 87, 88, 
#nullable restore
#line 42 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                                              () => alumno.Foto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(89, "\r\n");
#nullable restore
#line 43 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                     if (fichero != null)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(90, "                        ");
                __builder2.OpenElement(91, "p");
                __builder2.OpenElement(92, "strong");
                __builder2.AddContent(93, "Fichero seleccionado: ");
                __builder2.AddContent(94, 
#nullable restore
#line 45 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                                                          fichero.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n");
#nullable restore
#line 46 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(96, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n\r\n            ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-group row");
                __builder2.AddMarkupContent(101, "\r\n                ");
                __builder2.OpenElement(102, "label");
                __builder2.AddAttribute(103, "for", "Email");
                __builder2.AddAttribute(104, "class", "col-sm-4 col-form-label");
                __builder2.AddContent(105, "Alumno esta de baja: ");
                __builder2.AddContent(106, 
#nullable restore
#line 51 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                                                                                         alumno.FechaBaja

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n\r\n\r\n\r\n            ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "row content");
                __builder2.AddMarkupContent(111, "\r\n                ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "col-md-1");
                __builder2.AddMarkupContent(114, "\r\n                    ");
                __builder2.OpenElement(115, "input");
                __builder2.AddAttribute(116, "type", "submit");
                __builder2.AddAttribute(117, "class", "btn btn-primary");
                __builder2.AddAttribute(118, "value", "Guardar");
                __builder2.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                                                                                           Guardar

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n                ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "col-md-2");
                __builder2.AddMarkupContent(124, "\r\n                    ");
                __builder2.OpenElement(125, "input");
                __builder2.AddAttribute(126, "type", "button");
                __builder2.AddAttribute(127, "value", "Cancelar");
                __builder2.AddAttribute(128, "class", "btn btn-danger");
                __builder2.AddAttribute(129, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                                                                                           Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(133, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n\r\n");
#nullable restore
#line 68 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
 if (mostrarError)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(136, "    ");
            __builder.OpenElement(137, "div");
            __builder.AddAttribute(138, "class", "modal bg-secondary");
            __builder.AddAttribute(139, "tabindex", "-1");
            __builder.AddAttribute(140, "style", "display:block;");
            __builder.AddAttribute(141, "role", "dialog");
            __builder.AddMarkupContent(142, "\r\n        ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "modal-dialog modal-confirm");
            __builder.AddMarkupContent(145, "\r\n            ");
            __builder.OpenElement(146, "div");
            __builder.AddAttribute(147, "class", "modal-content ");
            __builder.AddMarkupContent(148, "\r\n                ");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "class", "modal-header justify-content-center bg-info");
            __builder.AddMarkupContent(151, "\r\n                    ");
            __builder.AddMarkupContent(152, "<div>\r\n                        <strong>Se produjo un error al realizar la operación.</strong>\r\n                    </div>\r\n                    ");
            __builder.OpenElement(153, "button");
            __builder.AddAttribute(154, "type", "button");
            __builder.AddAttribute(155, "class", "close");
            __builder.AddAttribute(156, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                                      CerrarError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(157, "\r\n                        ");
            __builder.AddMarkupContent(158, "<i class=\"large material-icons\">cancel</i>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n                ");
            __builder.OpenElement(161, "div");
            __builder.AddAttribute(162, "class", "modal-body text-center");
            __builder.AddMarkupContent(163, "\r\n                    ");
            __builder.AddMarkupContent(164, "<h4>Ooops!</h4>\r\n                    ");
            __builder.OpenElement(165, "p");
            __builder.AddContent(166, 
#nullable restore
#line 84 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                        textoError

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n                    ");
            __builder.OpenElement(168, "button");
            __builder.AddAttribute(169, "class", "btn btn-success");
            __builder.AddAttribute(170, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
                                                              CerrarError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(171, "data-dismiss", "modal");
            __builder.AddContent(172, "Cerrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n");
#nullable restore
#line 90 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\AxelEduardo\Documents\Software learning\BlazorCursoUdemy\BlazorServer\Pages\ModificarAlumno.razor"
      
    [Parameter]
    public int id { get; set; }
    Alumno alumno = new Alumno();
    IFileListEntry fichero;

    Boolean mostrarError = false;
    String textoError = String.Empty;

    Login l = new Login();
    UsuarioAPI u = new UsuarioAPI();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            l.Usuario = Environment.GetEnvironmentVariable("UsuarioAPI");
            l.Password = Environment.GetEnvironmentVariable("UsuarioAPI");
            u = (await SevicioLogin.SolicitudLogin(l));
            Environment.SetEnvironmentVariable("Token", u.Token);

            if (id > 0)
            {
                alumno = await ServicioAlumnos.DameAlumno(id);
            }
        }
        catch (Exception ex)
        {
            textoError = ex.Message;
            MostrarError();
            StateHasChanged();
        }

    }

    public void HandleValidSubmit()
    {
        Console.WriteLine("OnValidSubmit");
    }

    public void FicheroSeleccionado(IFileListEntry[] ficheros)
    {
        fichero = ficheros[0];
        string extension = Path.GetExtension(fichero.Name);
        if (extension != ".jpg")
            fichero = null;
    }

    protected async Task Guardar()
    {
        try
        {
            if (alumno.Nombre != null && alumno.Email != null)
            {
                if (fichero != null && fichero.Data != null)
                {
                    var ms = new MemoryStream();
                    await fichero.Data.CopyToAsync(ms);
                    string nombreFichero = "images/" + Guid.NewGuid() + ".jpg";
                    using (FileStream file = new FileStream("wwwroot/" + nombreFichero, FileMode.Create, FileAccess.Write))
                        ms.WriteTo(file);

                    alumno.Foto = nombreFichero;
                }
                alumno = (await ServicioAlumnos.ModificarAlumno(alumno.Id, alumno));
                navigationManager.NavigateTo("/listaAlumnos");
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
        navigationManager.NavigateTo("/listaAlumnos");
    }

    public Boolean dameValor()
    {
        Boolean estaDeBaja = false;
        if (alumno.FechaBaja != null)
            estaDeBaja = true;

        return estaDeBaja;
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioAlumnos ServicioAlumnos { get; set; }
    }
}
namespace __Blazor.BlazorServer.Pages.ModificarAlumno
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
