<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListadoProducto.aspx.cs" Inherits="CarritoWeb.ListadoProducto" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <h1>Listado Articulos</h1>

        <asp:GridView CssClass="table" ID="dgvArticulo" runat="server"></asp:GridView>
            </div>
</asp:Content>

<%--<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
//</asp:Content>--%>
