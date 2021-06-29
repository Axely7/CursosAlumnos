using BlazorServer.Servicios;
using Microsoft.AspNetCore.Components;
using ModeloClasesAlumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Pages
{
    public class DetalleAlumnoBase: ComponentBase
    {
        [Inject]
        public IServicioAlumnos ServicioAlumnos { get; set; }
        [Inject]
        public IServicioLogin ServicioLogin { get; set; }
        [Parameter]
        public string Id { get; set; }
        public Alumno alumno { get; set; } = new Alumno();

        public Boolean mostrarError = false;
        public String textoError = String.Empty;

        Login l = new Login();
        Usuario u = new Usuario();
        protected override async Task OnInitializedAsync()
        {
            try
            {
                l.Usuario = Environment.GetEnvironmentVariable("UsuarioAPI");
                l.Password = Environment.GetEnvironmentVariable("UsuarioAPI");
                u = (await ServicioLogin.SolicitudLogin(l));
                Environment.SetEnvironmentVariable("Token", u.Token);
                alumno = (await ServicioAlumnos.DameAlumno(Convert.ToInt32(Id)));
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
    }
}
