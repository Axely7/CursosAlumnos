using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//En caso de que existe diferentes putos de origen de datos (Mysql, xml, etc) use this!

namespace APIAlumnos.Datos
{
    public class AccesoDatos
    {
        private string cadenaConexionSql;
        public string CadenaConexionSQL { get => cadenaConexionSql; }
        public AccesoDatos(string ConexionSql)
        {
            cadenaConexionSql = ConexionSql;
        }
    }
}
