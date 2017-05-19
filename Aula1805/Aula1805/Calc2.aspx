<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calc2.aspx.cs" Inherits="Aula1805.Calc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Resultados</h1>

    <table>
                <tr>
            <td>
                <asp:Label ID="title1" runat="server" Text="Valor 1"></asp:Label>
            </td>
            <td>
            </td>
            <td>
                <asp:Label ID="title2" runat="server" Text="Valor 2"></asp:Label>
            </td>
            <td>
            </td>
            <td>
                <asp:Label ID="title3" runat="server" Text="Resultado"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txt_sumvalor1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lbl_sumsign" runat="server" Text="+"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_sumvalor2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lbl_sumequals" runat="server" Text="="></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_sumresult" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txt_subvalor1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lbl_subsign" runat="server" Text="-"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_subvalor2" runat="server" ></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lbl_subequals" runat="server" Text="="></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_subresult" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txt_mulvalor1" runat="server" ></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lbl_mulsign" runat="server" Text="*"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_mulvalor2" runat="server" ></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lbl_mulequals" runat="server" Text="="></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_mulresult" runat="server" Width="100"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txt_divvalor1" runat="server"  Width="60"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lbl_divsign" runat="server" Text="/"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_divvalor2" runat="server"  Width="60"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lbl_divequals" runat="server" Text="="></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_divresult" runat="server"  Width="60"></asp:TextBox>
            </td>
        </tr>
    </table>
    <a href="WebForm1.aspx">Voltar</a>

    <style>
        input{
            width:60px;
        }

    </style>

</asp:Content>

