using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteNegocio
    {
        public List<Cliente> listarClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("Select Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP from Clientes");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = (int)accesoDatos.Lector["Id"];
                    cliente.Dni = (string)accesoDatos.Lector["Documento"];
                    cliente.Nombre = (string)accesoDatos.Lector["Nombre"];
                    cliente.Apellido = (string)accesoDatos.Lector["Apellido"];
                    cliente.Email = (string)accesoDatos.Lector["Email"];
                    cliente.Direccion = (string)accesoDatos.Lector["Direccion"];
                    cliente.Ciudad = (string)accesoDatos.Lector["Ciudad"];
                    cliente.Cp = (int)accesoDatos.Lector["CP"];

                    listaClientes.Add(cliente);
                }
                return listaClientes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}

