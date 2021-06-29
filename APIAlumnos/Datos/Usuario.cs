using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//En caso de que existe diferentes putos de origen de datos (Mysql, xml, etc) use this!

namespace APIAlumnos.Datos
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }

    }
}
