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
       public IEnumerable<Alumno> Alumnos { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Alumnos = (await ServicioAlumnos.DameAlumnos()).ToList();
        }

    }

    
}
