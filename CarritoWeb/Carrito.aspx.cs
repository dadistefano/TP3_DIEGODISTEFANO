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
        public double totalCarrito = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                if (!IsPostBack)
                {
                    var carritoArt = (CarritoWebArticulos)Session[Session.SessionID + "carrito"];
                    if (CarritoTieneArticulos(carritoArt))
                    {
                        CargarListaCarrito(carritoArt);
                        totalCarrito = sumarArticulo(carritoArt);
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

        private double sumarArticulo(CarritoWebArticulos carritoArt)
        {
            foreach(var sumaArt in carritoArt.listadoCarritoWeb)
            {
                totalCarrito += sumaArt.precio;
                
            }
            return totalCarrito;

            throw new NotImplementedException();
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