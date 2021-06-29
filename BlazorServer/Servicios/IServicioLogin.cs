using ModeloClasesAlumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Servicios
{
    public interface IServicioLogin
    {
        Task<UsuarioAPI> SolicitudLogin(Login l);
        Task<UsuarioLogin> CrearUsuario(UsuarioLogin usuario);
    }
}
