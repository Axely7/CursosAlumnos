using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModeloClasesAlumnos;
using Microsoft.AspNetCore.Mvc;
using APIAlumnos.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace APIAlumnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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
            Curso nuevoCurso = new Curso();
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

                nuevoCurso = await cursosRepositorio.AltaCurso(curso);
            }
            catch(SqlException ex)
            {
                nuevoCurso.error = new Error();
                log.LogError("Se produjo un error en el controlador de cursos en el método AltaCurso: " + ex.ToString());
                nuevoCurso.error.mensaje = "Error creando curso " + ex.Message;
                nuevoCurso.error.mostrarUsuario = true;
            }
            catch (Exception ex)
            {
                nuevoCurso.error = new Error();
                log.LogError("Se produjo un error en el controlador de cursos en el método AltaCurso:" + ex.ToString());
                nuevoCurso.error.mensaje = ex.ToString();
                nuevoCurso.error.mostrarUsuario = false;
                
            }
            return nuevoCurso;
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
            catch (SqlException ex)
            {
                log.LogError("Se produjo un error en el controlador de cursos en el método BorrarCurso:" + ex.ToString());
                return StatusCode(StatusCodes.Status303SeeOther, ex.Message);

            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de cursos en el método BorrarCurso: "+ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error borrando curso");
            }
        }

        [HttpGet("{id:int}/{idprecio:int}")]
        public async Task<ActionResult<Curso>> DameCurso(int id, int idprecio)
        {
            Curso resultado = new Curso();
            try
            {
                resultado = await cursosRepositorio.DameCurso(id, idprecio);
                if (resultado == null)
                    return NotFound();

              
            }
            catch (SqlException ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de cursos en el método DameCurso:" + ex.ToString());
                resultado.error.mensaje = "Error obteniendo el curso " + ex.Message;
                resultado.error.mostrarUsuario = true;
            }
            catch (Exception ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de cursos en el método DameCurso: " + ex.ToString());
                resultado.error.mensaje = ex.ToString();
                resultado.error.mostrarUsuario = false;
            }

            return resultado;
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
        public async Task<ActionResult<Curso>> DameCurso(string nombreCurso)
        {
            Curso resultado = new Curso();
            try
            {
               resultado =  (await cursosRepositorio.DameCurso(nombreCurso));
            }
            catch (SqlException ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de cursos en el método DameCurso:" + ex.ToString());
                resultado.error.mensaje = "Error obteniendo el curso " + ex.Message;
                resultado.error.mostrarUsuario = true;
            }
            catch (Exception ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de cursos en el método DameCurso: " + ex.ToString());
                resultado.error.mensaje = ex.ToString();
                resultado.error.mostrarUsuario = false;
            }
            return resultado;
        }

        [Route("~/api/AlumnosCursos/{idAlumno}")]
        public async Task<ActionResult<List<Curso>>> DameCursos(int idAlumno)
        {
            List<Curso> resultado = new List<Curso>();
            Curso Aux = new Curso();

            try
            {
                resultado = (List<Curso>)await cursosRepositorio.DameCursos(idAlumno);
            }
            catch (SqlException ex)
            {
                Aux.error = new Error();
                log.LogError("Se produjo un error en el controlador de cursos en el método DameCursos:" + ex.ToString());
                Aux.error.mensaje = "Error obteniendo lista de cursos " + ex.Message;
                Aux.error.mostrarUsuario = true;
                resultado.Add(Aux);
            }
            catch (Exception ex)
            {
                Aux.error = new Error();
                log.LogError("Se produjo un error en el controlador de cursos en el método DameCursos: " + ex.ToString());
                Aux.error.mensaje = ex.ToString();
                Aux.error.mostrarUsuario = false;
                resultado.Add(Aux);
            }
            return resultado;
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Curso>> ModificarCurso(int id, Curso curso)
        {
            Curso resultado = new Curso();
            try
            {
                if (id != curso.Id)
                    return BadRequest("Curso Id no coincide");
                var cursoModificar = await cursosRepositorio.DameCurso(id);

                if (cursoModificar == null)
                    return NotFound($"Curso con = {id} no encontrado");
                resultado = await cursosRepositorio.ModificarCursos(curso);
            }
            catch (SqlException ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de cursos en el método ModificarCurso:" + ex.ToString());
                resultado.error.mensaje = "Error modificando el curso " + ex.Message;
                resultado.error.mostrarUsuario = true;
            }
            catch (Exception ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de cursos en el método ModificarCurso: " + ex.ToString());
                resultado.error.mensaje = ex.ToString();
                resultado.error.mostrarUsuario = false;
            }
            return resultado;

        }
    }
}
