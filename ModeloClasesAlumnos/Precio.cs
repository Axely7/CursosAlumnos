using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModeloClasesAlumnos
{
    public class Precio
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "* El campo Coste es obligatorio")]
        public double Coste { get; set; }
        [Required(ErrorMessage ="* El campo Fecha Inicio es obligatorio")]
        public DateTime FechaInicio { get; set; }
        [Required(ErrorMessage = "* El campo fecha Fin es obligatorio")]
        public DateTime FechaFin { get; set; }

    }
}
