using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModeloClasesAlumnos;
using System.Net.Http; //para realizar peticion a servicios
using Microsoft.AspNetCore.Components;

namespace BlazorServer.Servicios
{
    public class ServicioAlumnos:IServicioAlumnos
    {
        private readonly HttpClient httpClient;

        public ServicioAlumnos(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Alumno>> DameAlumnos()
        {
            return await httpClient.GetJsonAsync<Alumno[]>("API/Alumnos");
        }

        public async Task<Alumno> DameAlumno(int id)
        {
            return await httpClient.GetJsonAsync<Alumno>("API/Alumnos/" + id.ToString());
        }

        public async Task<Alumno> CrearAlumno(Alumno alumno)
        {
            return await httpClient.PostJsonAsync<Alumno>("API/Alumnos/", alumno);
        }

        public async Task<Alumno> ModificarAlumno(int id, Alumno alumno)
        {
            return await httpClient.PutJsonAsync<Alumno>("API/Alumnos/" + id.ToString(), alumno);
        }

        public async Task BorrarAlumno(int id)
        {
            await httpClient.DeleteAsync($"API/Alumnos/{id}");
        }
    }
}
