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
        protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
				if (Session["articulo"] != null)
				{
					Articulo = (Articulo)Session["articulo"];
					txtCodigoArticulo.Text = Articulo.CodigoArticulo.ToString();
				}
			}
		}
	}
}