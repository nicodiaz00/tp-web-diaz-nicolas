using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class _Default : Page
    {
        private List<Voucher> listadoVoucher = new List<Voucher>();

        private Voucher encontrarVoucher(string codigo, List<Voucher> listado)
        {
            Voucher voucher = null;

            foreach (Voucher cupon in listado)
            {
                if (cupon.CodigoVoucher.ToString() == codigo)
                {

                    if (cupon.IdCliente != -1)
                    {
                        lblMensaje.Text = "Cupon canjeado";
                        return null;
                    }
                    voucher = cupon;
                    break;
                }
            }

            return voucher;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listadoVoucher = new List<Voucher>();
                VoucherNegocio voucherNegocio = new VoucherNegocio();
                listadoVoucher = voucherNegocio.listarVoucher();
                Session["listadoVoucher"] = listadoVoucher;   //SE GUARDA EN SESSION EL LISTADO DE CUPONES.               
            }
        }
        protected void btnCanjearCupon_Click(object sender, EventArgs e)
        {
            List<Voucher> vouchers = new List<Voucher>();
            Voucher voucher = new Voucher();

            if (Session["listadoVoucher"] != null)
            {
                vouchers = (List<Voucher>)Session["listadoVoucher"]; // RECUPERO EL LISTADO DE LA SESSION PARA PODER ENCONTRAR EL CUPON

                voucher = encontrarVoucher(txtVoucher.Text, vouchers);

                if (voucher != null)
                {
                    Session["voucher"] = voucher; // Guardo el voucher en session para recuperarlo cuando el usuario se registre y participe por el premio.
                    Response.Redirect("Articulos.aspx", true);
                }

            }
        }
    }
}