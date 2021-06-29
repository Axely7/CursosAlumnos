using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using ModeloClasesAlumnos;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Headers;

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

        public async Task<UsuarioAPI> SolicitudLogin(Login l)
        {
            UsuarioAPI u = await httpClient.PostJsonAsync<UsuarioAPI>("API/Login/", l);

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

        public async Task<UsuarioLogin> CrearUsuario(UsuarioLogin usuarioLogin)
        {
            string token = Environment.GetEnvironmentVariable("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            UsuarioLogin usuario = await httpClient.PostJsonAsync<UsuarioLogin>("API/Login/CrearUsuario/", usuarioLogin);
            if (usuario.error != null && usuario.error.mensaje != String.Empty)
            {
                if (usuario.error.mostrarUsuario)
                {
                    log.LogError("Error creando nuestro usuario:  " + usuario.error.mensaje);
                    throw new Exception(usuario.error.mensaje);
                }
                else
                {
                    log.LogError("Error creando nuestro usuario: " + usuario.error.mensaje);
                    throw new Exception("Error creando nuestro usuario");
                }

            }

            return usuario;
        }
    }
}

