<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Aula1105.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:Calendar ID="calDataInicio" runat="server" OnSelectionChanged="calDataInicio_SelectionChanged"></asp:Calendar>
    <br />
    <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
    <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
</asp:Content>
