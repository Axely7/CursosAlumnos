using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModeloClasesAlumnos;
using Microsoft.AspNetCore.Mvc;
using APIAlumnos.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace APIAlumnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController:ControllerBase
    {
        
        private readonly IRepositorioCursos cursosRepositorio;
        private readonly ILogger<CursosController> log;
        public CursosController(IRepositorioCursos cursosRepositorio, ILogger<CursosController> l)
        {
            this.cursosRepositorio = cursosRepositorio;
            this.log = l;
        }

        [HttpPost]
        public async Task<ActionResult<Curso>> AltaCurso(Curso curso)
        {
            try
            {
                if (curso == null || curso.ListaPrecios == null)
                    return BadRequest();
                var cursoAux = await cursosRepositorio.DameCurso(curso.NombreCurso);
                if(cursoAux != null)
                {
                    ModelState.AddModelError("Nombre", "El curso ya existe");
                    return BadRequest(ModelState);
                }

                var nuevoCurso = await cursosRepositorio.AltaCurso(curso);

                return nuevoCurso;
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de cursos en el método AltaCurso:" + ex.ToString());

                return StatusCode(StatusCodes.Status500InternalServerError, "Error dando de alta nuevo curso");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Curso>> BorrarCurso(int id)
        {
            try
            {
                var cursoBorrar = await cursosRepositorio.DameCurso(id);
                if(cursoBorrar == null)
                {
                    return NotFound($"Curso con id = {id} no encontrado");
                }
                return await cursosRepositorio.BorrarCurso(id);
            }
            catch(Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de cursos en el método BorrarCurso: "+ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error borrando curso");
            }
        }

        [HttpGet("{id:int}/{idprecio:int}")]
        public async Task<ActionResult<Curso>> DameCurso(int id, int idprecio)
        {
            try
            {
                var resultado = await cursosRepositorio.DameCurso(id, idprecio);
                if (resultado == null)
                    return NotFound();

                return resultado;
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de cursos en el método DameCurso: " + ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error obteniendo los datos");
            }
        }



        [HttpGet("{id:int}")]
        public async Task<ActionResult<Curso>> DameCurso(int id)
        {
            try
            {
                var resultado = await cursosRepositorio.DameCurso(id);
                if (resultado == null)
                    return NotFound();

                return resultado;
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de cursos en el método DameCurso: " + ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error obteniendo los datos");
            }
        }

        [HttpGet("{DameCurso}")]
        public async Task<ActionResult> DameCurso(string nombreCurso)
        {
            try
            {
                return Ok(await cursosRepositorio.DameCurso(nombreCurso));
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de cursos en el método DameCurso: " + ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error obteniedo los datos");
            }
        }

        [Route("~/api/AlumnosCursos/{idAlumno}")]
        public async Task<ActionResult> DameCursos(int idAlumno)
        {
            try
            {
                return Ok(await cursosRepositorio.DameCursos(idAlumno));
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de cursos en el método DameCursos: " + ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error obteniendo los datos");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Curso>> ModificarCurso(int id, Curso curso)
        {
            try
            {
                if (id != curso.Id)
                    return BadRequest("Curso Id no coincide");
                var cursoModificar = await cursosRepositorio.DameCurso(id);

                if (cursoModificar == null)
                    return NotFound($"Curso con = {id} no encontrado");
                return await cursosRepositorio.ModificarCursos(curso);
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de cursos en el método ModificarCurso: " + ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error actualizando datos");
            }

        }
    }
}
