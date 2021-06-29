using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using APIAlumnos.Datos;
using ModeloClasesAlumnos;

namespace APIAlumnos.Repositorio
{
    public class RepositorioAlumnos : IRepositorioAlumnos
    {
        private string CadenaConexion;

        public RepositorioAlumnos(AccesoDatos cadenaConexion)
        {
            CadenaConexion = cadenaConexion.CadenaConexionSQL;
        }

        private SqlConnection conexion()
        {
            return new SqlConnection(CadenaConexion);
        }

        public async Task<Alumno> AltaAlumno(Alumno alumno)
        {
            Alumno alumnoCreado = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.UsuarioAltaAlumno";
                Comm.CommandType = CommandType.StoredProcedure;   //Procedimiento almacenado
                Comm.Parameters.Add("@Nombre", SqlDbType.VarChar, 500).Value = alumno.Nombre;
                Comm.Parameters.Add("@Email", SqlDbType.VarChar, 500).Value = alumno.Email;
                Comm.Parameters.Add("@Foto", SqlDbType.VarChar, 500).Value = alumno.Foto;
                Comm.Parameters.Add("@FechaAlta", SqlDbType.DateTime).Value = alumno.FechaAlta;
                reader = await Comm.ExecuteReaderAsync();
                if (reader.Read())
                {
                    alumnoCreado = await DameAlumno(Convert.ToInt32(reader["idalumno"]));

                }

            }
         
            finally
            {
                if (reader != null)
                    reader.Close();

                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return alumnoCreado;

        }

       
        public async Task<Alumno> DameAlumno(int id)
        {
            Alumno alumno = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.UsuarioDameAlumnos";
                Comm.CommandType = CommandType.StoredProcedure;   //Procedimiento almacenado
                Comm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                reader = await Comm.ExecuteReaderAsync();
                if (reader.Read())
                {
                    alumno = new Alumno();
                    alumno.Id = Convert.ToInt32(reader["Id"]);
                    alumno.Nombre = reader["Nombre"].ToString();
                    alumno.Email = reader["Email"].ToString();
                    alumno.Foto = reader["Foto"].ToString();
                    alumno.FechaAlta = Convert.ToDateTime(reader["FechaAlta"].ToString());
                    if (reader["FechaBaja"] != System.DBNull.Value)
                        alumno.FechaBaja = Convert.ToDateTime(reader["FechaBaja"].ToString());

       
                }

            }
           
            finally
            {
                if (reader != null)
                    reader.Close();
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return alumno;
        }

        public async Task<Alumno> DameAlumno(string email)
        {
            Alumno alumno = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.UsuarioDameAlumnos";
                Comm.CommandType = CommandType.StoredProcedure;   //Procedimiento almacenado
                Comm.Parameters.Add("@email", SqlDbType.VarChar, 500).Value = email;
                reader = await Comm.ExecuteReaderAsync();
                if (reader.Read())
                {
                    alumno = new Alumno();
                    alumno.Id = Convert.ToInt32(reader["Id"]);
                    alumno.Nombre = reader["Nombre"].ToString();
                    alumno.Email = reader["Email"].ToString();
                    alumno.Foto = reader["Foto"].ToString();
                    alumno.FechaAlta = Convert.ToDateTime(reader["FechaAlta"].ToString());
                    if (reader["FechaBaja"] != System.DBNull.Value)
                        alumno.FechaBaja = Convert.ToDateTime(reader["FechaBaja"].ToString());


                }

            }
         
            finally
            {
                if (reader != null)
                    reader.Close();
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return alumno;
        }


        public async Task<IEnumerable<Alumno>> DameAlumnos()
        {
            List<Alumno> lista = new List<Alumno>();
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.UsuarioDameAlumnos";
                Comm.CommandType = CommandType.StoredProcedure; //Procedimiento almacenado
                reader = await Comm.ExecuteReaderAsync();
                while (reader.Read())
                {
                    Alumno alu = new Alumno();
                    alu.Id = Convert.ToInt32(reader["Id"]);
                    alu.Nombre = reader["Nombre"].ToString();
                    alu.Email = reader["Email"].ToString();
                    alu.Foto = reader["Foto"].ToString();
                    alu.FechaAlta = Convert.ToDateTime(reader["FechaAlta"].ToString());
                    if (reader["FechaBaja"] != System.DBNull.Value)
                        alu.FechaBaja = Convert.ToDateTime(reader["FechaBaja"].ToString());

                    lista.Add(alu);
                }
                
            }
        
            finally
            {
                if(reader != null)
                    reader.Close();
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return lista;
        }

        public async Task<Alumno> ModificarAlumno(Alumno alumno)
        {
            Alumno alumnoModificado = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.UsuarioAltaAlumno";
                Comm.CommandType = CommandType.StoredProcedure;   //Procedimiento almacenado
                Comm.Parameters.Add("@IdAlumno", SqlDbType.Int).Value = alumno.Id;
                Comm.Parameters.Add("@Nombre", SqlDbType.VarChar, 500).Value = alumno.Nombre;
                Comm.Parameters.Add("@Email", SqlDbType.VarChar, 500).Value = alumno.Email;
                Comm.Parameters.Add("@Foto", SqlDbType.VarChar, 500).Value = alumno.Foto;

                if (alumno.FechaBaja != null)
                    Comm.Parameters.Add("@FechaBaja", SqlDbType.DateTime).Value = alumno.FechaBaja;

                reader = await Comm.ExecuteReaderAsync();
                if (reader.Read())
                    alumnoModificado = await DameAlumno(Convert.ToInt32(reader["idalumno"]));

            }
         
            finally
            {
                if (reader != null)
                    reader.Close();
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return alumnoModificado;
        }

        public async Task<Alumno> BorrarAlumno(int id)
        {
            Alumno alumnoBorrado = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.UsuarioMarcarBaja";
                Comm.CommandType = CommandType.StoredProcedure;   //Procedimiento almacenado
                Comm.Parameters.Add("@IdAlumno", SqlDbType.Int).Value = id;
                reader = await Comm.ExecuteReaderAsync();
                if (reader.Read())
                {
                    alumnoBorrado = await DameAlumno(Convert.ToInt32(reader["idalumno"]));
                }

            }
         
            finally
            {
                if (reader != null)
                    reader.Close();
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return alumnoBorrado;
        }

        public async Task<IEnumerable<Alumno>> BuscarAlumnos(string texto)
        {
            List<Alumno> AlumnosEncontrados = new List<Alumno>();
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.UsuarioBuscarAlumnos";
                Comm.CommandType = CommandType.StoredProcedure; //Procedimiento almacenado
                Comm.Parameters.Add("@texto", SqlDbType.VarChar, 500).Value = texto;
                reader = await Comm.ExecuteReaderAsync();
                while (reader.Read())
                {
                    Alumno alumno = new Alumno();
                    alumno.Id = Convert.ToInt32(reader["Id"]);
                    alumno.Nombre = reader["Nombre"].ToString();
                    alumno.Email = reader["Email"].ToString();
                    alumno.Foto = reader["Foto"].ToString();
                    alumno.FechaAlta = Convert.ToDateTime(reader["FechaAlta"].ToString());
                    if (reader["FechaBaja"] != System.DBNull.Value)
                        alumno.FechaBaja = Convert.ToDateTime(reader["FechaBaja"].ToString());

                    AlumnosEncontrados.Add(alumno);
                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Error buscando los datos de nuestro alumno " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return AlumnosEncontrados;
        }

        public async Task<Alumno> InscribirAlumnoCurso(Alumno Alumno, int idCurso, int idprecio)
        {
            Alumno alumnoInscrito = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;

            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.UsuarioInscribirCurso";
                Comm.CommandType = CommandType.StoredProcedure;
                Comm.Parameters.Add("@idAlumno", SqlDbType.Int).Value = Alumno.Id;
                Comm.Parameters.Add("@idCurso", SqlDbType.VarChar, 500).Value = idCurso;
                Comm.Parameters.Add("@idprecio", SqlDbType.Int).Value = idprecio;

                await Comm.ExecuteNonQueryAsync();

                alumnoInscrito = await DameAlumno(Alumno.Id);

            }
         
            finally
            {
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }

            return alumnoInscrito;
        }

        public async Task<Alumno> AlumnoCursos(int idAlumno)
        {
            Alumno alumno = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;
            int idCursoAux = -1;
            Curso c = null;

            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.UsuarioInscritoCursos";
                Comm.CommandType = CommandType.StoredProcedure;
                Comm.Parameters.Add("@idAlumno", SqlDbType.Int).Value = idAlumno;
                reader = await Comm.ExecuteReaderAsync();
                while (reader.Read())
                {
                    if(alumno == null)
                    {
                        alumno = new Alumno();
                        alumno.Id = Convert.ToInt32(reader["id"]);
                        alumno.Nombre = reader["Nombre"].ToString();
                        alumno.Email = reader["Email"].ToString();
                        alumno.Foto = reader["Foto"].ToString();
                        alumno.ListaCursos = new List<Curso>();
                    }

                    if(idCursoAux == -1 || idCursoAux != Convert.ToInt32(reader["idcurso"]))
                    {
                        if (c != null)
                            alumno.ListaCursos.Add(c);
                        c = new Curso();
                        c.Id = Convert.ToInt32(reader["idcurso"]);
                        c.NombreCurso = reader["NombreCurso"].ToString();
                        c.ListaPrecios = new List<Precio>();
                    }

                    Precio p = new Precio();
                    p.Coste = Convert.ToDouble(reader["Coste"]);
                    p.FechaInicio = Convert.ToDateTime(reader["FechaInicio"]);
                    p.FechaFin = Convert.ToDateTime(reader["FechaFin"]);
                    c.ListaPrecios.Add(p);

                    idCursoAux = Convert.ToInt32(reader["idCurso"]);

                }

                if (c != null)
                    alumno.ListaCursos.Add(c);
            }
          
            finally
            {
                if (reader != null)
                    reader.Close();

                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();


            }
            return alumno;
        }

    }
}
