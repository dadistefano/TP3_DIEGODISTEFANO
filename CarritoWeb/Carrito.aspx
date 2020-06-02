<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="CarritoWeb.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
        <%--<div class="row">--%>
            <asp:Label runat="server" ID="lblMensaje" Visible="false"></asp:Label>
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">Articulo</th>
                        <th scope="col">Detalle</th>
                        <th scope="col">Precio</th>
                        <th scope="col"></th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater runat="server" ID="carritoRep">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("nombre")%></td>
                                <td><%#Eval("descripcion")%></td>
                                <td>$<%#Eval("precio")%></td>
                                <td>
                                    <asp:Button ID="btnQuitar" CssClass="btn btn-primary" Text="Quitar" CommandArgument='<%#Eval("id")%>' CommandName="artAEliminar" runat="server" OnClick="BtnQuitar_Click" />
                                </td>
                            </tr>
                           
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        <%--</div>--%>
    
        <h2>Debe Abonar: $<% = totalCarrito %></h2>
    </div>




    
</asp:Content>
