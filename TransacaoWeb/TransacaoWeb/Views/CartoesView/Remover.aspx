<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Remover.aspx.cs" Inherits="TransacaoWeb.Views.CartoesView.Remover" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Remover cartão</h1>
    <asp:Label ID="lbl_numero_cartao" runat="server" Text="Numero do cartão:"></asp:Label>
    <asp:TextBox ID="txt_numero_cartao" runat="server"></asp:TextBox>
    <asp:Label ID="lbl_cod_cartao" runat="server" Text="Código de seg:"></asp:Label>
    <asp:TextBox ID="txt_cod_cartao" runat="server"></asp:TextBox>
    <asp:Button ID="btn_remover" runat="server" Text="Remover cartão" OnClick="btn_remover_Click" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="btn_limpar" runat="server" Text="Limpar banco de cartões" OnClick="btn_limpar_Click" />
</asp:Content>
