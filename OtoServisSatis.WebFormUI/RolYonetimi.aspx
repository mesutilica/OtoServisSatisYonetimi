<%@ Page Title="" Language="C#" MasterPageFile="~/OtoServisSablon.Master" AutoEventWireup="true" CodeBehind="RolYonetimi.aspx.cs" Inherits="OtoServisSatis.WebFormUI.RolYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Rol Yönetimi</h1>
    <div>
        <asp:GridView ID="dgvRoller" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="dgvRoller_SelectedIndexChanged">
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
        Rol Adı : 
        <asp:TextBox ID="txtRolAdi" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRolAdi" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <br />
    <div>
        <asp:Button ID="btnEkle" runat="server" Text="Ekle" OnClick="btnEkle_Click" />
        <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" OnClick="btnGuncelle_Click" />
        <asp:Button ID="btnSil" runat="server" Text="Sil" OnClick="btnSil_Click" ValidationGroup="sil" />
    </div>
    <asp:Label ID="lblId" runat="server" Text="0"></asp:Label>
</asp:Content>
