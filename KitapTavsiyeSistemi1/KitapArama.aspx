<%@ Page Title="" Language="C#" MasterPageFile="~/MasterKullanici.Master" AutoEventWireup="true" CodeBehind="KitapArama.aspx.cs" Inherits="KitapTavsiyeSistemi1.KitapArama" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style5 {
        width: 100%;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Kitap Arama"></asp:Label>
</p>
<p>
    <asp:Label ID="Label3" runat="server" Text="Kitap Adı "></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button2" runat="server" Text="Ara" OnClick="Button2_Click" />
</p>
<p>
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <table class="auto-style5">
                <tr>
                    <td>
                         <a href="KitapDetay.aspx?KitapID=<%#Eval("KitapID") %>"><asp:Label ID="Label2" runat="server" Font-Names="Arial Black" style="font-weight: 700" Text='<%# Eval("KitapAdi") %>'></asp:Label></a>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    </p>
<p>
    <br />
</p>
<p>
</p>
</asp:Content>
