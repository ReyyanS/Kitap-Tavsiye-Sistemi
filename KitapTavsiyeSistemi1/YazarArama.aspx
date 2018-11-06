<%@ Page Title="" Language="C#" MasterPageFile="~/MasterKullanici.Master" AutoEventWireup="true" CodeBehind="YazarArama.aspx.cs" Inherits="KitapTavsiyeSistemi1.YazarArama" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="margin-top: 0px">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label2" runat="server" Text="Yazar Arama"></asp:Label>
</p>
<p style="margin-top: 0px">
    <asp:Label ID="Label3" runat="server" Text="Yazar Adı"></asp:Label>
&nbsp;
    <asp:TextBox ID="TxtAra" runat="server"></asp:TextBox>
&nbsp;
    <asp:Button ID="Ara" runat="server" OnClick="Ara_Click" Text="Ara" />
</p>
    <p style="margin-top: 0px">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="auto-style4">
                    <tr>
                        <td>
                            <a href="YazarDetay.aspx?YazarID=<%#Eval("YazarID") %>"> <asp:Label ID="Label2" runat="server" Text='<%# Eval("YazarAdSoyad") %>' style="font-weight: 700; font-size: x-large"></asp:Label></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
</p>
<p style="margin-top: 0px">
    &nbsp;</p>
<p style="margin-top: 0px">
    &nbsp;</p>
<p style="margin-top: 0px">
    &nbsp;</p>
</asp:Content>
