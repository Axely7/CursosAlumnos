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
        [Parameter]
        public string Id { get; set; }
        public Alumno alumno { get; set; } = new Alumno();

        protected override async Task OnInitializedAsync()
        {
            alumno = (await ServicioAlumnos.DameAlumno(Convert.ToInt32(Id)));
        }
    }
}
