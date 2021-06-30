using Microsoft.AspNetCore.Mvc;
using APIAlumnos.Repositorio;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModeloClasesAlumnos;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace APIAlumnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AlumnosController:ControllerBase
    {
        private readonly IRepositorioAlumnos alumnosRepositorio;
        private readonly ILogger<AlumnosController> log;
        public AlumnosController(IRepositorioAlumnos alumnosRepositorio, ILogger<AlumnosController> l)
        {
            this.alumnosRepositorio = alumnosRepositorio;
            this.log = l;
        }

        [HttpGet]
        public async Task<ActionResult<List<Alumno>>> DameAlumnos()
        {
            List<Alumno> resultado = new List<Alumno>();
            Alumno Aux = new Alumno();
            try
            {
                resultado = (List<Alumno>)await alumnosRepositorio.DameAlumnos();
            }
            catch (SqlException ex)
            {
                Aux.error = new Error();
                log.LogError("Se produjo un error en el controlador de alumnos en el método DameAlumnos:" + ex.ToString());
                Aux.error.mensaje = "Error obteniendo lista de alumnos " + ex.Message;
                Aux.error.mostrarUsuario = true;
                resultado.Add(Aux);
            }
            catch (Exception ex)
            {
                Aux.error = new Error();
                log.LogError("Se produjo un error en el controlador de alumnos en el método DameAlumnos:" + ex.ToString());
                Aux.error.mensaje = ex.ToString();
                Aux.error.mostrarUsuario = false;
                resultado.Add(Aux);
            }
            return resultado;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Alumno>> DameAlumno(int id)
        {
            Alumno resultado = new Alumno();
            try
            {
                resultado = await alumnosRepositorio.DameAlumno(id);
                if (resultado.Id == null)
                    return NotFound();
            }
            catch (SqlException ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de alumnos en el método DameAlumno:" + ex.ToString());
                resultado.error.mensaje = "Error obteniendo el alumno " + ex.Message;
                resultado.error.mostrarUsuario = true;
            }
            catch (Exception ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de alumnos en el método DameAlumnos:" + ex.ToString());
                resultado.error.mensaje = ex.ToString();
                resultado.error.mostrarUsuario = false;
            }
            return resultado;
        }

        [HttpPost]

        public async Task<ActionResult<Alumno>> CrearAlumno(Alumno alumno)
        {
            Alumno resultado = new Alumno();
            try
            {
                if (alumno == null)
                    return BadRequest();

                var alumnoAux = await alumnosRepositorio.DameAlumno(alumno.Email);
                if(alumnoAux != null)
                {
                    ModelState.AddModelError("email", "El email ya esta en uso");
                    return BadRequest(ModelState);
                }


                resultado = await alumnosRepositorio.AltaAlumno(alumno);
               
            }
            catch (SqlException ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de alumnos en el método CrearAlumno:" + ex.ToString());
                resultado.error.mensaje = "Error dando de alta nuevo alumno" + ex.Message;
                resultado.error.mostrarUsuario = true;
            }
            catch (Exception ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de alumnos en el método CrearAlumnos:" + ex.ToString());
                resultado.error.mensaje = ex.ToString();
                resultado.error.mostrarUsuario = false;
            }
            return resultado;
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Alumno>> ModificarAlumno(int id, Alumno alumno)
        {
            Alumno resultado = new Alumno();
            try
            {
                if (id != alumno.Id)
                    return BadRequest("Alumno Id no coincide");

                var alumnoModificar = await alumnosRepositorio.DameAlumno(id);

                if (alumnoModificar == null)
                    return NotFound($"Alumno con = {id} no encontrado");

                resultado = await alumnosRepositorio.ModificarAlumno(alumno);
                
            }
            catch (SqlException ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de alumnos en el método ModificarAlumno:" + ex.ToString());
                resultado.error.mensaje = "Error actualizando datos" + ex.Message;
                resultado.error.mostrarUsuario = true;
            }
            catch (Exception ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de alumnos en el método ModificarAlumnos:" + ex.ToString());
                resultado.error.mensaje = ex.ToString();
                resultado.error.mostrarUsuario = false;
            }
            return resultado;
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Alumno>> BorrarAlumno(int id)
        {
            try
            {
                var alumnoBorrar = await alumnosRepositorio.DameAlumno(id);
                if(alumnoBorrar == null)
                {
                    return NotFound($"Alumno con id = {id} no encontrado");
                }

                return await alumnosRepositorio.BorrarAlumno(id);
            }
            catch (SqlException ex)
            {
                log.LogError("Se produjo un error en el controlador de alumnos en el método BorrarAlumno:" + ex.ToString());
                return StatusCode(StatusCodes.Status303SeeOther, ex.Message);
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de alumnos en el método BorrarAlumnos:" + ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error borrando alumno");
            }
        }

        [HttpGet("{BuscarAlumnos}")]
        public async Task<ActionResult> BuscarAlumnos(string texto)
        {
            try
            {
                return Ok(await alumnosRepositorio.BuscarAlumnos(texto));
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de alumnos en el método BuscarAlumnos:" + ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error obteniendo los datos");
            }
        }
        [Route("InscribirAlumno/{idCurso}/{idprecio}")]
        public async Task<ActionResult<Alumno>> InscribirAlumnoCurso([FromBody] Alumno alumno, int idCurso, int idprecio)
        {
            Alumno resultado = new Alumno();
            try
            {
                var alumnoValidar = await alumnosRepositorio.DameAlumno(alumno.Id);

                if (alumnoValidar == null)
                    return NotFound($"Alumno no encontrado");

                resultado = await alumnosRepositorio.InscribirAlumnoCurso(alumno, idCurso, idprecio);
            }
            catch (SqlException ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de alumnos en el método InscribirAlumnoCurso:" + ex.ToString());
                resultado.error.mensaje = "Error inscribiendo alumno en el curso" + ex.Message;
                resultado.error.mostrarUsuario = true;
            }
            catch (Exception ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de alumnos en el método InscribirAlumnos:" + ex.ToString());
                resultado.error.mensaje = ex.ToString();
                resultado.error.mostrarUsuario = false;
            }
            return resultado;
        }
        [Route("CursosAlumno/{idAlumno}")]
        public async Task<ActionResult<Alumno>> AlumnoCursos(int idAlumno)
        {
            Alumno resultado = new Alumno();
            try
            {
               
                Alumno alumnoValidar = await alumnosRepositorio.DameAlumno(idAlumno);

                if (alumnoValidar == null)
                    return NotFound($"Alumno no encontrado");

                resultado = await alumnosRepositorio.AlumnoCursos(idAlumno);

                if(resultado == null)
                {
                    resultado = alumnoValidar;
                }
               
                
            }
            catch (SqlException ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de alumnos en el método AlumnoCursos:" + ex.ToString());
                resultado.error.mensaje = "Error obteniendo alumnos inscritos en un curso" + ex.Message;
                resultado.error.mostrarUsuario = true;
            }
            catch (Exception ex)
            {
                resultado.error = new Error();
                log.LogError("Se produjo un error en el controlador de alumnos en el método AlumnoCurso:" + ex.ToString());
                resultado.error.mensaje = ex.ToString();
                resultado.error.mostrarUsuario = false;
            }
            return resultado;
        }
    }
}
