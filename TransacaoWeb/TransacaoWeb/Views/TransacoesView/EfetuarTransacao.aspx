<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EfetuarTransacao.aspx.cs" Inherits="TransacaoWeb.Views.TransacoesView.EfetuarTransacao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Efetuar transação</h1>

    <h2>Origem</h2>
    <table>
        <tr>

            <td>
                <asp:Label ID="lbl_numeroCartao" runat="server" Text="Número do cartão"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_numeroCartao" runat="server"></asp:TextBox>

            </td>
            <td>
                <asp:Label ID="lbl_cod" runat="server" Text="Código do cartão"></asp:Label>

            </td>
            <td>
                <asp:TextBox ID="txt_cod" runat="server"></asp:TextBox>

            </td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl_valor" runat="server" Text="Valor:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_valor" runat="server"></asp:TextBox>
            </td>
        </tr>

    </table>
    <h2>Destino</h2>
    <asp:Label ID="lbl_agencia" runat="server" Text="Agencia: "></asp:Label>
    <asp:TextBox ID="txt_agencia" runat="server"></asp:TextBox>
    <asp:Label ID="lbl_numero" runat="server" Text="Número: "></asp:Label>
    <asp:TextBox ID="txt_numero" runat="server"></asp:TextBox>
    <asp:Button ID="btn_efetuar" runat="server" Text="Realizar transação" OnClick="btn_efetuar_Click" />



    <br />
    <br />

    <div id="msg" runat="server" class="alert alert-warning alert-dismissible" role="alert" visible="false">
        <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
    </div>

</asp:Content>
