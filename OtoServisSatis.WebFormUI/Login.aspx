<%@ Page Title="" Language="C#" MasterPageFile="~/OtoServisSablon.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OtoServisSatis.WebFormUI.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Kullanıcı Girişi</h1>
    <div>

        <table class="auto-style1">
            <tr>
                <td>Kullanıcı Adı</td>
                <td>
                    <asp:TextBox ID="txtKullaniciAdi" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtKullaniciAdi" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Şifre</td>
                <td>
                    <asp:TextBox ID="txtSifre" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSifre" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnGiris" runat="server" OnClick="btnGiris_Click" Text="Giriş" />
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
