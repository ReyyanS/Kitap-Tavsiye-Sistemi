<%@ Page Title="" Language="C#" MasterPageFile="~/MasterKullanici.Master" AutoEventWireup="true" CodeBehind="KullanicilarArayuz.aspx.cs" Inherits="KitapTavsiyeSistemi1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style5 {
        font-size: large;
    }
    .auto-style6 {
        color: #669900;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <span class="auto-style6"><strong>Sizinle Aynı Kitapları Okuyan Kullanıcılar</strong></span></p>
<p>
    &nbsp;</p>
<p>
    <asp:GridView ID="GridView1" runat="server" style="color: #CC0099; font-size: x-large" Width="341px">
    </asp:GridView>
</p>
</asp:Content>
