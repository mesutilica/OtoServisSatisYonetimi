<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="OtoServisSatis.WebFormUI.Menu" %>

<ul id="menu">
    <li>
        <a href="/AnaMenu.aspx">Ana Menu</a>
    </li>
    <li>
        <a href="/AracYonetimi.aspx">Araç Yönetimi</a>
    </li>
    <li>
        <a href="/KullaniciYonetimi.aspx">Kullanıcı Yönetimi</a>
    </li>
    <li>
        <a href="/MarkaYonetimi.aspx">Marka Yönetimi</a>
    </li>
    <li>
        <a href="/MusteriYonetimi.aspx">Müşteri Yönetimi</a>
    </li>
    <li>
        <a href="/RolYonetimi.aspx">Rol Yönetimi</a>
    </li>
    <li>
        <a href="/SatisYonetimi.aspx">Satış Yönetimi</a>
    </li>
    <li>
        <a href="/ServisYonetimi.aspx">Servis Yönetimi</a>
    </li>
    <li>
        <asp:LinkButton ID="lbCikis" runat="server" OnClick="lbCikis_Click" ValidationGroup="cikis">Çıkış</asp:LinkButton>
    </li>
</ul>
