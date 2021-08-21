<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OtoServisSatis.WebFormUI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Girişi</title>
    <style>
        .login { width: 400px; margin: 7rem auto; padding:3rem; border:3px dashed #808080; background-color: #eee; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="login">
            <h1>Kullanıcı Girişi</h1>
            <table>
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
    </form>
</body>
</html>
