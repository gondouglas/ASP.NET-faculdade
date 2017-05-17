<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MeuPrimeiroForm.aspx.cs" Inherits="Aula1605.MeuPrimeiroForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Meu primeiro form</h1>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <div class="row">
                        <td>
                            <asp:Label ID="lbl_nome" runat="server" Text="Nome: *"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_nome" runat="server" MaxLength="50"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="rfvNome" runat="server" ControlToValidate="txt_nome" ErrorMessage="Campo nome é obrigatorio!" ></asp:RequiredFieldValidator>
                        </td>
                    </div>
                </tr>
                <tr>

                    <div class="row">
                        <td>
                            <asp:Label ID="lbl_descricao" runat="server" Text="Descrição:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_descricao" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </div>
                </tr>
                <tr>

                    <div class="row">
                        <td>
                            <asp:Label ID="lbl_ativo" runat="server" Text="Ativo:"></asp:Label>
                        </td>
                        <td>
                            <asp:CheckBox ID="chk_ativo" runat="server" />
                        </td>
                    </div>
                </tr>
                <tr>
                    <div class="row">
                        <td>
                            <asp:Button CssClass="btn btn-default" ID="btn_salvar" runat="server" Text="Salvar" OnClick="btn_salvar_Click" />
                        </td>
                        <td>
                            <asp:Button CssClass="btn btn-default" ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" CausesValidation="false"/>
                        </td>
                    </div>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
