<%@ Page Title="" Language="C#" MasterPageFile="~/MasterKullanici.Master" AutoEventWireup="true" CodeBehind="YazarDetay.aspx.cs" Inherits="KitapTavsiyeSistemi1.YazarDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            color: #99CC00;
        }
        .auto-style6 {
            font-size: x-large;
            color: #669900;
        }
        .auto-style7 {
            font-size: large;
        }
        .auto-style8 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;&nbsp;<asp:Label ID="LabelYazarAd" runat="server" style="color: #FF9900; font-size: xx-large" Text="Label"></asp:Label>
    </p>
    <p class="auto-style7">
        Doğum Tarihi
        <asp:Label ID="LabelDogumTarih" runat="server" style="color: #000000" Text="Label"></asp:Label>
    </p>
    <p class="auto-style7">
        Doğum Yeri
        <asp:Label ID="LabelDogumYer" runat="server" style="color: #000000" Text="Label"></asp:Label>
    </p>
    <p class="auto-style7">
        Ölüm Tarihi
        <asp:Label ID="LabelOlum" runat="server" style="color: #000000" Text="Label"></asp:Label>
    </p>
    <p class="auto-style6">
        Yazarın Kitapları</p>
    <p class="auto-style6">
        <asp:DataList ID="DataList2" runat="server">
            <ItemTemplate>
                <table class="auto-style8">
                    <tr>
                        <td>
                          <asp:Label ID="Label2" runat="server" style="color: #000000" Text='<%# Eval("KitapAdi") %>'></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </p>
</asp:Content>
