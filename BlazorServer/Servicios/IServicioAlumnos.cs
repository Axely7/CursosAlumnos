using ModeloClasesAlumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Servicios
{
    public interface IServicioAlumnos
    {
        Task<IEnumerable<Alumno>> DameAlumnos();
        Task<Alumno> DameAlumno (int id);
        Task<Alumno> CrearAlumno(Alumno alumno);
        Task<Alumno> ModificarAlumno(int id, Alumno alumno);
        Task BorrarAlumno(int id);
        Task<Alumno> CursosInscritosAlumno(int id);
    }
}
