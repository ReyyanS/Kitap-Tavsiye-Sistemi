<%@ Page Title="" Language="C#" MasterPageFile="~/MasterKullanici.Master" AutoEventWireup="true" CodeBehind="YuksekPuanlilar.aspx.cs" Inherits="KitapTavsiyeSistemi1.YuksekPuanlilar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="auto-style4">
                    <tr>
                        <td>
                            <a href="KitapDetay.aspx?KitapID=<%#Eval("KitapID") %>"><asp:Label ID="Label2" runat="server" Text='<%# Eval("KitapAdi") %>' style="font-weight: 700; font-size: x-large"></asp:Label></a>
                        </td>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("YazarAdSoyad") %>' style="font-weight: 700"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("PuanOrtalama") %>' Font-Names="Bauhaus 93" style="font-weight: 700; color: #FF0000"></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        <br />
    </p>
</asp:Content>
