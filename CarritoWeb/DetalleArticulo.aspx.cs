using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarritoWeb
{
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        public Articulo articulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaArt;
            try
            {
                listaArt = negocio.listar();
                //
                //int numeroArticulo = Convert.ToInt32(Session["NumeroArticulo" + Session.SessionID]);
                var numeroArticulo = Convert.ToInt32(Request.QueryString["idart"]);
                articulo = listaArt.Find(J => J.id == numeroArticulo);


            }
            catch (Exception ex)
            {
                Session.Add(Session.SessionID + "error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }
    }
}