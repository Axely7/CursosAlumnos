using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModeloClasesAlumnos;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;

namespace BlazorServer.Servicios
{
    public class ServicioCursos:IServicioCursos
    {
        private readonly HttpClient httpClient;
        private readonly ILogger<ServicioCursos> log;

        public ServicioCursos(HttpClient httpClient, ILogger<ServicioCursos> l)
        {
            this.httpClient = httpClient;
            this.log = l;
        }

        public async Task<IEnumerable<Curso>> DameCursos(int idalumno)
        {
            string token = Environment.GetEnvironmentVariable("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            List<Curso> c = await httpClient.GetJsonAsync<List<Curso>>("API/AlumnosCursos/" + idalumno.ToString());
            if (c != null && c[0].error != null && c[0].error.mensaje != String.Empty)
            {
                if (c[0].error.mostrarUsuario)
                {
                    log.LogError("Error obteniendo cursos del alumno: " + c[0].error.mensaje);
                    throw new Exception(c[0].error.mensaje);
                }
                else
                {
                    log.LogError("Error obteniendo cursos del alumno: " + c[0].error.mensaje);
                    throw new Exception("Error obteniendo curso del alumno");
                }

            }

            return c;
        }

        public async Task<Curso> AltaCurso(Curso curso)
        {
            string token = Environment.GetEnvironmentVariable("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Curso c = await httpClient.PostJsonAsync<Curso>("API/Cursos/", curso);
            if (c.error != null && c.error.mensaje != String.Empty)
            {
                if (c.error.mostrarUsuario)
                {
                    log.LogError("Error dando de alta nuestro curso: " + c.error.mensaje);
                    throw new Exception(c.error.mensaje);
                }
                else
                {
                    log.LogError("Error dando de alta nuestro curso: " + c.error.mensaje);
                    throw new Exception("Error dando de alta nuestro curso");
                }

            }

            return c;
        }

        public async Task<Curso> DameCurso(int IdCurso, int idPrecio)
        {
            string token = Environment.GetEnvironmentVariable("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Curso c = await httpClient.GetJsonAsync<Curso>("API/Cursos/" + IdCurso.ToString() + "/" + idPrecio.ToString());
            if (c.error != null && c.error.mensaje != String.Empty)
            {
                if (c.error.mostrarUsuario)
                {
                    log.LogError("Error buscando nuestro curso: " + c.error.mensaje);
                    throw new Exception(c.error.mensaje);
                }
                else
                {
                    log.LogError("Error buscando nuestro curso: " + c.error.mensaje);
                    throw new Exception("Error buscando nuestro curso");
                }

            }

            return c;
        }

        public async Task<Curso> ModificarCurso(int id, Curso curso)
        {
            string token = Environment.GetEnvironmentVariable("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Curso c = await httpClient.PutJsonAsync<Curso>("API/Cursos/" + id.ToString(), curso);
            if (c.error != null && c.error.mensaje != String.Empty)
            {
                if (c.error.mostrarUsuario)
                {
                    log.LogError("Error modificando nuestro curso: " + c.error.mensaje);
                    throw new Exception(c.error.mensaje);
                }
                else
                {
                    log.LogError("Error modificando nuestro curso: " + c.error.mensaje);
                    throw new Exception("Error modificando nuestro curso");
                }

            }

            return c;
        }

        public async Task BorrarCurso(int id)
        {
            string token = Environment.GetEnvironmentVariable("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = await httpClient.DeleteAsync($"API/Cursos/{id}");
            if (!response.IsSuccessStatusCode)
            {
                if(response.StatusCode == System.Net.HttpStatusCode.SeeOther)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    log.LogError("Error borrando nuestro curso: " + error);
                    throw new Exception(error);
                }
                else
                {
                    log.LogError("Error borrando nuestro curso: " + response.ReasonPhrase);
                    throw new Exception("Se produjo un error borrando a nuestro cliente");
                }
            }
                
        }

    }
}
