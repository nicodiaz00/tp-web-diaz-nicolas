﻿using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Articulos : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!IsPostBack)
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                listaArticulos= articuloNegocio.listarArticulo();

                repetidorArticulos.DataSource = listaArticulos;
                repetidorArticulos.DataBind();


            }
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            //Caoturo id del articulo para llevarlo a la pantalla formulario

            int valor = int.Parse(((Button)sender).CommandArgument); // capturo id y lo paso a int

            Session["articulo"] = articuloNegocio.seleccionarArticulo(valor);

            Response.Redirect("DocumentoForm.aspx", false);








        }
    }
}