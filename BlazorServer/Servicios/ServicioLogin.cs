using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using ModeloClasesAlumnos;
using Microsoft.AspNetCore.Components;

namespace BlazorServer.Servicios
{
    public class ServicioLogin:IServicioLogin
    {
        private readonly HttpClient httpClient;
        private readonly ILogger<ServicioCursos> log;

        public ServicioLogin(HttpClient httpClient, ILogger<ServicioCursos> l)
        {
            this.httpClient = httpClient;
            this.log = l;
        }

        public async Task<Usuario> SolicitudLogin(Login l)
        {
            Usuario u = await httpClient.PostJsonAsync<Usuario>("API/Login/", l);

            if (u.error != null && u.error.mensaje != String.Empty)
            {
                if (u.error.mostrarUsuario)
                {
                    log.LogError("Error dando de alta nuestro curso: " + u.error.mensaje);
                    throw new Exception(u.error.mensaje);
                }
                else
                {
                    log.LogError("Error dando de alta nuestro curso: " + u.error.mensaje);
                    throw new Exception("Error dando de alta nuestro curso");
                }

            }

            return u;




        }
    }
}

