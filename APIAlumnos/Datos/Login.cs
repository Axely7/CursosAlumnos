using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//En caso de que existe diferentes putos de origen de datos (Mysql, xml, etc) use this!

namespace APIAlumnos.Datos
{
    public class Login
    {
        public string Usuario { get; set; }
        public string Password { get; set; }

    }
}
