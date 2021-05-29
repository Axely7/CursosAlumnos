using BlazorServer.Servicios;
using Microsoft.AspNetCore.Components;
using ModeloClasesAlumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Pages
{
    public class NuevoAlumnoBase: ComponentBase
    {
        [Inject]
        public IServicioAlumnos ServicioAlumnos { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; } //Redirige a diferentes paginas
        public Alumno alumno = new Alumno();

        public void HandleValidSubmit()
        {
            //Para realizar las validaciones
            Console.WriteLine("OnValidSubmit");
        }

        protected async Task Guardar()
        {
            alumno.FechaAlta = DateTime.Now;
            if(alumno.Nombre != null && alumno.Email != null && alumno.Foto != null)
            {
                alumno = (await ServicioAlumnos.CrearAlumno(alumno));
                navigationManager.NavigateTo("/listaAlumnos");
            }
        }
        protected void Cancelar()
        {
            navigationManager.NavigateTo("/listaAlumnos");
        }
    }
}
