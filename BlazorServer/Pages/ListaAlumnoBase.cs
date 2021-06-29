using Microsoft.AspNetCore.Components;
using ModeloClasesAlumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorServer.Servicios;



namespace BlazorServer.Pages
{
    public class ListaAlumnoBase: ComponentBase 
    {
       [Inject]
       public IServicioAlumnos ServicioAlumnos { get; set; }
        [Inject]
        public IServicioLogin ServicioLogin { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }
       public IEnumerable<Alumno> Alumnos { get; set; }

        public bool MostrarPopUP = false;
        public int idAlumnoBorrar = -1;

        public Boolean mostrarError = false;
        public String textoError = String.Empty;

        Login l = new Login();
        UsuarioAPI u = new UsuarioAPI();
        protected override async Task OnInitializedAsync()
        {
            try
            {
                l.Usuario = Environment.GetEnvironmentVariable("UsuarioAPI");
                l.Password = Environment.GetEnvironmentVariable("UsuarioAPI");
                u = (await ServicioLogin.SolicitudLogin(l));
                Environment.SetEnvironmentVariable("Token", u.Token);


                Alumnos = (await ServicioAlumnos.DameAlumnos()).ToList();
            }
            catch (Exception ex)
            {
                textoError = ex.Message;
                MostrarError();
                StateHasChanged();
            }
        }

        protected void Borrar(int idAlumno)
        {
            idAlumnoBorrar = idAlumno;
            MostrarPopUP = true;
        }

        protected void CerrarPop()
        {
            idAlumnoBorrar = -1;
            MostrarPopUP = false;
        }

        protected void DarDeBaja(int id)
        {
            try
            {
                ServicioAlumnos.BorrarAlumno(id);
                CerrarPop();
                navigationManager.NavigateTo("listaAlumnos", true);
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
            CerrarPop();
        }

        protected void MostrarError()
        {
            CerrarPop();
            mostrarError = true;
        }
    }

    
}
