using AccesoDatos;
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
    public partial class Index : System.Web.UI.Page
    {
        public List<Articulo> listaArticulo { get; set; }

        public CarritoWebArticulos CarritoArt = new CarritoWebArticulos();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.listar();

                CarritoArt = (CarritoWebArticulos)Session[Session.SessionID + "carrito"];

                if (!IsPostBack)
                {
                    articulosRep.DataSource = listaArticulo;
                    articulosRep.DataBind();

                }

            }
            catch (Exception ex)
            {
                Session.Add(Session.SessionID + "error", ex.ToString());
                Response.Redirect("Error.aspx");
            }

        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                CarritoArt = (CarritoWebArticulos)Session[Session.SessionID + "carrito"];
                if (CarritoArt == null)
                    CarritoArt = new CarritoWebArticulos();

                ArticuloNegocio negocio = new ArticuloNegocio();
                int idArt = int.Parse(((Button)sender).CommandArgument);
                var articulo = negocio.BuscarArticuloXid(idArt);

                if (articulo == null)
                {
                    throw new Exception("El artículo seleccionado no está disponible");
                }

                CarritoArt.listadoCarritoWeb.Add(articulo);
                Session.Add(Session.SessionID + "carrito", CarritoArt);
            }
            catch (Exception ex)
            {
                Session.Add(Session.SessionID + "error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

        protected void BtDetalle_Click(object sender, EventArgs e)
        {
            int idArt = int.Parse(((Button)sender).CommandArgument);
            Session["DetalleArticulo" + Session.SessionID] = idArt;
            Response.Redirect("DetalleArticulo.aspx");
        }
    }
}