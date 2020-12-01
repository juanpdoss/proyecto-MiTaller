using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase estatica ServiciosSql.
    /// </summary>
    public static class ServiciosSql
    {
        static SqlConnection conexion;
        static SqlCommand comando;
        static SqlDataReader lector;

        /// <summary>
        /// Constructor estatico.
        /// </summary>        
        static ServiciosSql()
        {
            ServiciosSql.conexion = new SqlConnection("Data Source= localhost\\SQLEXPRESS;Initial Catalog=TP4;integrated security=true");
            ServiciosSql.comando = new SqlCommand();          
        }

        #region metodos
        /// <summary>
        /// Obtendra el ultimo id dentro de la tabla.
        /// </summary>
        /// <returns></returns>
        public static int ObtenerUltimoId()
        {
            int id = 0;
            try
            {
                string consulta = "SELECT MAX(id) FROM electrodomesticos";
                ServiciosSql.comando.Connection = ServiciosSql.conexion;
                ServiciosSql.comando.CommandType = CommandType.Text;
                ServiciosSql.comando.CommandText = consulta;

                if (ServiciosSql.conexion.State != ConnectionState.Open)
                    ServiciosSql.conexion.Open();

                ServiciosSql.lector = ServiciosSql.comando.ExecuteReader();

                while (ServiciosSql.lector.Read())
                    id = lector.GetInt32(0);

            }
            catch
            {
                if (ServiciosSql.conexion.State == ConnectionState.Open)
                    ServiciosSql.conexion.Close();
                throw new BaseDeDatosException();
            }
            finally
            {
                if (ServiciosSql.conexion.State == ConnectionState.Open)
                    ServiciosSql.conexion.Close();
            }
            return id;
        }



        /// <summary>
        /// Insertara un electrodomestico en la base datos.
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="tieneGarantia"></param>
        /// <returns></returns>
        public static bool InsertarElectrodomestico(string tipo, bool tieneGarantia)
        {
            bool pude = true;
            try
            {
                string consulta = "INSERT INTO electrodomesticos (tipo,tieneGarantia) VALUES (@tipo,@tieneGarantia)";
                ServiciosSql.comando.Connection = ServiciosSql.conexion;
                ServiciosSql.comando.CommandType = CommandType.Text;
                ServiciosSql.comando.Parameters.AddWithValue("@tipo", tipo);

                if (tieneGarantia)
                    ServiciosSql.comando.Parameters.AddWithValue("@tieneGarantia", 1);
                else
                    ServiciosSql.comando.Parameters.AddWithValue("@tieneGarantia", 0);

                ServiciosSql.comando.CommandText = consulta;

                if (ServiciosSql.conexion.State != ConnectionState.Open)
                    ServiciosSql.conexion.Open();

                int filasAfectadas = ServiciosSql.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                    pude = false;                
            }
            catch
            {
                if (ServiciosSql.conexion.State == ConnectionState.Open)
                    ServiciosSql.conexion.Close();
                throw new BaseDeDatosException();           
            }
            finally
            {
                if (ServiciosSql.conexion.State == ConnectionState.Open)
                    ServiciosSql.conexion.Close();
                ServiciosSql.comando.Parameters.Clear();
            }

            return pude;
        }
        /// <summary>
        /// Borrara un electrodomestico de la base de datos.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool BorrarElectrodomestico(int id)
        {
            bool pude = true;
            try
            {
                string consulta = "DELETE FROM electrodomesticos WHERE id=@id";
                ServiciosSql.comando.Connection = ServiciosSql.conexion;
                ServiciosSql.comando.CommandType = CommandType.Text;
                ServiciosSql.comando.Parameters.AddWithValue("@id", id);

                ServiciosSql.comando.CommandText = consulta;

                if (ServiciosSql.conexion.State != ConnectionState.Open)
                    ServiciosSql.conexion.Open();

                int filasAfectadas = ServiciosSql.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                    throw new BaseDeDatosException();
            }
            catch 
            {
                throw new BaseDeDatosException();

            }
            finally
            {
                if (ServiciosSql.conexion.State == ConnectionState.Open)
                    ServiciosSql.conexion.Close();
                ServiciosSql.comando.Parameters.Clear();
            }

            return pude;
        }



        /// <summary>
        /// Genera, a partir de la tabla de electrodomesticos, una lista.
        /// </summary>
        /// <returns></returns>
        public static List<Electrodomestico> ObtenerElectrodomesticos()
        {
            List<Electrodomestico> listaElectrodomesticos = null;

            try
            {
                listaElectrodomesticos = new List<Electrodomestico>();
                string consulta = "SELECT * FROM electrodomesticos";

                ServiciosSql.comando.CommandType = CommandType.Text;
                ServiciosSql.comando.Connection = ServiciosSql.conexion;
                ServiciosSql.comando.CommandText = consulta;

                if (ServiciosSql.conexion.State != ConnectionState.Open)
                    ServiciosSql.conexion.Open();

                ServiciosSql.lector = ServiciosSql.comando.ExecuteReader();

                while (ServiciosSql.lector.Read())
                {
                    listaElectrodomesticos.Add(new Electrodomestico
                        (
                            lector.GetInt32(0),
                            int.Parse(lector.GetString(1)),
                            lector.GetBoolean(2)
                        )
                        );

                }
            }
            catch
            {
                if (ServiciosSql.conexion.State == ConnectionState.Open)
                    ServiciosSql.conexion.Close();
                
                throw new BaseDeDatosException();  
            }
            finally
            {
                if (ServiciosSql.conexion.State == ConnectionState.Open)
                    ServiciosSql.conexion.Close();
            }

            return listaElectrodomesticos;
        }
        #endregion


    }
}
