<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.cs" Inherits="TransacaoWeb.Views.ContasView.Cadastrar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>Gerar conta</h1>

    <asp:Label ID="lbl_saldo" runat="server" Text="Saldo inicial: "></asp:Label>
    <asp:TextBox ID="txt_saldo" runat="server"></asp:TextBox>
    <asp:Button ID="btn_gerar" runat="server" Text="Gerar conta" OnClick="btn_gerar_Click"/>

</asp:Content>
