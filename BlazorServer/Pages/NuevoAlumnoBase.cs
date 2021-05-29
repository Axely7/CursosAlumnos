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
        [Parameter]
        public NavigationManager navigationManager { get; set; }
        public Alumno alumno = new Alumno();

        private void HandleValidSubmit()
        {
            Console.WriteLine("OnValidSubmit");
        }
    }
}
