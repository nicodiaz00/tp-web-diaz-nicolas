using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
	public partial class Registro : System.Web.UI.Page
	{
        public Articulo Articulo { get; set; }
		public Cliente Cliente { get; set; }
        public Voucher voucher { get; set; }
        private DateTime DateTime { get; set; }
        protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
				if (Session["articulo"] != null)
				{
                    Articulo = (Articulo)Session["articulo"];
                    DateTime = DateTime.Now;
                    if (Session["cliente"]!= null)
					{
                        Cliente = (Cliente)Session["cliente"];
                        txtId.Text = Cliente.Id.ToString();
                        txtDocumentoCliente.Text = Cliente.Dni.ToString();
                        txtNombre.Text = Cliente.Nombre.ToString();
                        txtApellido.Text = Cliente.Apellido.ToString();
                        txtEmail.Text = Cliente.Email.ToString();
                        txtDireccion.Text = Cliente.Direccion.ToString();
                        txtCiudad.Text = Cliente.Ciudad.ToString();
                        txtCodigoPostal.Text = Cliente.Cp.ToString();
                        txtCodigoArticulo.Text = Articulo.CodigoArticulo.ToString();
                        txtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
					}
					else
					{
                        txtCodigoArticulo.Text = Articulo.CodigoArticulo.ToString();
                        txtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    }
					
					

					
				}
			}
		}

        protected void btnParticipar_Click(object sender, EventArgs e)
        {

        }
    }
}