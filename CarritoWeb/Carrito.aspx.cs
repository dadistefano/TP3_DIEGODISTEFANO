using Dominio;
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
        public List<Articulo> listaCarrito { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                listaCarrito = (List<Articulo>)Session[Session.SessionID + "listaCarrito"];

                var ArtQuitar = Request.QueryString["idQuitar"];
                if (ArtQuitar != null)
                {
                    Articulo articuloQuitar = listaCarrito.Find(J => J.id == int.Parse(ArtQuitar));
                    listaCarrito.Remove(articuloQuitar);
                    Session[Session.SessionID + "listaCarrito"] = listaCarrito;
                }
                else if (Request.QueryString["idArt"] != null)
                {
                    //obtengo lista original (el listado completo)
                    List<Articulo> listaOriginal = (List<Articulo>)Session[Session.SessionID + "listaCarrito"];
                    var ArtSeleccionado = Convert.ToInt32(Request.QueryString["idArt"]);
                    Articulo articulo = listaOriginal.Find(J => J.id == ArtSeleccionado); //me tira error aca!!

                    //obtengo la lista de favoritos de la session
                    if (listaCarrito == null)
                        listaCarrito = new List<Articulo>();

                    listaCarrito.Add(articulo);
                    Session[Session.SessionID + "listaCarrito"] = listaCarrito;
                }



            }
            catch (Exception ex)
            {
                Session.Add(Session.SessionID + "error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }
    }
    
}