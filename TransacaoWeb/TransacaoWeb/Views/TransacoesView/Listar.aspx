<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="TransacaoWeb.Views.TransacoesView.Listar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Listar transações</h1>
    <asp:GridView ID="gvTransacoes" runat="server"></asp:GridView>
</asp:Content>
