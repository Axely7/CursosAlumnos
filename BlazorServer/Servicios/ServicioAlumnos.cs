using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModeloClasesAlumnos;
using System.Net.Http; //para realizar peticion a servicios
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Http.Headers;

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
            string token = Environment.GetEnvironmentVariable("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            List<Alumno> alu = await httpClient.GetJsonAsync<List<Alumno>>("API/Alumnos");
            if(alu !=  null && alu[0].error != null && alu[0].error.mensaje != String.Empty)
            {
                if (alu[0].error.mostrarUsuario)
                {
                    log.LogError("Error obteniendo alumnos: " + alu[0].error.mensaje);
                    throw new Exception(alu[0].error.mensaje);
                }
                else
                {
                    log.LogError("Error obteniendo alumnos: " + alu[0].error.mensaje);
                    throw new Exception("Error obteniendo alumnos");
                }
            }
            return alu;
        }

        public async Task<Alumno> DameAlumno(int id)
        {
            string token = Environment.GetEnvironmentVariable("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Alumno alu = await httpClient.GetJsonAsync<Alumno>("API/Alumnos/" + id.ToString());
            if(alu.error != null && alu.error.mensaje != String.Empty)
            {
                if (alu.error.mostrarUsuario)
                {
                    log.LogError("Error buscando nustro alumno: " + alu.error.mensaje);
                    throw new Exception(alu.error.mensaje);
                }
                else
                {
                    log.LogError("Error buscando nuestro alumno: " + alu.error.mensaje);
                    throw new Exception("Error buscando nuestro alumno");
                }
            }
            return alu;
        }

        public async Task<Alumno> CrearAlumno(Alumno alumno)
        {
            string token = Environment.GetEnvironmentVariable("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Alumno alu = await httpClient.PostJsonAsync<Alumno>("API/Alumnos/", alumno);
            if(alu.error != null && alu.error.mensaje != String.Empty)
            {
                if (alu.error.mostrarUsuario)
                {
                    log.LogError("Error creando nuestro alumno: " + alu.error.mensaje);
                    throw new Exception(alu.error.mensaje);
                }
                else
                {
                    log.LogError("Error creando nuestro alumno: " + alu.error.mensaje);
                    throw new Exception("Error creando nuestro alumno");
                }
            }
            return alu;
        }

        public async Task<Alumno> ModificarAlumno(int id, Alumno alumno)
        {
            string token = Environment.GetEnvironmentVariable("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Alumno alu =  await httpClient.PutJsonAsync<Alumno>("API/Alumnos/" + id.ToString(), alumno);
            if(alu.error != null && alu.error.mensaje != String.Empty)
            {
                if (alu.error.mostrarUsuario)
                {
                    log.LogError("Error modificando nuestro alumno: " + alu.error.mensaje);
                    throw new Exception(alu.error.mensaje);
                }
                else
                {
                    log.LogError("Error modificando nuestro alumno: " + alu.error.mensaje);
                    throw new Exception("Error modificano nuestro alumno");
                }
            }
            return alu;
        }

        public async Task BorrarAlumno(int id)
        {
            string token = Environment.GetEnvironmentVariable("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
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
            string token = Environment.GetEnvironmentVariable("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Alumno alu = await httpClient.GetJsonAsync<Alumno>("API/Alumnos/CursosAlumno/" + id.ToString());
            if(alu.error != null && alu.error.mensaje != string.Empty)
            {
                if (alu.error.mostrarUsuario)
                {
                    log.LogError("Error obteniendo los cursos de nuestro alumno: " + alu.error.mensaje);
                    throw new Exception(alu.error.mensaje);
                }
                else
                {
                    log.LogError("Error obteniendo los cursos de nuestro alumno: " + alu.error.mensaje);
                    throw new Exception("Error obteniendo los cursos de  nuestro alumno");
                }
            }
            return alu;
        }

        public async Task<Alumno> CursosInscribirAlumno(Alumno alumno, int idCurso, int idprecio)
        {
            string token = Environment.GetEnvironmentVariable("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Alumno alu = await httpClient.PostJsonAsync<Alumno>("API/Alumnos/InscribirAlumno/" + idCurso.ToString() + "/" + idprecio.ToString(), alumno);
            if(alu.error != null && alu.error.mensaje != String.Empty)
            {
                if (alu.error.mostrarUsuario)
                {
                    log.LogError("Error inscribiendo en un curso a nuestro alumno: " + alu.error.mensaje);
                    throw new Exception(alu.error.mensaje);
                }
                else
                {
                    log.LogError("Error inscribiendo en un curso a nuestro alumno: " + alu.error.mensaje);
                    throw new Exception("Error inscribiendo en un curso a nuestro alumno");
                }
            }
            return alu;
        }
    }
}
