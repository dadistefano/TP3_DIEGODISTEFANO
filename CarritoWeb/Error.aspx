﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="CarritoWeb.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- %><p><% = Session["Error" + Session.SessionID] %></p> --%>
    <asp:Label ID="Lberror" runat="server" Text="text"></asp:Label>
</asp:Content>
