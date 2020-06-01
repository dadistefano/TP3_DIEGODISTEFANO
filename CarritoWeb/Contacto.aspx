<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="CarritoWeb.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <form>
            <div class="form-group">
                <label for="exampleFormControlInput1">Nombre y Apellido</label>
                <input type="email" class="form-control" id="exampleFormControlInput1" placeholder="Pepe Juan">
                <label for="exampleFormControlInput1">Correo Electronica</label>
                <input type="email" class="form-control" id="exampleFormControlInput1" placeholder="nombre@example.com">
            </div>
            <div class="form-group">
                <label for="exampleFormControlTextarea1">Mensaje</label>
                <textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
            </div>
             <asp:Button ID="btnEnviar" CssClass="btn btn-primary" Text="Enviar" runat="server" OnClientClick="btnEnviar_Click" OnClick="btnEnviar_Click" />
        </form>
    </div>
</asp:Content>
