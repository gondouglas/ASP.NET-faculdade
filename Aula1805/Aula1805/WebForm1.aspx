<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Aula1805.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Calculadora</h1>
    <table>
        <tr>
            <td>
                <asp:Label ID="lbl_valor1" runat="server" Text="Valor 1:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_valor1" runat="server"  Width="60"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl_valor2" runat="server" Text="Valor 2:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_valor2" runat="server"  Width="60"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl_resultado" runat="server" Text="Resultado:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_resultado" runat="server"  Width="60"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btn_sum" runat="server" Text="+" OnClick="btn_sum_Click"/>            
                <asp:Button ID="btn_equals" runat="server" Text="=" OnClick="btn_equals_Click"/>
            </td>
        </tr>


    </table>
</asp:Content>
