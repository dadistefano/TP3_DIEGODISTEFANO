<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListadoProducto.aspx.cs" Inherits="CarritoWeb.ListadoProducto" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Listado Articulos</h1>

        <%--<asp:GridView CssClass="table" ID="dgvArticulo" runat="server" visible="false"></asp:GridView>
       
        <div class="card-columns" style="margin-left: 10px; margin-right: 10px;">

            <% foreach (var item in listaArticulo)
            { %>
            <div class="card" style="width: 10rem;">
                <img src="<% = item.imagenUrl %>" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title"><% = item.nombre %></h5>
                    <p class="card-text"><% = item.descripcion %></p>
                    <a href="Index.aspx" class="btn btn-primary">Seleccionar</a>
                </div>
            </div>
          <% } %>
        </div> --%>

        <div class="row">
            <%-- Row tarjetas --%>
            <div class="card-columns">
                <asp:Repeater runat="server" ID="articulosRep">
                    <ItemTemplate>
                        <div class="card">
                            <img src="<%#Eval("imagenUrl") %>" class="card-img-top">
                            <div class="card-body">
                                <h5 class="card-title"><%#Eval("nombre")%></h5>
                                <p class="card-text"><%#Eval("descripcion")%></p>
                                <p class="card-text">$<%#Eval("precio")%></p>
                            </div>
                            <%-- <asp:Button ID="btnArgumento" CssClass="btn btn-primary" Text="Argumento to Back" CommandArgument='<%#Eval("Id")%>' CommandName="idPokemon" runat="server" OnClick="btnArgumento_Click" />--%>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>

</asp:Content>
<%--<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
//</asp:Content>--%>
