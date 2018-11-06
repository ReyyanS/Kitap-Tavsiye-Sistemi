<%@ Page Title="" Language="C#" MasterPageFile="~/MasterKullanici.Master" AutoEventWireup="true" CodeBehind="KullaniciAra.aspx.cs" Inherits="KitapTavsiyeSistemi1.Kullaniciara" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style5 {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#8C6251" Text="Kullanıcı Ara"></asp:Label>
</p>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#AFB13D" Text="Kullanıcı Adı"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="Ara" OnClick="Button2_Click" />
</p>
<p>
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <table class="auto-style5">
                <tr>
                    <td>
                       <a href="KullaniciDetay.aspx?KullaniciId=<%#Eval("KullaniciId") %>"><asp:Label ID="Label4" runat="server" Text='<%# Eval("KullaniciAdi") %>' style="font-weight: 700; font-size: x-large"></asp:Label></a> 
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
