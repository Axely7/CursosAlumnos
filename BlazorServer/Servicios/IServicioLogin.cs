using ModeloClasesAlumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Servicios
{
    public interface IServicioLogin
    {
        Task<Usuario> SolicitudLogin(Login l);
    }
}
