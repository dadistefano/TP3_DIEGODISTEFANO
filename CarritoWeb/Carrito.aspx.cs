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
    public partial class Carrito : System.Web.UI.Page
    {
        //public List<Articulo> listaCarrito { get; set; } //Del Foreach
        public CarritoWebArticulos carritoArt = new CarritoWebArticulos();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //1ra OPCION con el FORARCH que no FUNCIONO!!!
                //listaCarrito = (List<Articulo>)Session[Session.SessionID + "listaCarrito"];

                //var ArtQuitar = Request.QueryString["idQuitar"];
                //if (ArtQuitar != null)
                //{
                //    Articulo articuloQuitar = listaCarrito.Find(J => J.id == int.Parse(ArtQuitar));
                //    listaCarrito.Remove(articuloQuitar);
                //  Session[Session.SessionID + "listaCarrito"] = listaCarrito;
                //}
                //else if (Request.QueryString["idart"] != null)
                //{
                //    //obtengo lista original (el listado completo)
                //   List<Articulo> listaOriginal = (List<Articulo>)Session[Session.SessionID + "listaCarrito"];
                //   var ArtSeleccionado = Convert.ToInt32(Request.QueryString["idart"]);
                //    var prueba = (List<Articulo>)Session["listaCarrito"];
                //    Articulo articulo = listaOriginal.Find(J => J.id == ArtSeleccionado); //me tira error aca!!

                //    //obtengo la lista de favoritos de la session
                //    if (listaCarrito == null)
                //       listaCarrito = new List<Articulo>();

                //   listaCarrito.Add(articulo);
                //   Session[Session.SessionID + "listaCarrito"] = listaCarrito;
                //}

                carritoArt = (CarritoWebArticulos)Session[Session.SessionID + "carrito"];
                if (carritoArt == null)
                {
                    lblMensaje.Text = "No hay artículos en el carrito";
                    lblMensaje.Visible = true;
                }
                else
                {
                    carritoRep.DataSource = carritoArt.listadoCarritoWeb;
                    carritoRep.DataBind();
                }

            }
            catch (Exception ex)
            {
                Session.Add(Session.SessionID + "error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

        protected void BtnQuitar_Click(object sender, EventArgs e)
        {

            int ArtQuitar = int.Parse(((Button)sender).CommandArgument);
            int Vuelta = carritoArt.listadoCarritoWeb.FindIndex(J => J.id == ArtQuitar);
            carritoArt.listadoCarritoWeb.RemoveAt(carritoArt.listadoCarritoWeb.FindIndex(J => J.id == ArtQuitar));
            Session[Session.SessionID + "carrito"] = carritoArt;
        }
    }
    
}