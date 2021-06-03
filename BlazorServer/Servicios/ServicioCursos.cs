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
    }
}
