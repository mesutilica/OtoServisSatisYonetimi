<%@ Page Title="" Language="C#" MasterPageFile="~/OtoServisSablon.Master" AutoEventWireup="true" CodeBehind="KullaniciYonetimi.aspx.cs" Inherits="OtoServisSatis.WebFormUI.KullaniciYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Kullanıcı Yönetimi</h1>
    <div>    
    <asp:GridView ID="dgvKullanicilar" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="dgvKullanicilar_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>

        <br />
        <table class="auto-style1">
            <tr>
                <td>Adı</td>
                <td>
                    <asp:TextBox ID="txtAdi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Soyadı</td>
                <td>
                    <asp:TextBox ID="txtSoyadi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Telefon</td>
                <td>
                    <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
                </td>
            </tr>
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
                    <asp:TextBox ID="txtSifre" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSifre" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:CheckBox ID="cbAktif" runat="server" Text="Aktif mi?" />
                </td>
            </tr>
            <tr>
                <td>Kullanıcı Rolü</td>
                <td>
                    <asp:DropDownList ID="cbKullaniciRolu" runat="server" DataTextField="Adi" DataValueField="Id">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Eklenme Tarihi</td>
                <td>
                    <asp:Label ID="lblEklenmeTarihi" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblId" runat="server" Text="0"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btnEkle" runat="server" OnClick="btnEkle_Click" Text="Ekle" />
                    <asp:Button ID="btnGuncelle" runat="server" OnClick="btnGuncelle_Click" Text="Güncelle" />
                    <asp:Button ID="btnSil" runat="server" OnClick="btnSil_Click" Text="Sil" ValidationGroup="sil" />
                </td>
            </tr>
        </table>

        <br />

    </div>
</asp:Content>
