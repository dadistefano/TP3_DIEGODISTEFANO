<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="CarritoWeb.DetalleArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="card" style="width: 25%">
            <img src="<% = articulo.imagenUrl %>" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title"><% = articulo.nombre %></h5>
                <p class="card-text"><% = articulo.descripcion %></p>
            </div>
        </div>

</asp:Content>
