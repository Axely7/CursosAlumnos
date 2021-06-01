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
        public NavigationManager navigationManager { get; set; }
       public IEnumerable<Alumno> Alumnos { get; set; }

        public bool MostrarPopUP = false;
        public int idAlumnoBorrar = -1;

        protected override async Task OnInitializedAsync()
        {
            Alumnos = (await ServicioAlumnos.DameAlumnos()).ToList();
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
            ServicioAlumnos.BorrarAlumno(id);
            CerrarPop();
            navigationManager.NavigateTo("listaAlumnos", true);
        }
    }

    
}
