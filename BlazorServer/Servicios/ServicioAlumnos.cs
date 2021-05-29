﻿using System;
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
    }
}
