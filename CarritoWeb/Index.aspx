<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CarritoWeb.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Label runat="server" Text="ARTICULOS DEL CARRITOWEB" Font-Size="Small" Font-Bold="True"></asp:Label>

        <%--<div class="card-columns" style="margin-left: 5px; margin-right: 5px;">--%>
        <asp:DropDownList ID="ddlCategorias" runat="server" OnSelectedIndexChanged="ddlCategorias_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            <%--<div class="row">--%>
                <div class="card-group">
                    <asp:Repeater runat="server" ID="articulosRep">
                        <ItemTemplate>
                            <div class="card">
                                <img src="<%#Eval("imagenUrl") %>" class="card-img-top">
                                <div class="card-body">
                                    <h5 class="card-title"><%#Eval("nombre")%></h5>
                                    <p class="card-text"><%#Eval("marca.descripcion")%></p>
                                    <p class="card-text"><%#Eval("descripcion")%></p>
                                    <p class="card-text">$<%#Eval("precio")%></p>
                                    <asp:Button ID="btnComprar" CssClass="btn btn-primary" Text="Comprar" CommandArgument='<%#Eval("id")%>' CommandName="articuloCompra" runat="server" OnClick="btnComprar_Click" />
                                    <a href="DetalleArticulo.aspx?idart=<%#Eval("id")%>" CssClass="btn btn-primary" >Detalle</a>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>
        

<%--    <%-- foreach funciona pero no pasa por valor el articulo

        <% foreach (var item in listaArticulo)
            { %>
        <div class="card" style="width: 18rem;">
            <img src="<% = item.imagenUrl %>" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title"><% = item.nombre %></h5>
                <p class="card-text"><% = item.descripcion %></p>
                <a href="DetalleArticulo.aspx?idart=<% = item.id.ToString() %>" class="btn btn-primary">Detalle</a>
                <<a href="Carrito.aspx?idart=<% = item.id.ToString() %>" class="btn btn-primary">Comprar</a>
                <asp:Button ID="btnComprar" runat="server" CommandArgument="<% = art.id.ToString() %>" Text="Comprar" class="btn btn-primary" OnClick="btnComprar_Click" />
                
            </div>
        </div>
         <% } %>

    </div>--%>

    

</asp:Content>
