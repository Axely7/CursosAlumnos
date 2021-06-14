using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using APIAlumnos.Datos;
using ModeloClasesAlumnos;

namespace APIAlumnos.Repositorio
{
    public class RepositorioCursos: IRepositorioCursos
    {
        private string CadenaConexion;
        public RepositorioCursos(AccesoDatos cadenaConexion)
        {
            CadenaConexion = cadenaConexion.CadenaConexionSQL;
        }

        private SqlConnection conexion()
        {
            return new SqlConnection(CadenaConexion);
        }

        public async Task<Curso> AltaCurso(Curso curso)
        {
            Curso cursoCreado = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;
            int idCursoCreado = -1;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.CursoAltaCurso";
                Comm.CommandType = CommandType.StoredProcedure; //Procedimiento almacenado

                int cont = 0;
                while(cont < curso.ListaPrecios.Count)
                {
                    if (curso.ListaPrecios == null || curso.ListaPrecios[cont] == null ||
                        curso.ListaPrecios[cont].FechaInicio == null || curso.ListaPrecios[cont].FechaFin == null)
                        throw new Exception("Para dar de alta un curso debes enviar precio, fecha inicio y fecha de fin");

                    Comm.Parameters.Clear();
                    Comm.Parameters.Add("@Nombrecurso", SqlDbType.VarChar, 500).Value = curso.NombreCurso;
                    Comm.Parameters.Add("@Coste", SqlDbType.Float).Value = curso.ListaPrecios[cont].Coste;
                    Comm.Parameters.Add("@FechaInicio", SqlDbType.DateTime).Value = curso.ListaPrecios[cont].FechaInicio;
                    Comm.Parameters.Add("@FechaFin", SqlDbType.DateTime).Value = curso.ListaPrecios[cont].FechaFin;
                    idCursoCreado = Convert.ToInt32(await Comm.ExecuteScalarAsync());
                    cont++;
                }
                if(idCursoCreado != -1)
                {
                    cursoCreado = await DameCurso(idCursoCreado);
                }
            }
            catch(SqlException ex)
            {
                throw new Exception("Error creando curso " + ex.Message);
            }
            finally
            {
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return cursoCreado;
        }

        public async Task<IEnumerable<Curso>> DameCursos(int idAlumno)
        {
            List<Curso> listaCursos = new List<Curso>();
            Curso curso = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.CursoDameCursos";
                Comm.CommandType = CommandType.StoredProcedure; //Procedimiento almacenado
                if (idAlumno != -1)
                    Comm.Parameters.Add("@idalumno", SqlDbType.Int).Value = idAlumno;
                reader = await Comm.ExecuteReaderAsync();
                while (reader.Read())
                {
                    if(curso == null || curso.Id != Convert.ToInt32(reader["idCurso"]))
                    {
                        if (curso != null)
                            listaCursos.Add(curso);

                        curso = new Curso();
                        curso.Id = Convert.ToInt32(reader["idCurso"]);
                        curso.NombreCurso = reader["NombreCurso"].ToString();
                        curso.ListaPrecios = new List<Precio>();
                    }

                    //Añdimos los posibles precios del curso:
                    Precio aux = new Precio();
                    aux.Id = Convert.ToInt32(reader["idPrecio"]);
                    aux.Coste = Convert.ToDouble(reader["Coste"]);
                    aux.FechaInicio = Convert.ToDateTime(reader["FechaInicio"]);
                    aux.FechaFin = Convert.ToDateTime(reader["FechaFin"]);

                    curso.ListaPrecios.Add(aux);
                }

                if (curso != null)
                    listaCursos.Add(curso);

            }
            catch (SqlException ex)
            {
                throw new Exception("Error cargando los datos de nuestro curso " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return listaCursos;
        }

        public async Task<Curso> DameCurso(int id, int idprecio)
        {
            Curso curso = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.CursoDameCursos";
                Comm.CommandType = CommandType.StoredProcedure;   //Procedimiento almacenado
                Comm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                Comm.Parameters.Add("@idPrecio", SqlDbType.Int).Value = idprecio;
                reader = await Comm.ExecuteReaderAsync();
                while (reader.Read())
                {
                    if (curso == null)
                    {
                        curso = new Curso();
                        curso.Id = Convert.ToInt32(reader["idCurso"]);
                        curso.NombreCurso = reader["NombreCurso"].ToString();
                        curso.ListaPrecios = new List<Precio>();
                    }

                    //Añadimos los posibles precios del curso
                    Precio aux = new Precio();
                    aux.Id = Convert.ToInt32(reader["idPrecio"]);
                    aux.Coste = Convert.ToDouble(reader["Coste"]);
                    aux.FechaInicio = Convert.ToDateTime(reader["FechaInicio"]);
                    aux.FechaFin = Convert.ToDateTime(reader["FechaFin"]);

                    curso.ListaPrecios.Add(aux);

                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Error cargando los datos de curso " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return curso;
        }


        public async Task<Curso> DameCurso(int id)
        {
            Curso curso = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.CursoDameCursos";
                Comm.CommandType = CommandType.StoredProcedure;   //Procedimiento almacenado
                Comm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                reader = await Comm.ExecuteReaderAsync();
                while (reader.Read())
                {
                    if(curso == null)
                    {
                        curso = new Curso();
                        curso.Id = Convert.ToInt32(reader["idCurso"]);
                        curso.NombreCurso = reader["NombreCurso"].ToString();
                        curso.ListaPrecios = new List<Precio>();
                    }

                    //Añadimos los posibles precios del curso
                    Precio aux = new Precio();
                    aux.Id = Convert.ToInt32(reader["idPrecio"]);
                    aux.Coste = Convert.ToDouble(reader["Coste"]);
                    aux.FechaInicio = Convert.ToDateTime(reader["FechaInicio"]);
                    aux.FechaFin = Convert.ToDateTime(reader["FechaFin"]);

                    curso.ListaPrecios.Add(aux);
                    
                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Error cargando los datos de curso " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return curso;
        }

        public async Task<Curso> DameCurso(string nombreCurso)
        {
            Curso curso = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;

            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.CursoDameCursos";
                Comm.CommandType = CommandType.StoredProcedure;   //Procedimiento almacenado
                Comm.Parameters.Add("@NombreCurso", SqlDbType.VarChar, 500).Value = nombreCurso;
                reader = await Comm.ExecuteReaderAsync();
                while (reader.Read())
                {
                    if(curso == null)
                    {
                        curso = new Curso();
                        curso.Id = Convert.ToInt32(reader["idCurso"]);
                        curso.NombreCurso = reader["NombreCurso"].ToString();
                        curso.ListaPrecios = new List<Precio>();
                    }
                    //Añdimos los posibles precios del curso:}
                    Precio aux = new Precio();
                    aux.Id = Convert.ToInt32(reader["idPrecio"]);
                    aux.Coste = Convert.ToDouble(reader["Coste"]);
                    aux.FechaInicio = Convert.ToDateTime(reader["FechaInicio"]);
                    aux.FechaFin = Convert.ToDateTime(reader["FechaFin"]);

                    curso.ListaPrecios.Add(aux);
                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Error cargando los datos de curso " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return curso;
        }

        public async Task<Curso> ModificarCursos(Curso curso)
        {
            Curso cursoModificado = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;
            try
            {
                sqlConexion.Open();
                int cont = 0;
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.CursoModificarCurso";
                Comm.CommandType = CommandType.StoredProcedure;   //Procedimiento almacenado

                while (cont < curso.ListaPrecios.Count)
                {
                    Comm.Parameters.Clear();
                    Comm.Parameters.Add("@idCurso", SqlDbType.Int).Value = curso.Id;
                    Comm.Parameters.Add("@idPrecio", SqlDbType.Int).Value = curso.ListaPrecios[cont].Id;
                    Comm.Parameters.Add("@NombreCurso", SqlDbType.VarChar, 500).Value = curso.NombreCurso;
                    Comm.Parameters.Add("@Coste", SqlDbType.Float).Value = curso.ListaPrecios[cont].Coste;
                    Comm.Parameters.Add("@FechaInicio", SqlDbType.DateTime).Value = curso.ListaPrecios[cont].FechaInicio;
                    Comm.Parameters.Add("@FechaFin", SqlDbType.DateTime).Value = curso.ListaPrecios[cont].FechaFin;
                    await Comm.ExecuteNonQueryAsync();
                    cont++;
                }
                cursoModificado = await DameCurso(curso.Id);
            }
            catch(SqlException ex)
            {
                throw new Exception("Error modificando curso" + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return cursoModificado;
        }

        public async Task<Curso> BorrarCurso(int id)
        {
            Curso cursoBorrado = null;
            SqlConnection sqlConexion = conexion();
            SqlCommand Comm = null;
            SqlDataReader reader = null;
            try
            {
                sqlConexion.Open();
                Comm = sqlConexion.CreateCommand();
                Comm.CommandText = "dbo.CursoBorrarCurso";
                Comm.CommandType = CommandType.StoredProcedure;   //Procedimiento almacenado
                Comm.Parameters.Add("@IdCurso", SqlDbType.Int).Value = id;
                cursoBorrado = await DameCurso(id);
                await Comm.ExecuteReaderAsync();

            }
            catch (SqlException ex)
            {
                throw new Exception("Error borrando el curso " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                Comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return cursoBorrado;
        }

    }
}
