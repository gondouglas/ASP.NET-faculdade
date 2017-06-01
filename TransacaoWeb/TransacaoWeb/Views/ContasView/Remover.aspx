<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Remover.aspx.cs" Inherits="TransacaoWeb.Views.ContasView.Remover" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Remover conta</h1>
    <asp:Label ID="lbl_agencia" runat="server" Text="Número da agencia:"></asp:Label>
    <asp:TextBox ID="txt_agencia" runat="server"></asp:TextBox>
    <asp:Label ID="lbl_numero" runat="server" Text="Número da conta:"></asp:Label>
    <asp:TextBox ID="txt_numero" runat="server"></asp:TextBox>
    <asp:Button ID="btn_remover" runat="server" Text="Remover conta" OnClick="btn_remover_Click" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="btn_limpar" runat="server" Text="Limpar banco de contas" OnClick="btn_limpar_Click" />
</asp:Content>
