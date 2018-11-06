<%@ Page Title="" Language="C#" MasterPageFile="~/MasterKullanici.Master" AutoEventWireup="true" CodeBehind="PopularYazar.aspx.cs" Inherits="KitapTavsiyeSistemi1.PopularYazar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style4">
        <tr>
            <td>&nbsp;<asp:DataList ID="DataList1" runat="server">
                <ItemTemplate>
                    <table class="auto-style4">
                        <tr>
                            <td>
                               <a href="YazarDetay.aspx?YazarID=<%#Eval("YazarID") %>"> <asp:Label ID="Label2" runat="server" Text='<%# Eval("YazarAdSoyad") %>' style="font-weight: 700; font-size: x-large"></asp:Label></a>
                                &nbsp;
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("OkunmaSayisi") %>' style="font-size: x-large; color: #FF0000"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
    </table>
</asp:Content>
