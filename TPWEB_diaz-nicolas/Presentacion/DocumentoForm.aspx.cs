﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
namespace Presentacion
{
    public partial class DocumentoForm : System.Web.UI.Page
    {
        private List<Cliente> listaCliente { get; set; }
        private Cliente Cliente { get; set; }

        private Cliente encontrarCliente(string dni, List<Cliente> listadoCliente)
        {
            Cliente cliente = null;
            foreach (Cliente clienteAux in listadoCliente)
            {
                if(dni == clienteAux.Dni.ToString())
                {
                    cliente = clienteAux;
                    break;
                }
            }
            return cliente;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                listaCliente= clienteNegocio.listarClientes();

                Session["clientes"] = listaCliente;



            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text;
            List<Cliente> listadoDeClientes = (List<Cliente>)Session["clientes"];
            Cliente = encontrarCliente(documento, listadoDeClientes);

            if(Cliente != null)
            {
                Session["cliente"] = Cliente;
                Response.Redirect("Registro.aspx", false);

            }
            else
            {
                Response.Redirect("Registro.aspx", false);
            }

        }
    }
}