<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="TransacaoWeb.Views.CartoesView.Listar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Cartões cadastrados</h1>
    <asp:GridView ID="gvCartoes" runat="server"></asp:GridView>
</asp:Content>
