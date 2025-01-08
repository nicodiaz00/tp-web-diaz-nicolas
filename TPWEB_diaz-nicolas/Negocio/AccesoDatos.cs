using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AccesoDatos
    {
        private string dbConexion = "server=.\\SQLEXPRESS; database= PROMOS_DB; integrated security= true";
        private SqlConnection conexion;

        private SqlCommand comando;

        private SqlDataReader lector;
        public SqlDataReader Lector { get { return lector; } }

        public AccesoDatos()
        {
            conexion = new SqlConnection(dbConexion);
            comando = new SqlCommand();
        }
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void setearParametro(string parametro, object valor)
        {
            comando.Parameters.AddWithValue(parametro, valor);
        }
        public void cerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
                conexion.Close();
            }
        }
        public int obtenerId()
        {
            try
            {
                string consulta = "SELECT CAST(SCOPE_IDENTITY() AS INT)";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;


                return Convert.ToInt32(comando.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.ToString());
            }
        }
        public int obtenerUltimoIdCliente()
        {
            
            int ultimoId = 0;
            try
            {
                comando.Connection = conexion;
                comando.Connection.Open();
                string consulta = "SELECT IDENT_CURRENT('Clientes') AS LastInsertedId";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
                ultimoId = Convert.ToInt32(comando.ExecuteScalar());
                return ultimoId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}

