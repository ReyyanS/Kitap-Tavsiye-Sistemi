<%@ Page Title="" Language="C#" MasterPageFile="~/MasterKullanici.Master" AutoEventWireup="true" CodeBehind="KullaniciProfil.aspx.cs" Inherits="KitapTavsiyeSistemi1.KullaniciProfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 100%;
        }
    .auto-style5 {
        color: #FF9900;
    }
    .auto-style6 {
        font-weight: bold;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style4">
        <tr>
            <td>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="152px" Width="138px" ImageUrl="~/Resimler/user-icon-360x360.jpg" />
            &nbsp;<br />
                <br />
                <b>İsim
    </b>
    <asp:Label ID="Label2" runat="server" Text="Soyisim" CssClass="auto-style6"></asp:Label>
            </td>
            <td>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="isimsoyisimlbl" runat="server" Text="Label" style="font-weight: 700; color: #996600"></asp:Label>&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td><strong>Okunan Kitaplar</strong></td>
            <td>
                <asp:DataList ID="DataListOkunanKitaplar" runat="server" style="color: #996600; font-weight: 700">
                    <ItemTemplate>
                        <table class="auto-style4">
                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("KitapAdi") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
<p class="auto-style5">
    <strong>Verilen Puanlar</strong></p>
            </td>
            <td>
                <asp:GridView ID="GridView1" runat="server" Width="292px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="font-weight: 700; color: #996600">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
<p style="font-weight: 700">
    İncelemelerin</p>
            </td>
            <td>
                <asp:GridView ID="GridViewInceleme" runat="server" Width="289px" style="font-weight: 700; color: #996600">
                </asp:GridView>
                </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
<p style="font-weight: 700">
    Alıntıların</p>
            </td>
            <td>
                <asp:GridView ID="GridViewAlinti" runat="server" Width="291px" style="font-weight: 700; color: #996600">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    <br />
</p>
</asp:Content>
