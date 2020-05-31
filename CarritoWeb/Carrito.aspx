<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="CarritoWeb.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col">
                <table class="table">
                    <tr>
                        <td>Nombre</td>
                        <td>Marca</td>
                        <td>Descripcion</td>
                    </tr>
                    <%foreach (var art in listaCarrito)
                        {
                    %>

                    <tr>
                        <td><% = art.nombre %></td>
                        <td><% = art.marca.descripcion %></td>
                        <td><% = art.descripcion %></td>
                        <td><a href="Carrito.aspx?idQuitar=<% = art.id.ToString() %>" class="btn btn-primary">Eliminar</a></td>
                    </tr>


                    <% } %>
                </table>

            </div>

        </div>
    </div>
</asp:Content>
