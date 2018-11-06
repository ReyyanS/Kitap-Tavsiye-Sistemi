<%@ Page Title="" Language="C#" MasterPageFile="~/MasterKullanici.Master" AutoEventWireup="true" CodeBehind="PopularKitap2.aspx.cs" Inherits="KitapTavsiyeSistemi1.PopularKitap2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
    <ItemTemplate>
        <table class="auto-style4">
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />

                 <a href="KitapDetay.aspx?KitapID=<%#Eval("KitapID") %>"><asp:Label ID="Label2" runat="server" Font-Names="Arial Black" style="font-weight: 700" Text='<%# Eval("KitapAdi") %>'></asp:Label></a>
                    &nbsp;&nbsp;&nbsp; 

                </td>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("YazarAdSoyad") %>'></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>
                    <br />
                    <asp:Label ID="Label4" runat="server" Font-Names="Bauhaus 93" style="color: #FF0000" Text='<%# Eval("OkunmaSayisi") %>'></asp:Label>
                </td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>
</asp:Content>
