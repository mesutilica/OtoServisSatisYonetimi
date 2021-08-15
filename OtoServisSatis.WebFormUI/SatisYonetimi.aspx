<%@ Page Title="" Language="C#" MasterPageFile="~/OtoServisSablon.Master" AutoEventWireup="true" CodeBehind="SatisYonetimi.aspx.cs" Inherits="OtoServisSatis.WebFormUI.SatisYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Satış Yönetimi</h1>
    <div>
        <asp:GridView ID="dgvSatislar" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="dgvSatislar_SelectedIndexChanged">
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
                <td>Araç</td>
                <td>
                    <asp:DropDownList ID="cbArac" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Müşteri</td>
                <td>
                    <asp:DropDownList ID="cbMusteri" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Satış Fiyatı</td>
                <td>
                    <asp:TextBox ID="txtSatisFiyati" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Satış Tarihi</td>
                <td>
                    <asp:Calendar ID="dtpSatisTarihi" runat="server"></asp:Calendar>
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
