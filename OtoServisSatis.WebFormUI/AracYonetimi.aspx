<%@ Page Title="Araç Yönetimi" Language="C#" MasterPageFile="~/OtoServisSablon.Master" AutoEventWireup="true" CodeBehind="AracYonetimi.aspx.cs" Inherits="OtoServisSatis.WebFormUI.AracYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        
        .auto-style1 {
            width: 100%;
        }
        
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:GridView ID="gvAraclar" runat="server" OnSelectedIndexChanged="gvAraclar_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>

    <hr />

    <h1>Araç Bilgileri</h1>
    <table class="auto-style1">
        <tr>
            <td>Marka</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
            <td>Model Yılı</td>
            <td>
                <asp:TextBox ID="txtModelYili" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Renk</td>
            <td>
                <asp:TextBox ID="txtRenk" runat="server"></asp:TextBox>
            </td>
            <td>Notlar</td>
            <td>
                <asp:TextBox ID="txtNotlar" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Fiyatı</td>
            <td>
                <asp:TextBox ID="txtFiyati" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Modeli</td>
            <td>
                <asp:TextBox ID="txtModeli" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Kasa Tipi</td>
            <td>
                <asp:TextBox ID="txtKasaTipi" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnEkle" runat="server" OnClick="btnEkle_Click" Text="Ekle" />
                <asp:Button ID="btnGuncelle" runat="server" OnClick="btnGuncelle_Click" Text="Güncelle" />
                <asp:Button ID="btnSil" runat="server" OnClick="btnSil_Click" Text="Sil" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    
</asp:Content>
