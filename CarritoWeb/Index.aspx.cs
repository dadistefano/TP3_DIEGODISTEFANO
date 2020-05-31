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

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.listar();
                //dgvArticulo.DataSource = listaArticulo;
                //dgvArticulo.DataBind();
                //itemdata

                if (!IsPostBack)
                {

                    //articulosRep.DataSource = listaArticulo;
                    //articulosRep.DataBind();

                    //repeaterCategorias.DataSource = categorias;
                    //repeaterCategorias.DataBind();
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

            //Session(Articulo) = "";

        }

        protected void BtDetalle_Click(object sender, EventArgs e)
        {
            //int 
           // Session["DetalleProduct" + Session.SessionID] = ex;
        }
    }
}