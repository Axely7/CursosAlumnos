using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModeloClasesAlumnos
{
    public class Alumno
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="* El campo nombre es obligatorio")]
        public string Nombre { get; set; } 
        [Required(ErrorMessage ="* El campo Email es obligatorio")]
        [EmailAddress(ErrorMessage ="* Formato de email incorrecto")]
        public string Email { get; set; }
        [Required(ErrorMessage ="* El campo foto es obligatorio")]
        public string Foto { get; set; }
        public List<Curso> ListaCursos { get; set; }
        [Required(ErrorMessage ="* El campo fechAlta es obligatorio")]
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }  // ? = Permite null
        public Error error { get; set; }

    }
}
