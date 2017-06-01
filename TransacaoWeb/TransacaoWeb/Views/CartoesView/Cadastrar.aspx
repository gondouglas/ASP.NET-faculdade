<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.cs" Inherits="TransacaoWeb.Views.CartoesView.Cadastrar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Gerar cartão</h1>
    <asp:Label ID="lbl_agencia" runat="server" Text="Agencia:"></asp:Label>
    <asp:TextBox ID="txt_agencia" runat="server"></asp:TextBox>
    <asp:Label ID="lbl_numero" runat="server" Text="Numero:"></asp:Label>
    <asp:TextBox ID="txt_numero" runat="server"></asp:TextBox>
    <asp:Button ID="btn_gerar" runat="server" Text="Gerar cartão" OnClick="btn_gerar_Click"/>
</asp:Content>
