<%@ Page Title="" Language="C#" MasterPageFile="~/OtoServisSablon.Master" AutoEventWireup="true" CodeBehind="ServisYonetimi.aspx.cs" Inherits="OtoServisSatis.WebFormUI.ServisYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Servis Yönetimi</h1>
    <div>
        <asp:GridView ID="dgvServisler" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="dgvServisler_SelectedIndexChanged">
            <alternatingrowstyle backcolor="White" forecolor="#284775" />
            <columns>
                <asp:CommandField ShowSelectButton="True" />
            </columns>
            <editrowstyle backcolor="#999999" />
            <footerstyle backcolor="#5D7B9D" font-bold="True" forecolor="White" />
            <headerstyle backcolor="#5D7B9D" font-bold="True" forecolor="White" />
            <pagerstyle backcolor="#284775" forecolor="White" horizontalalign="Center" />
            <rowstyle backcolor="#F7F6F3" forecolor="#333333" />
            <selectedrowstyle backcolor="#E2DED6" font-bold="True" forecolor="#333333" />
            <sortedascendingcellstyle backcolor="#E9E7E2" />
            <sortedascendingheaderstyle backcolor="#506C8C" />
            <sorteddescendingcellstyle backcolor="#FFFDF8" />
            <sorteddescendingheaderstyle backcolor="#6F8DAE" />
        </asp:GridView>
    </div>
    <hr />
    <div>

        <table class="auto-style1">
            <tr>
                <td>Giriş Tarihi</td>
                <td>
                    <asp:Calendar ID="dtpServiseGelisTarihi" runat="server"></asp:Calendar>
                </td>
                <td>Çıkış Tarihi</td>
                <td>
                    <asp:Calendar ID="dtpServistenCikisTarihi" runat="server"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td>Araç Sorunu</td>
                <td>
                    <asp:TextBox ID="txtAracSorunu" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAracSorunu" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>Araç Marka</td>
                <td>
                    <asp:TextBox ID="txtMarka" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Servis Ücreti</td>
                <td>
                    <asp:TextBox ID="txtServisUcreti" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtServisUcreti" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>Araç Model</td>
                <td>
                    <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Araç Plaka</td>
                <td>
                    <asp:TextBox ID="txtAracPlaka" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAracPlaka" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>Kasa Tipi</td>
                <td>
                    <asp:TextBox ID="txtKasaTipi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:CheckBox ID="cbGaranti" runat="server" Text="Garanti Kapsamında Mı?" />
                </td>
                <td>Şase No</td>
                <td>
                    <asp:TextBox ID="txtSaseNo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Yapılan İşlemler</td>
                <td>
                    <asp:TextBox ID="txtYapilanIslemler" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtYapilanIslemler" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>Notlar</td>
                <td>
                    <asp:TextBox ID="txtNotlar" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblId" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
                <td colspan="2">
        <asp:Button ID="btnEkle" runat="server" Text="Ekle" OnClick="btnEkle_Click" />
        <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" OnClick="btnGuncelle_Click" />
        <asp:Button ID="btnSil" runat="server" Text="Sil" OnClick="btnSil_Click" ValidationGroup="sil" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
</asp:Content>
