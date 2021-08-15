<%@ Page Title="" Language="C#" MasterPageFile="~/OtoServisSablon.Master" AutoEventWireup="true" CodeBehind="MusteriYonetimi.aspx.cs" Inherits="OtoServisSatis.WebFormUI.MusteriYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Müşteri Yönetimi</h1>
    <div>
        <asp:GridView ID="dgvMusteriler" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="dgvMusteriler_SelectedIndexChanged">
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
    </div>
    <hr />
    <div>

        <table class="auto-style1">
            <tr>
                <td>Adı</td>
                <td>
                    <asp:TextBox ID="txtAdi" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAdi" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Soyadı</td>
                <td>
                    <asp:TextBox ID="txtSoyadi" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSoyadi" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
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
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTelefon" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Tc No</td>
                <td>
                    <asp:TextBox ID="txtTcNo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Adres</td>
                <td>
                    <asp:TextBox ID="txtAdres" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Araç</td>
                <td>
                    <asp:DropDownList ID="cbAracId" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Notlar</td>
                <td>
                    <asp:TextBox ID="txtNotlar" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblId" runat="server" Text="0"></asp:Label>
                </td>
                <td>
        <asp:Button ID="btnEkle" runat="server" Text="Ekle" OnClick="btnEkle_Click" />
        <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" OnClick="btnGuncelle_Click" />
        <asp:Button ID="btnSil" runat="server" Text="Sil" OnClick="btnSil_Click" ValidationGroup="sil" />
                </td>
            </tr>
            </table>

    </div>
</asp:Content>
