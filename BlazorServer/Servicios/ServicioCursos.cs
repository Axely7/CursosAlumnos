using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModeloClasesAlumnos;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BlazorServer.Servicios
{
    public class ServicioCursos:IServicioCursos
    {
        private readonly HttpClient httpClient;

        public ServicioCursos(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Curso>> DameCursos(int idalumno)
        {
            return await httpClient.GetJsonAsync<Curso[]>("API/AlumnosCursos/" + idalumno.ToString());
        }

        public async Task<Curso> AltaCurso(Curso curso)
        {
            return await httpClient.PostJsonAsync<Curso>("API/Cursos/", curso);
        }

        public async Task<Curso> DameCurso(int IdCurso, int idPrecio)
        {
            return await httpClient.GetJsonAsync<Curso>("API/Cursos/" + IdCurso.ToString() + "/" + idPrecio.ToString());
        }

        public async Task<Curso> ModificarCurso(int id, Curso curso)
        {
            return await httpClient.PutJsonAsync<Curso>("API/Cursos/" + id.ToString(), curso);
        }

        public async Task BorrarCurso(int id)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync($"API/Cursos/{id}");
            if (!response.IsSuccessStatusCode)
                throw new Exception("Se produjo un error borrando a nuestro cliente");
        }

    }
}
