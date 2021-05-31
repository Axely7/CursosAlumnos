﻿using BlazorServer.Servicios;
using Microsoft.AspNetCore.Components;
using ModeloClasesAlumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorInputFile;
using System.IO;

namespace BlazorServer.Pages
{
    public class NuevoAlumnoBase: ComponentBase
    {
        [Inject]
        public IServicioAlumnos ServicioAlumnos { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; } //Redirige a diferentes paginas
        public Alumno alumno = new Alumno();
        public IFileListEntry fichero;

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
                var ms = new MemoryStream();
                await fichero.Data.CopyToAsync(ms);
                string nombreFichero = "images/" + Guid.NewGuid() + ".jpg"; //Gnera ruta
                using (FileStream file = new FileStream("wwwroot/" + nombreFichero, FileMode.Create, FileAccess.Write)) ms.WriteTo(file);
                alumno.Foto = nombreFichero;
                alumno = await ServicioAlumnos.CrearAlumno(alumno);
                navigationManager.NavigateTo("/listaAlumnos");
            }
        }
        protected void Cancelar()
        {
            navigationManager.NavigateTo("/listaAlumnos");
        }

        public void HandleFileSelected(IFileListEntry[] ficheros)
        {
            fichero = ficheros[0];
            string extension = Path.GetExtension(fichero.Name);

            if(extension == ".jpg" || extension == ".png")
            {
                alumno.Foto = fichero.Name;
            }
            else
            {
                fichero = null;
            }
        }
    }
}
