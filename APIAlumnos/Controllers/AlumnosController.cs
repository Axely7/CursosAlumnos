using Microsoft.AspNetCore.Mvc;
using APIAlumnos.Repositorio;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModeloClasesAlumnos;
using Microsoft.Extensions.Logging;

namespace APIAlumnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        public async Task<ActionResult> DameAlumnos()
        {
            try
            {
                return Ok(await alumnosRepositorio.DameAlumnos());
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de alumnos en el método DameAlumnos:" + ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error obteniendo los datos");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Alumno>> DameAlumno(int id)
        {
            try
            {
                var resultado = await alumnosRepositorio.DameAlumno(id);
                if (resultado == null)
                    return NotFound();
                return resultado;
                
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de alumnos en el método DameAlumnos:" + ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error obteniendo los datos");
            }
        }

        [HttpPost]

        public async Task<ActionResult<Alumno>> CrearAlumno(Alumno alumno)
        {
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


                var nuevoAlumno = await alumnosRepositorio.AltaAlumno(alumno);
                return nuevoAlumno;
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de alumnos en el método CrearAlumnos:" + ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error dando de alta nuevo alumno");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Alumno>> ModificarAlumno(int id, Alumno alumno)
        {
            try
            {
                if (id != alumno.Id)
                    return BadRequest("Alumno Id no coincide");

                var alumnoModificar = await alumnosRepositorio.DameAlumno(id);

                if (alumnoModificar == null)
                    return NotFound($"Alumno con = {id} no encontrado");

                return await alumnosRepositorio.ModificarAlumno(alumno);
                
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de alumnos en el método ModificarAlumnos:" + ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error actualizando datos");
            }
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
            catch(Exception ex)
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
            try
            {
                var alumnoValidar = await alumnosRepositorio.DameAlumno(alumno.Id);

                if (alumnoValidar == null)
                    return NotFound($"Alumno no encontrado");

                return await alumnosRepositorio.InscribirAlumnoCurso(alumno, idCurso, idprecio);
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de alumnos en el método InscribirAlumnos:" + ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error inscribiendo alumno en curso");
            }
        }
        [Route("CursosAlumno/{idAlumno}")]
        public async Task<ActionResult<Alumno>> AlumnoCursos(int idAlumno)
        {
            try
            {
                Alumno AlumnoRespuesta = null;
                Alumno alumnoValidar = await alumnosRepositorio.DameAlumno(idAlumno);

                if (alumnoValidar == null)
                    return NotFound($"Alumno no encontrado");

                AlumnoRespuesta = await alumnosRepositorio.AlumnoCursos(idAlumno);

                if(AlumnoRespuesta == null)
                {
                    AlumnoRespuesta = alumnoValidar;
                }
                return AlumnoRespuesta;
                
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error en el controlador de alumnos en el método AlumnoCurso:" + ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error obteniendo cursos alumno");
            }
        }
    }
}
