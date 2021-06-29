using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModeloClasesAlumnos;
using System.Net.Http; //para realizar peticion a servicios
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System.Net;

namespace BlazorServer.Servicios
{
    public class ServicioAlumnos:IServicioAlumnos
    {
        private readonly HttpClient httpClient;
        private readonly ILogger<ServicioAlumnos> log;

        public ServicioAlumnos(HttpClient httpClient, ILogger<ServicioAlumnos> l)
        {
            this.httpClient = httpClient;
            this.log = l;
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
            HttpResponseMessage response = await httpClient.DeleteAsync($"API/Alumnos/{id}");
            if (!response.IsSuccessStatusCode)
            {
                if(response.StatusCode == HttpStatusCode.SeeOther)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    log.LogError("Error borrando nuestro alumno: " + error);
                    throw new Exception(error);
                }
                else
                {
                    log.LogError("Error borrando nuestro alumno: " + response.ReasonPhrase);
                    throw new Exception("Se produjo un error borrando nuestro alumno");
                }
            }
        }

        public async Task<Alumno> CursosInscritosAlumno(int id)
        {
            return await httpClient.GetJsonAsync<Alumno>("API/Alumnos/CursosAlumno/" + id.ToString());
        }

        public async Task<Alumno> CursosInscribirAlumno(Alumno alumno, int idCurso, int idprecio)
        {
            return await httpClient.PostJsonAsync<Alumno>("API/Alumnos/InscribirAlumno/" + idCurso.ToString() + "/" + idprecio.ToString(), alumno);
        }
    }
}
