using ModeloClasesAlumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAlumnos.Repositorio
{
    public interface IRepositorioCursos
    {
        //Daremos de alta un curso y su precio
        Task<Curso> AltaCurso(Curso curso);
        //Devolveremos todos los cursos con sus precios
        //Si el parametro idalumno viene a -1 damos todos los cursos. Si no
        //damos los cursos en los que no este inscrito ese alumno
        Task<IEnumerable<Curso>> DameCursos(int idAlumno);
        //Devolvera los datos de un curso con sus precios buscando por id
        Task<Curso> DameCurso(int id);
        //Devolvera los datos de un cuso con sus precios buscando por curso
        Task<Curso> DameCurso(string nombreCurso);
        //Podremos modificar los datos de un curso y sus precios
        Task<Curso> ModificarCursos(Curso curso);

        //Borrar curso
        Task<Curso> BorrarCurso(int id);
    }
}
