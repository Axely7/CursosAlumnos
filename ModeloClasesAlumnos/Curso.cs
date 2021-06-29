using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModeloClasesAlumnos
{
    public class Curso
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "* El campo nombre curso es obligatorio")]
        public string NombreCurso { get; set; }
        public List<Precio> ListaPrecios { get; set; }
        public Error error { get; set; }
    }
}
