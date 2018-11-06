<%@ Page Title="" Language="C#" MasterPageFile="~/MasterKullanici.Master" AutoEventWireup="true" CodeBehind="KullaniciDetay.aspx.cs" Inherits="KitapTavsiyeSistemi1.KullaniciDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="LblKullanici" runat="server" style="font-size: xx-large" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Image ID="Image1" runat="server" Height="136px" Width="130px" ImageUrl="~/Resimler/user-icon-360x360.jpg" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Mesaj Gönder" OnClick="Button1_Click" />
        <br />
        <table class="auto-style4">
            <tr>
                <td>İsim Soyisim</td>
                <td>
                    <asp:Label ID="Lblkullaniciad" runat="server" Text="Label"></asp:Label>
                &nbsp;
                    <asp:Label ID="LblKullaniciSoyad" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Okuduğu Kitaplar</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;Puanları</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>İncelemeleri</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Alıntıları</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
</asp:Content>
