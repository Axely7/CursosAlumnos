using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModeloClasesAlumnos;

namespace BlazorServer.Servicios
{
    public interface IServicioCursos
    {
        Task<IEnumerable<Curso>> DameCursos(int idalumno);
        Task<Curso> AltaCurso(Curso curso);
    }
}
