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
                if (!IsPostBack)
                {
                    var carritoArt = (CarritoWebArticulos)Session[Session.SessionID + "carrito"];
                    if (CarritoTieneArticulos(carritoArt))
                    {
                        CargarListaCarrito(carritoArt);
                    }
                    else
                    {
                        MostrarMensaje("No hay artículos en el carrito");
                    }
                }
            }
            catch (Exception ex)
            {
                Session.Add(Session.SessionID + "error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

        private void MostrarMensaje(string mensaje)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.Visible = true;
        }

        private bool CarritoTieneArticulos(CarritoWebArticulos carritoArt)
        {
            return (carritoArt != null && carritoArt.listadoCarritoWeb.Count != 0);
        }

        private void CargarListaCarrito(CarritoWebArticulos carritoArt)
        {
            carritoRep.DataSource = carritoArt.listadoCarritoWeb;
            carritoRep.DataBind();
        }

        protected void BtnQuitar_Click(object sender, EventArgs e)
        {
            var carritoArt = (CarritoWebArticulos)Session[Session.SessionID + "carrito"];
            int artQuitar = int.Parse(((Button)sender).CommandArgument);
            int indexArticulo = carritoArt.listadoCarritoWeb.FindIndex(J => J.id == artQuitar);
            carritoArt.listadoCarritoWeb.RemoveAt(indexArticulo);
            Session[Session.SessionID + "carrito"] = carritoArt;

            if (!CarritoTieneArticulos(carritoArt))
                MostrarMensaje("No hay artículos en el carrito");

            CargarListaCarrito(carritoArt);
        }
    }
    
}