<%@ Page Title="" Language="C#" MasterPageFile="~/MasterKullanici.Master" AutoEventWireup="true" CodeBehind="YazarSonuc.aspx.cs" Inherits="KitapTavsiyeSistemi1.YazarSonuc" %>
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
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("YazarAdSoyad") %>'></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        <br />
    </p>
</asp:Content>
